using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Xml.Serialization;

namespace F1sh.Core.Domain.FlightBooking
{
    public class FlightBooking : BaseEntity
    {
        public FlightBooking()
        {
            Segments = new List<FlightReservationSegment>();
            Passengers = new List<FlightReservationPassenger>();
        }

        public Guid UniqueId { get; set; }

        public string PnrNo { get; set; }

        public DateTime DepartureDateTime { get; set; }

        public DateTime? ArrivalDateTime { get; set; }

        public bool Sms { get; set; }

        public bool Ins { get; set; }

        public bool Seat { get; set; }

        public bool Baggage { get; set; }

        public string Departure { get; set; }

        public string Destination { get; set; }

        public JourneyType JourneyType { get; set; }

        public decimal TotalCost { get; set; }

        public DateTime BookingDate { get; set; }

        public string Currency { get; set; }

        public long CustomerId { get; set; }

        public string CurrentCurrency { get; set; }

        public string OriginalData { get; set; }

        #region Navigation Properties

        public virtual ICollection<FlightReservationSegment> Segments { get; set; }

        public virtual ICollection<FlightReservationPassenger> Passengers { get; set; }

        #endregion Navigation Properties

        #region Unmapped Properties

        [NotMapped]
        [XmlIgnore]
        public string DepartureCityName => OutboundSegments.Any() ? OutboundSegments.First().DepartureCityName : string.Empty;

        [NotMapped]
        [XmlIgnore]
        public string DestinationCityName => OutboundSegments.Any() ? OutboundSegments.Last().ArrivalCityName : string.Empty;

        [NotMapped]
        [XmlIgnore]
        public string AirlineCode => OutboundSegments.First().AirlineCode;

        [XmlIgnore]
        [NotMapped]
        public string FlightNumber => OutboundSegments.First().FlightNumber;

        [NotMapped]
        [XmlIgnore]
        public CabinClass CabinClass => OutboundSegments.First().CabinClass;

        [NotMapped]
        public IEnumerable<FlightReservationSegment> OutboundSegments
        {
            get
            {
                if (!Segments.IsNullOrEmpty())
                {
                    return Segments.Where(x => !x.IsInbound);
                }
                return Enumerable.Empty<FlightReservationSegment>();
            }
        }

        [NotMapped]
        public IEnumerable<FlightReservationSegment> InboundSegments
        {
            get
            {
                if (!Segments.IsNullOrEmpty())
                {
                    return Segments.Where(x => x.IsInbound);
                }
                return Enumerable.Empty<FlightReservationSegment>();
            }
        }

        [NotMapped]
        public bool IsReturnFlight => !InboundSegments.IsNullOrEmpty();

        [NotMapped]
        public Guid CustomerAsGuidId { get; set; }

        /// <summary>
        /// Number of days between booking date and travel date.
        /// </summary>
        [NotMapped]
        [XmlIgnore]
        public int WaitingDays => (DepartureDateTime - BookingDate).Days;

        [NotMapped]
        [XmlIgnore]
        public FlightReservationPassenger Customer { get; set; }

        #endregion Unmapped Properties
    }

    public class FlightBookingMap : GoqEntityTypeConfiguration<FlightBooking>
    {
        public FlightBookingMap()
        {
            ToTable("FlightBookings");
            HasKey(x => x.Id);
            Property(x => x.UniqueId).IsRequired();
            Property(x => x.PnrNo).HasMaxLength(25).IsUnicode(false);
            Property(x => x.DepartureDateTime).IsRequired();
            Property(x => x.Sms).IsRequired();
            Property(x => x.Ins).IsRequired();
            Property(x => x.Seat).IsRequired();
            Property(x => x.Baggage).IsRequired();
            Property(x => x.Departure).IsRequired().HasMaxLength(4).IsUnicode(false);
            Property(x => x.Destination).IsRequired().HasMaxLength(4).IsUnicode(false);
            Property(x => x.JourneyType).IsRequired();
            Property(x => x.TotalCost).IsRequired().HasPrecision(18, 4);
            Property(x => x.BookingDate).IsRequired();
            Property(x => x.Currency).HasMaxLength(3).IsUnicode(false).IsFixedLength();
            Property(x => x.CustomerId).IsRequired();
            Property(x => x.CurrentCurrency).HasMaxLength(3).IsUnicode(false).IsFixedLength();
            Property(x => x.OriginalData).IsMaxLength().IsUnicode(true);

            Ignore(x => x.DepartureCityName);
            Ignore(x => x.DestinationCityName);
            Ignore(x => x.AirlineCode);
            Ignore(x => x.FlightNumber);
            Ignore(x => x.CabinClass);
            Ignore(x => x.IsReturnFlight);
            Ignore(x => x.CustomerAsGuidId);
            Ignore(x => x.WaitingDays);
            Ignore(x => x.Customer);

            Ignore(x => x.OutboundSegments);
            Ignore(x => x.InboundSegments);
        }
    }
}

using System;

namespace Nop.Core.Domain.FlightBooking
{
    public class FlightReservationSegment : BaseEntity
    {
        public FlightReservationSegment(bool isInbound)
        {
            IsInbound = isInbound;
        }
        public int FlightBookingId { get; set; }

        public bool IsInbound { get; set; }

        public string DepartureAirportCode { get; set; }

        public string DepartureCityName { get; set; }

        public DateTime DepartureDateTime { get; set; }

        public string ArrivalAirportCode { get; set; }

        public string ArrivalCountryCode { get; set; }

        public string ArrivalCityName { get; set; }

        public DateTime ArrivalDateTime { get; set; }

        public string AirlineCode { get; set; }

        public string FlightNumber { get; set; }

        public CabinClass CabinClass { get; set; }

        public decimal AdultFareTotal { get; set; }

        public decimal AdultTaxTotal { get; set; }

        public decimal ChildFareTotal { get; set; }

        public decimal ChildTaxTotal { get; set; }

        public decimal InfantFareTotal { get; set; }

        public decimal InfantTaxTotal { get; set; }

        public virtual FlightBooking FlightBooking { get; set; }

       
    }
    public class FlightReservationSegmentMap : GoqEntityTypeConfiguration<FlightReservationSegment>
    {
        public FlightReservationSegmentMap()
        {
            ToTable("FlightBookings_Segments");
            HasKey(x => x.Id);
            Property(x => x.FlightBookingId).IsRequired();
            Property(x => x.IsInbound).IsRequired();
            Property(x => x.DepartureAirportCode).IsRequired().HasMaxLength(4).IsUnicode(false);
            Property(x => x.DepartureCityName).HasMaxLength(128).IsUnicode(true);
            Property(x => x.DepartureDateTime).IsRequired();
            Property(x => x.ArrivalAirportCode).IsRequired().HasMaxLength(4).IsUnicode(false);
            Property(x => x.ArrivalCountryCode).HasMaxLength(2).IsUnicode(false).IsFixedLength();
            Property(x => x.ArrivalCityName).HasMaxLength(128).IsUnicode(true);
            Property(x => x.ArrivalDateTime).IsRequired();
            Property(x => x.AirlineCode).HasMaxLength(3).IsUnicode(false);
            Property(x => x.FlightNumber).HasMaxLength(10).IsUnicode(false);
            Property(x => x.CabinClass).IsRequired();
            Property(x => x.AdultFareTotal).IsRequired().HasPrecision(18, 4);
            Property(x => x.AdultTaxTotal).IsRequired().HasPrecision(18, 4);
            Property(x => x.ChildFareTotal).IsRequired().HasPrecision(18, 4);
            Property(x => x.ChildTaxTotal).IsRequired().HasPrecision(18, 4);
            Property(x => x.InfantFareTotal).IsRequired().HasPrecision(18, 4);
            Property(x => x.InfantTaxTotal).IsRequired().HasPrecision(18, 4);

            HasRequired(x => x.FlightBooking).WithMany(x => x.Segments).HasForeignKey(x => x.FlightBookingId);
        }
    }
}

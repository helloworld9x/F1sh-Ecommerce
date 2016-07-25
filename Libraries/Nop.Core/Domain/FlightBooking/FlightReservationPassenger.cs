using System;
using System.Xml.Serialization;

namespace F1sh.Core.Domain.FlightBooking
{
    public class FlightReservationPassenger : BaseEntity
    {
        public int FlightBookingId { get; set; }

        public string Email { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Telephone { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string Nationality { get; set; }

        public string PassportNo { get; set; }

        public DateTime PassportExpDate { get; set; }

        public string PassportCountry { get; set; }

        public string TicketNumber { get; set; }

        public PassengerType PassengerType { get; set; }

        public bool IsAlreadyPurchasedMeal { get; set; }

        [XmlIgnore]
        public string SeatNumber { get; set; }

        [XmlIgnore]
        public bool SmokingPrefOfferedIndicator { get; set; }

        [XmlIgnore]
        public string SeatTypeCode { get; set; }

        [XmlIgnore]
        public string SeatStatusCode { get; set; }

        [XmlIgnore]
        public string PassengerAncillariesJson { get; set; }
    }

    public class FlightReservationPassengerMap : GoqEntityTypeConfiguration<FlightReservationPassenger>
    {
        public FlightReservationPassengerMap()
        {
            ToTable("FlightBookings_Passengers");
            HasKey(x => x.Id);
            Property(x => x.FlightBookingId).IsRequired();
            Property(x => x.Email).HasMaxLength(255).IsUnicode(true);
            Property(x => x.Title).HasMaxLength(15).IsUnicode(true);
            Property(x => x.LastName).HasMaxLength(128).IsUnicode(true);
            Property(x => x.FirstName).HasMaxLength(128).IsUnicode(true);
            Property(x => x.MiddleName).HasMaxLength(128).IsUnicode(true);
            Property(x => x.Gender).HasMaxLength(10).IsUnicode(false);
            Property(x => x.DateOfBirth).IsRequired();
            Property(x => x.Telephone).HasMaxLength(128).IsUnicode(false);
            Property(x => x.AddressLine1).HasMaxLength(128).IsUnicode(true);
            Property(x => x.AddressLine2).HasMaxLength(128).IsUnicode(true);
            Property(x => x.AddressLine3).HasMaxLength(128).IsUnicode(true);
            Property(x => x.Nationality).HasMaxLength(128).IsUnicode(true);
            Property(x => x.PassportNo).HasMaxLength(25).IsUnicode(false);
            Property(x => x.PassportExpDate).IsRequired();
            Property(x => x.PassportCountry).HasMaxLength(128).IsUnicode(true);
            Property(x => x.TicketNumber).HasMaxLength(128).IsUnicode(false);
            Property(x => x.PassengerType).IsRequired();
            Property(x => x.IsAlreadyPurchasedMeal).IsRequired().HasColumnName("HasAlreadyPurchasedMeal");
            Property(x => x.SeatNumber).HasMaxLength(10).IsUnicode(false);
            Property(x => x.SmokingPrefOfferedIndicator).IsRequired();
            Property(x => x.SeatTypeCode).HasMaxLength(10).IsUnicode(false);
            Property(x => x.SeatStatusCode).HasMaxLength(10).IsUnicode(false);
            Property(x => x.PassengerAncillariesJson).IsMaxLength().IsUnicode(true).HasColumnName("PassengerAncillaries");
        }
    }
}

namespace Hotel_Assignment.Models
{
    public class HotelBooking
    {
        public int Id { get; set; }
        public string GuestName { get; set; } = String.Empty;
        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; } 
       
    }
}

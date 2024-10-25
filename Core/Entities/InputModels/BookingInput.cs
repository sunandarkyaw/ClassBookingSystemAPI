namespace Core.Entities.InputModels
{
    public class PurchaseInput
    {

    }

    public class BookingInput
    {
        public string classID { get; set; }
        public string userID { get; set; }
    }

    public class CancelInput
    {
        public string bookingID { get;set; } 
    }
}

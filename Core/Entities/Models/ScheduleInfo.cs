namespace Core.Entities.Models
{
    public class ScheduleInfo
    {
        public string countryName { get; set; }
        public string classID { get; set; }
        public string className { get; set; }
        public string classStartDate {  get; set; }
        public int classCredit { get; set; }
        public decimal classPrice { get; set; }
        public int availableSlot { get; set; }
    }
}

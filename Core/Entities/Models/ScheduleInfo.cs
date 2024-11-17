namespace Core.Entities.Models
{
    public class ScheduleInfo
    {
        public string countryName { get; set; }
        public string classID { get; set; }
        public string className { get; set; }
        public string classStartDate { get; set; }
        public int classCredit { get; set; }
        public decimal classPrice { get; set; }
        public int availableSlot { get; set; }
        public string countryID { get; set; }
    }

    public class PackageInfo
    {
        public string countryName { get; set; }
        public string packageID { get; set; }
        public string packageName { get; set; }
        public string expiryDate { get; set; }
        public int packageCredit { get; set; }
        public decimal packagePrice { get; set; }
        public string countryID { get; set; }
    }
}

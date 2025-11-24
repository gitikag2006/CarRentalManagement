namespace CarRentalManagement.Domain
{
    public class Vehicle:BaseDomainModel
    {
        public int Year { get; set; }
        public string? LisencePlateNumber { get; set; }
        public int MakeId { get; set; }
        public int ColorId{ get; set; }
        public int ModelId { get; set; }
    }
}

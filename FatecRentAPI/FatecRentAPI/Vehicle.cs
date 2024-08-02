namespace FatecRentAPI
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string Category {  get; set; }
        public string Model { get; set; }
        public int CapacidadePassageiro { get; set; }
        public string Combustivel { get; set; }
        public decimal Price {  get; set; }

    }
}

namespace TransportManager.Models
{
    public class Airway
    {
        public int Id { get; set; }
        public string AirplaneType { get; set; }
        public string AirfieldType { get; set; }
        public string Strict { get; set; }
        public int Length { get; set; }
        public int Capacity { get; set; }
    }
}

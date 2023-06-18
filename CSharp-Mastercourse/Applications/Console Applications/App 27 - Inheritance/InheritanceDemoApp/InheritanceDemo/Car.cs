namespace InheritanceDemo
{
    class Car : Vehicle 
    {
        public string CarClassification { get; set; }   
        public string BodyStyle { get; set; }
        public string EngineType { get; set; }
        public string TransmissionType { get; set; }
        public string Drivetrain { get; set; }
        public string FuelType { get; set; }

        public string[] Features { get; set; }

        public int FuelCapacity { get; set; }
        public int FuelConsumption { get; set; }
        public int NumberOfWheels { get; set; }

        public float EngineSize { get; set; }
        public float AccelerationTime { get; set; }

        public bool HasAirbags { get; set; }
    }
}

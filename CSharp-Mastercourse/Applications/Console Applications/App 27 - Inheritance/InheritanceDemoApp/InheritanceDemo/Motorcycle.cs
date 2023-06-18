namespace InheritanceDemo
{
    class Motorcycle : Vehicle
    {
        public string MotorcycleType { get; set; } // Standard, Touring, Sport, ...
        public string MotorcycleCategory { get; set; } // Lighweight, Middleweight, Heavy

        public int EngineDisplacement { get; set; } // In ccs (400cc, 750cc, 1200cc)
        public int FuelCapacity { get; set; }

        public bool HasSideCar { get; set; }
    }
}

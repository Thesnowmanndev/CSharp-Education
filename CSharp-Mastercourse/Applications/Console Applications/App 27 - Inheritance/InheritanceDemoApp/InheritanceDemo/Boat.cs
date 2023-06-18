namespace InheritanceDemo
{
    class Boat : Vehicle
    {
        public string BoatType { get; set; } // Sailboat, Motorboat, Yacht
        public string WatercraftType { get; set; } // Fishing Boat, Speedboat, Cruiser
        public string HullMaterial { get; set; }
        public string PropulsionType { get; set; }

        public string[] SafetyEquipment { get; set; }

        public int Draft { get; set; }
        public int MaximumCapacity { get; set; }
        public int FuelCapacity { get; set; }

        public float Length { get; set; }

        public bool HasNavigationSystem { get; set; }
        public bool HasCabin { get; set; }
    }
}

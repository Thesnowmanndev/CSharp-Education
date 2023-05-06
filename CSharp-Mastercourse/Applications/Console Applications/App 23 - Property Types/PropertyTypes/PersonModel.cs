namespace PropertyTypes
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public string FullAddress
        {
            get { return $"{StreetAddress} {City}, {State} {PostalCode}"; }
        }
    }
}

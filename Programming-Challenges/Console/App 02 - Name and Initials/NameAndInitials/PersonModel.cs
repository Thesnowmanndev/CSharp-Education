namespace NameAndInitials
{
    internal class PersonModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }  
        public string LastName { get; set; }

        public char FirstInitial
        {
            get { return FirstName[0]; }
        }
        public char MiddleInitial
        {
            get { return MiddleName[0]; }
        }
        public char LastInitial
        {
            get { return LastName[0]; }
        }
    }
}

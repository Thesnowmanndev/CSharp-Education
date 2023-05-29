namespace GuestBookLibrary.Models
{
    public class PartyModel
    {
        public string? PartyName { get; init; }
        public int PartySize { get; set; }  

        public PartyModel(string name, int size) 
        {
            PartyName = name;
            PartySize = size;
        }
    }
}

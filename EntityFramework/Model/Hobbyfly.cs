namespace EntityFramework.Model
{
    public class Hobbyfly
    {
        public int HobbyflyID { get; set; }
        public string Model { get; set; }
        public List<Ejer> Ejere { get; set; } = new List<Ejer>();
    }
}
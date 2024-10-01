using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Model
{
    [Table("Ejer")]
    public class Ejer
    {
        public int EjerID { get; set; }
        public string Name { get; set; }
        public List<Bil> Biler { get; } = new List<Bil>();
        public List<Hobbyfly> Hobbyfly { get; set; } = new List<Hobbyfly>();

        public Ejer()
        {
            Biler = new List<Bil>();
            Hobbyfly = new List<Hobbyfly>();
        }
    }
}
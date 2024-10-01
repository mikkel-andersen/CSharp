using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Model
{

    [Table("Bil")]
    public class Bil
    {
        public int BilID { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public Ejer? Ejer { get; set; }
        
    }
}
using System.ComponentModel.DataAnnotations;

namespace SharedAssemblies2.Models
{
    public class Name
    {
        [Key]
        public int id { get; set; }

        [MaxLength(50)]
        public string Value { get; set; }
        
        public string GetValue => Value;
    }
}
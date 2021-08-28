using System.ComponentModel.DataAnnotations;

namespace SharedAssemblies
{
    public class Name
    {
        [Key]
        public int id { get; set; }

        [MaxLength(50)]
        public string Value { get; set; }
    }
}
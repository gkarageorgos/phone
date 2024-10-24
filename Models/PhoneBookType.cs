using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models
{
    public class PhoneBookType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Τύπος")]
        public string Name { get; set; } = null!;
    }
}

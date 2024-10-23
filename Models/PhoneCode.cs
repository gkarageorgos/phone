using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models
{
    public class PhoneCode
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        [DisplayName("Κωδικός")]
        public string Name { get; set; } = null!;
    }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(50)]
        [DisplayName("Όνομα")]
        public string? Name { get; set; }

        [StringLength(100)]
        [DisplayName("Επίθετο")]
        public string? Surname {  get; set; }

        [StringLength(200)]
        [DisplayName("Σημειώσεις")]
        public string? Notes { get; set; }

        public ICollection<Phone> Phones { get; set; } = [];

        public ICollection<Email> Emails { get; set; } = [];

        public int? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}

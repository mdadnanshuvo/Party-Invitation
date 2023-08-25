using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestRespond
    {
        [Key]
        public Guid Id { get; set; }
        [Required (ErrorMessage ="Please give your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please give your valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please give your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify wheter you'll come")]
        public bool? willAttend { get; set; }
    }
}

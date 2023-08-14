using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Localization.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessageResourceName = "Required",ErrorMessageResourceType = typeof(Resources.SharedResource))]
        [Display(Name = "Name", ResourceType = typeof(Resources.SharedResource))]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Address")]
        public string Address { get; set; }
    }
}

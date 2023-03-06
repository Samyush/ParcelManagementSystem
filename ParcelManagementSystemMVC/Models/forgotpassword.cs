using System.ComponentModel.DataAnnotations;

namespace ParcelManagementSystemMVC.Models
{
    public class forgotpassword
    {

        public int forgot_id { get; set; }

        [Required(ErrorMessage ="please enter the new password")]
        public string new_password { get; set; }
        [Required(ErrorMessage ="please enter conform password")]
        public string conform_password { get; set; }

        //setup relashionship 
        public List<ParcelManagement> ParcelManagements { get; set; }    



    }
}

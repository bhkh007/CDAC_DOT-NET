using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace Motion_Mint.Models
{
    public class Admin
    {
        [Key]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@(gmail\.com|yahoo\.com)$",
        ErrorMessage = "Email must be a valid Gmail or Yahoo email address.")]
        public string Email { get; set; }

        //[Required]
        [MaxLength(100)]
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
        ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit, one special character, and be at least 8 characters long.")]
        public string Password { get; set; }
        public List<Admin> getAdmin(String username,String password)
        {
            List<Admin> admins = new List<Admin>();
            SqlConnection con = new SqlConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                SqlDataReader rd;
                    rd = null; ;
                while (rd.Read())
                {
                   
                }
                return admins;
         
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

































        public bool getAdmins(String username, String password)
        {
            List<Admin> admins = new List<Admin>();
            SqlConnection con = new SqlConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                SqlDataReader rd;
                rd = null;
                if (rd != null)
                {
                    while (rd.Read())
                    {


                    }
                }
                return false;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true; ;
        }

    }
}

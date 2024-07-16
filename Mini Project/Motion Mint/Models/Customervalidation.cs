using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Motion_Mint.Models
{
    [MetadataType(typeof(CustomerMetaData))]
    public partial class Customer
    {

        public class CustomerMetaData 
        { 

        [DisplayName("CustomerName")]
        public string? Custname { get; set; }

        [DisplayName("Address")]
        public string? Address { get; set; }

        [DisplayName("Mobile")]
        public int? Mobile { get; set; }


        }
    }
}

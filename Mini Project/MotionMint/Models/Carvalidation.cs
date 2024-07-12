using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Motion_Mint.Models
{
    [MetadataType(typeof(CarregMetaData))]
    public partial class Carreg
    {
        public class CarregMetaData
        {
            [DisplayName("CarNo")]

            public string? Carno { get; set; }

            [DisplayName("Make")]
            public string? Make { get; set; }

            [DisplayName("Model")]
            public string? Model { get; set; }

            [DisplayName("Available")]
            public string? Available { get; set; }
        }
    }
}

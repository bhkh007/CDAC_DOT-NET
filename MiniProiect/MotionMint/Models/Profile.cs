namespace MotionMint.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}

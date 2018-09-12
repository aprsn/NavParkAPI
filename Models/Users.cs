namespace NavPark_API.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Mail { get; set; }
        public int RezerveSayisi { get; set; }
        public int Bakiye { get; set; }
    }
}
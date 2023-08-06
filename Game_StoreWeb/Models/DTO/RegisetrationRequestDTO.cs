namespace Game_StoreWeb.Models.DTO
{
    public class RegisetrationRequestDTO
    {
        public string? UserName { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; } = "customer";
    }
}

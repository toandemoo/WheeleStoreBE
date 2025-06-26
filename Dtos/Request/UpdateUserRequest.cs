
using System.Text.Json.Serialization;

namespace ProjectBE.DTOs.Request
{
    public class UpdateUserRequest
    {
        [JsonPropertyName("fullName")]
        public string? FullName { get; set; }

        [JsonPropertyName("phoneNumber")]
        public string? PhoneNumber { get; set; }

        [JsonPropertyName("profileImage")]
        public string? ProfileImage { get; set; }

        [JsonPropertyName("Address")]
        public string? Address { get; set; }

        [JsonPropertyName("Birth")]
        public DateTime Birth { get; set; }
    }
}
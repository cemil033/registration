using Microsoft.AspNetCore.Mvc;
using RegistrationPage.Models.ModelMetadataTypes;

namespace RegistrationPage.Models
{
    [ModelMetadataType(typeof(UserValidator))]
    public class User
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}

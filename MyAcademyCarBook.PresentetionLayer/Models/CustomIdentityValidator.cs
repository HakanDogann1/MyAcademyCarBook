using Microsoft.AspNetCore.Identity;

namespace MyAcademyCarBook.PresentetionLayer.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError(){
                Code= "PasswordRequiresLower",
                Description="Şifre küçük harf içermelidir."
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new()
            {
                Code = "PasswordRequiresUpper",
                Description = "Şifre büyük harf içermelidir."
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new()
            {
                Code = "PasswordRequiresDigit",
                Description = "Şifre en az 1 rakam içermelidir."
            };
        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new()
            {
                Code = "PasswordTooShort",
                Description = $"Şifre en az {length} karakter içermelidir."
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Şifre en az 1 sembol içermelidir."
            };
        }
    }
}

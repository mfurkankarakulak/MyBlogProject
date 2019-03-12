using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MyBlogProject.Entity.Models;

namespace CCC.Validations
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Kısmı Boş Olamaz !").Length(4, 50).WithMessage("İsim 4 ile 50 karakter arasında olmalıdır!");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soy İsim Kısmı Boş Olamaz !").Length(4, 50).WithMessage("Soy İsim 4 ile 50 karakter arasında olmalıdır!");
            RuleFor(x => x.EMailAdress).EmailAddress().WithMessage("Geçerli bir E-Posta adresi giriniz!");
            RuleFor(x => x.Password).Equal(x => x.Password2).WithMessage("Şifreler eşleşmiyor.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş olamaz.").When(x => x.Id == 0);
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon Numarası boş olamaz !").Length(11, 20).WithMessage("Telefon Numarası yanlış");
            RuleFor(x => x.CountryId).NotEmpty().WithMessage("Ülke boş geçilemez");
            RuleFor(x => x.CityId).NotEmpty().WithMessage("Şehit boş geçilemez");
        }
    }
}

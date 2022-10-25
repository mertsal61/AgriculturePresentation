using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Takım Arkadaşı İsmini Boş Geçemezsiniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev Kısmı Kısım Boş Geçilemez");
            RuleFor(x => x.Imageurl).NotEmpty().WithMessage("Resim Yolu Boş Geçilemez");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha az veri girişi yapın");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriş yapın");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen max 50 karakter veri girişi yapın");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen min üç karakter veri girişi yapın");
        }
    }
}

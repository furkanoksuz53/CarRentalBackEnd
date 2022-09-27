using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(p => p.CarId).NotEmpty().WithMessage("carId alanı boş bırakılamaz.");
            RuleFor(p => p.ImagePath).NotEmpty().WithMessage("lütfen bir resim seçiniz..");
        }
    }
}

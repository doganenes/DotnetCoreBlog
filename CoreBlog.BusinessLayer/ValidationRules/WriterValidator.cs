using CoreBlog.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
     public WriterValidator()
        {
            RuleFor(x=>x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre kısmı boş geçilemez.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın.");
            RuleFor(x => x.WriterName).MaximumLength(20).WithMessage("İsim 20 karakterden uzun olamaz.");
        }   
    }
}

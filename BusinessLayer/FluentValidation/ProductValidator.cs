using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adı boş olamaz !");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün adı boş olamaz !");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok sayısı boş olamaz !");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat boş olamaz !");

        }
    }
}

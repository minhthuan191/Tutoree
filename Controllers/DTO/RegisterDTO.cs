using FluentValidation;
using System.Text.RegularExpressions;

namespace Tutoree.Controllers.DTO
{
    public class RegisterDTO
    {
        public string Semester { set; get; }
        public int Year { set; get; }
        public string Major { set; get; }
        public string Location { set; get; }
        public string Password { set; get; }
        public string ConfirmPassword { set; get; }
        public string Email { set; get; }
          
        

        public class RegisterDTOValidator : AbstractValidator<RegisterDTO>
        {
            public RegisterDTOValidator()
            {
                RuleFor(x => x.Year).NotEmpty().GreaterThan(0);
                RuleFor(x => x.Semester).NotEmpty();
                RuleFor(x => x.Major).NotEmpty();
                RuleFor(x => x.Location).NotEmpty(); 
                RuleFor(x => x.Password).NotEmpty().Length(3, 50);
                RuleFor(x => x.ConfirmPassword).NotEmpty().Equal(x => x.Password);
                RuleFor(x => x.Email).NotEmpty().EmailAddress();

            }
        }
    }
}

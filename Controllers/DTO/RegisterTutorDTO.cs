using FluentValidation;
using System.Text.RegularExpressions;

namespace Tutoree.Controllers.DTO
{
    public class RegisterTutorDTO
    {
        public string Password { set; get; }
        public string ConfirmPassword { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string TeachingMethod { set; get; }
        public string Education { set; get; }
        public string Description { set; get; }
    }
        public class RegisterTutorDTOValidator : AbstractValidator<RegisterTutorDTO> {
            public RegisterTutorDTOValidator()
            {
                RuleFor(x => x.Password).NotEmpty().Length(3, 50);
                RuleFor(x => x.ConfirmPassword).NotEmpty().Equal(x => x.Password);
                RuleFor(x => x.Email).NotEmpty().EmailAddress();
                RuleFor(x => x.Phone).NotEmpty().NotNull().Matches(new Regex(@"^(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})\b"));
                RuleFor(x => x.Education).NotEmpty();
                RuleFor(x => x.TeachingMethod).NotEmpty();
                RuleFor(x => x.Description).NotEmpty();
            }
        }
    
}

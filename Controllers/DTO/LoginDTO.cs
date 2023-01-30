using FluentValidation;

namespace Tutoree.Controllers.DTO
{
    public class LoginDTO
    {
        public string Email { set; get; }
        public string Password { set; get; }

    }
    public class LoginDTOValidator : AbstractValidator<LoginDTO>
    {
        public LoginDTOValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Password).NotEmpty().Length(5, 30);

        }
    }
}

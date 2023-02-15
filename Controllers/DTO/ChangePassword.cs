using FluentValidation;

namespace Tutoree.Controllers.DTO
{
    public class ChangePasswordDTO
    {
        public string Password { set; get; }
        public string NewPassword { set; get; }
        public string ConfirmNewPassword { set; get; }

    }
    public class ChangePasswordDTOValidator : AbstractValidator<ChangePasswordDTO>
    {
        public ChangePasswordDTOValidator()
        {
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.NewPassword).NotEmpty().Length(5,50);
            RuleFor(x => x.ConfirmNewPassword).NotEmpty().Length(5, 50).Equal(x => x.NewPassword);
        }
    }
}

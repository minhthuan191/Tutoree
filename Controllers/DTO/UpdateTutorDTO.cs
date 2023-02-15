using FluentValidation;
using System.Text.RegularExpressions;

namespace Tutoree.Controllers.DTO
{
    public class UpdateTutorDTO
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
    }

    public class UpdateTutorDTOValidator : AbstractValidator<UpdateTutorDTO>
    {
        public UpdateTutorDTOValidator()
        {

            RuleFor(x => x.Name).NotEmpty().Length(5,50);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Phone).NotEmpty().NotNull().Matches(new Regex(@"^(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})\b"));
        }
    }
}

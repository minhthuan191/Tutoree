using FluentValidation;
using System.Text.RegularExpressions;

namespace Tutoree.Controllers.DTO
{
    public class UpdateStudentDTO
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public string Phone { set; get; }
        public int Year { set; get; }
        public string Semester { set; get; }
        public string LocationId { set; get; }
        public string MajorId { set; get; }
    }
    public class UpdateStudentDTOValidator : AbstractValidator<UpdateStudentDTO>
    {
        public UpdateStudentDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().Length(5, 50);
            RuleFor(x => x.Age).NotEmpty().Must(x => int.TryParse(x.ToString(), out _)).WithMessage("The field must be a integer value.");
            RuleFor(x => x.Phone).NotEmpty().NotNull().Matches(new Regex(@"^(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})\b"));
            RuleFor(x => x.Year).NotEmpty().Must(x => int.TryParse(x.ToString(), out _)).WithMessage("The field must be a integer value.");
            RuleFor(x => x.Semester).NotEmpty();
            RuleFor(x => x.LocationId).NotEmpty();
            RuleFor(x => x.MajorId).NotEmpty();
        }
    }
}

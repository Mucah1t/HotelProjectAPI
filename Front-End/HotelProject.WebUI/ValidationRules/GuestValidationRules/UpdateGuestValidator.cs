using FluentValidation;
using HotelProject.WebUI.DTOs.GuestDTO;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator : AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("This field can not be empty.");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("The City name has be larger then 3 char.");
        }  
    }
}

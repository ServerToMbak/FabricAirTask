using FluentValidation;

namespace FabricAirTask.Services.FluentValidation
{
    public class FileValidator : AbstractValidator<Entity.File>
    {
        public FileValidator()
        {
            RuleFor(p => p.Name).NotNull();
            RuleFor(p => p.UserId).NotNull(); 
            RuleFor(p => p.Id).NotNull();   
        }
    }
}

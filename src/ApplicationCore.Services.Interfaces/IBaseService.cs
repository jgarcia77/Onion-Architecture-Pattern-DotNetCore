namespace ApplicationCore.Services.Interfaces
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public interface IBaseService
    {
        List<ValidationResult> ValidationResults { get; set; }
    }

    public static class IBaseServiceExtensions
    {
        public static bool IsValidModel<T>(this IBaseService service, T model)
        {
            var returnValue = false;

            if (service.ValidationResults == null)
            {
                service.ValidationResults = new List<ValidationResult>();
            }

            var context = new ValidationContext(model, null, null);

            if (Validator.TryValidateObject(model, context, service.ValidationResults, true))
            {
                returnValue = true;
            }

            return returnValue;
        }
    }
}

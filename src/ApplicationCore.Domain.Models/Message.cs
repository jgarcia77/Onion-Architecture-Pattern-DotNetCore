namespace ApplicationCore.Domain.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Message : BaseModel
    {
        [Required]
        public string Value { get; set; }
    }
}

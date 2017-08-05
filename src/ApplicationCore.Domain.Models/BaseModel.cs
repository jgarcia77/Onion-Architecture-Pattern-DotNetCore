namespace ApplicationCore.Domain.Models
{
    using System;

    public abstract class BaseModel
    {
        public long Id { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime UpdatedUtc { get; set; }
    }
}

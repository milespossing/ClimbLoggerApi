using System;

namespace ClimbLogger.Api.Models
{
    public class ClimbEntry
    {
        public Guid Id { get; set; }
        public DateTime ClimbDate { get; set; }
        public string Grade { get; set; }
    }
}
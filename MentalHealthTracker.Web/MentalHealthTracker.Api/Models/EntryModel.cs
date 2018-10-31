using System;

namespace MentalHealthTracker.Api.Models
{
    public class EntryModel
    {
        public Guid EntryId { get; set; }
        public string UserId { get; set; }
        public DateTime? DateOfEntry { get; set; }
        public string Journal { get; set; }
        public string Medication { get; set; }
        public int Mood { get; set; }
    }
}
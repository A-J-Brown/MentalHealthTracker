using System;
using static MentalHealthTracker.Domain.Entities.Entry;

namespace MentalHealthTracker.Api.Models
{
    public class EntryModel
    {
        public Guid EntryId { get; set; }
        public UserModel User { get; set; }
        public DateTime? Date { get; set; }
        public string Journal { get; set; }
        public string Medication { get; set; }
        public Moods Mood { get; set; }
    }
}
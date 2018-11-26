using System;
using static MentalHealthTracker.Domain.Entities.Entry;

namespace MentalHealthTracker.Web.Models
{
    public class CreateEntryModel
    {
        public Guid EntryId { get; set; }
        public DateTime? Date { get; set; }
        public string Journal { get; set; }
        public string Medication { get; set; }
        public Moods Mood { get; set; }
    }
}
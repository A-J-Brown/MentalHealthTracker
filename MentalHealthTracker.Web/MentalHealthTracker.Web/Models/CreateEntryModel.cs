using System;
using static MentalHealthTracker.Domain.Entities.Entry;

namespace MentalHealthTracker.Web.Models
{
    public class CreateEntryModel
    {
        public Guid EntryId { get; set; }
        public DateTime? Date { get; set; }
        public String Journal { get; set; }
        public String Medication { get; set; }
        public Moods Mood { get; set; }
    }
}
using MentalHealthTracker.Domain.Entities;
using System;
using static MentalHealthTracker.Domain.Entities.Entry;

namespace MentalHealthTracket.Shared.ViewModels
{
    public class EntryViewModel
    {
        public Guid EntryId { get; set; }
        public DateTime? Date { get; set; }
        public string DateString => Date.ToString();
        public String Journal { get; set; }
        public String Medication { get; set; }
        public Moods Mood { get; set; }
        public string MoodString => Mood.ToString();
    }
}

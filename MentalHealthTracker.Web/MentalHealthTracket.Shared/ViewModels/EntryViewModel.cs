using System;
using static MentalHealthTracker.Domain.Entities.Entry;

namespace MentalHealthTracket.Shared.ViewModels
{
    public class EntryViewModel
    {
        public Guid EntryId { get; set; }
        public DateTime? Date { get; set; }
        public string DateString => String.Format("{0:MM/dd/yyyy}", Date);
        public string Journal { get; set; }
        public string Medication { get; set; }
        public Moods Mood { get; set; }
        public string MoodString => Mood.ToString();
    }
}

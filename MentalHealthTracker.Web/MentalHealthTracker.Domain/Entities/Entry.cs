using System;

namespace MentalHealthTracker.Domain.Entities
{
    public class Entry
    {
        public enum Moods
        {
            Depressed = 1,
            Angry = 2,
            Irritable = 3,
            Sad = 4,
            Anxious = 5,
            Tired = 6,
            Indifferent = 7,
            Content = 8,
            Happy = 9,
            Excited = 10
        }
        public Guid EntryId { get; set; }
        public User User { get; set; }
        public DateTime? Date { get; set; }
        public string Journal { get; set; }
        public string Medication { get; set; }
        public Moods Mood { get; set; }

    }
}

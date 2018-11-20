using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MentalHealthTracker.Domain;
using MentalHealthTracker.Domain.Entities;
using MentalHealthTracket.Shared.Orchestrators.Interfaces;
using MentalHealthTracket.Shared.ViewModels;

namespace MentalHealthTracket.Shared.Orchestrators
{
    public class EntryOrchestrator : IEntryOrchestrator
    {
        private MentalContext _mentalContext;

        public EntryOrchestrator()
        {
            _mentalContext = new MentalContext();
        }

        public async Task<List<EntryViewModel>> GetAllEntries()
        {
            var entries = await _mentalContext.Entries.Select(x => new EntryViewModel
            {
                EntryId = x.EntryId,
                Date = x.Date,
                Journal = x.Journal,
                Medication = x.Medication,
                Mood = x.Mood
            }).ToListAsync();

            return entries;
        }

        public async Task<int> CreateEntry(EntryViewModel entry)
        {
            _mentalContext.Entries.Add(new Entry
            {
                EntryId = Guid.NewGuid(),
                Date = DateTime.Now,
                Journal = entry.Journal,
                Medication = entry.Medication,
                Mood = entry.Mood
            });

            return await _mentalContext.SaveChangesAsync();
        }
    }
}

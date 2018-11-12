using MentalHealthTracker.Web.Models;
using MentalHealthTracket.Shared.Orchestrators;
using MentalHealthTracket.Shared.ViewModels;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MentalHealthTracker.Web.Controllers
{
    public class EntryController : Controller
    {
        private EntryOrchestrator _entryOrchestrator = new EntryOrchestrator();

        // GET: Entry
        public async Task<ActionResult> Index()
        {
            var entryDisplayModel = new EntryDisplayModel
            {
                Entries = await _entryOrchestrator.GetAllEntries()
            };

            return View(entryDisplayModel);
        }


        public async Task<ActionResult> Create(CreateEntryModel entry)
        {
            if (entry.Mood == 0)
            {
                return View();
            }

            var updateCount = await _entryOrchestrator.CreateEntry(new EntryViewModel
            {
                EntryId = Guid.NewGuid(),
                Date = DateTime.Now,
                Journal = entry.Journal,
                Medication = entry.Medication,
                Mood = entry.Mood
            });

            return View();
        }
    }
}
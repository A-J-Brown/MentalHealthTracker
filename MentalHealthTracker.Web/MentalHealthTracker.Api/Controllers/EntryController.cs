using System.Collections.Generic;
using MentalHealthTracker.Shared.Orchestrator;
using MentalHealthTracker.Shared.ViewModels;
using System.Threading.Tasks;
using System.Web.Http;

namespace MentalHealthTracker.Api.Controllers
{
    public class EntryController : ApiController
    {
        private EntryOrchestrator _entryOrchestrator;

        public EntryController()
        {
            _entryOrchestrator = new EntryOrchestrator();
        }

        public async Task<List<EntryViewModel>> GetAllEntries()
        {
            var entries = await _entryOrchestrator.GetAllEntries();

            return entries;
        }
    }
}
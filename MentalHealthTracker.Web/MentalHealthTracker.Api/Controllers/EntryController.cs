using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using MentalHealthTracket.Shared.Orchestrators;
using MentalHealthTracket.Shared.ViewModels;

namespace MentalHealthTracker.Api.Controllers
{
    [Route("api/v1/entries")]
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
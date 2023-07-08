using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElBoleto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {
        // GET: TicketController
        public ActionResult Index()
        {
            return Ok();
        }

        // GET: TicketController/Details/5
        public ActionResult Details(int id)
        {
            return Ok(id);
        }

        // GET: TicketController/Create
        public ActionResult Create()
        {
            return Ok();
        }

        // POST: TicketController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Ok();
            }
        }

        // GET: TicketController/Edit/5
        public ActionResult Edit(int id)
        {
            return Ok(id);
        }

        // POST: TicketController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Ok();
            }
        }

        // GET: TicketController/Delete/5
        public ActionResult Delete(int id)
        {
                return Ok(id);
        }

        // POST: TicketController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Ok(id);
            }
        }
    }
}

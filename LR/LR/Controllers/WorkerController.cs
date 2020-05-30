using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web;
using LR.Models;
using BLL.Object;

namespace LR.Controllers
{
    public class WorkerController : ApiController
    {
        [HttpPost]
        [Route ("api/Worker/Add")]
        public IHttpActionResult Add ([FromBody]WorkerModel model)
        {
            if (ModelState.IsValid)
            {
                Worker worker = new Worker (model.FirstName, model.SecondName);

                API.getWorkerService ().Add (worker, model.CafeName);

                return Ok ("");
            }
            return BadRequest ();
        }

        [HttpPost]
        [Route ("api/Worker/Remove")]

        public IHttpActionResult Remove ([FromBody]WorkerModel model)
        {
            Worker worker = new Worker (model.FirstName, model.SecondName);
            API.getWorkerService ().Remove (model.CafeName);
            return Ok ();
        }

        [HttpGet]
        [Route ("api/Worker/Get")]
        public IHttpActionResult Get ([FromBody]GetWorkersModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok (API.getWorkerService ().Get (model.CafeName));
            }
            return BadRequest ();
        }
    }
}
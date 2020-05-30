using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web;
using LR.Models;
using BLL.Object;

namespace Lab6.Controllers
{
    public class CafeController : ApiController
    {
        [HttpPost]
        [Route ("api/Cafe/Add")]
        public IHttpActionResult Add ([FromBody]AddCafeModel model)
        {
            if (ModelState.IsValid)
            {
                Cafe cafe = new Cafe (model.Name, model.Location, model.PlaceCount);

                API.getCafeService ().Add (cafe);

                return Ok ("");
            }
            return BadRequest ();
        }

        [HttpPost]
        [Route ("api/Cafe/Remove")]

        public IHttpActionResult Remove ([FromBody]CafeModel model)
        {
            API.getCafeService ().Remove (model.Name);
            return Ok ();
        }

        [HttpGet]
        [Route ("api/Cafe/Get")]
        public IHttpActionResult Get ([FromBody]CafeModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok (API.getCafeService ().Get (model.Name));
            }
            return BadRequest ();
        }
    }
}
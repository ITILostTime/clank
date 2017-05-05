using ClankApp.Models;
using ClankApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClankApp.Controllers
{
    public class BeepController : ApiController
    {
        private BeepRepository beepRepository;

        public BeepController()
        {
            this.beepRepository = new BeepRepository();
        }

        public Beep[] Get()
        {
            return beepRepository.GetAllBeeps();
        }
        public HttpResponseMessage Post(Beep beep)
        {
            this.beepRepository.SaveBeep(beep);
            var response = Request.CreateResponse<Beep>(System.Net.HttpStatusCode.Created, beep);
            return response;
        }
    }
}

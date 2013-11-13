using AutoMapper;
using Gestion.Wcf;
using Gestion.Wcf.Contracts;
using Gestion.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gestion.Web.Controllers
{
    public class PersonasController : Controller
    {
        //
        // GET: /Personas/
        public ActionResult Index()
        {
            var service = new PersonaWcf();
            var dtos = service.GetAll();
            Mapper.CreateMap<PersonaDto, PersonaModel>();
            var models = Mapper.Map<IEnumerable<PersonaModel>>(dtos);
            return View(models);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PersonaModel persona)
        {
            var service = new PersonaWcf();
            var dto = new PersonaDto();
            dto.Nombre = persona.Nombre;
            service.Alta(dto);
            return View("Index");
        }
	}
}
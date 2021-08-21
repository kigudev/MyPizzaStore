using Microsoft.AspNetCore.Mvc;
using MyPizzaStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPizzaStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzasController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Pizza>> Get() => PizzaService.GetAll();

        // obtener por ID
        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = PizzaService.Get(id);

            if (pizza == null)
                return NotFound();

            return pizza;
        }

        // guardar (POST)


        // editar (PUT)


        // eliminar (DELETE)
    }
}

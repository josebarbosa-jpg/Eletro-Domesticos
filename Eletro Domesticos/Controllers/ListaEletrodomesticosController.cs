using Eletro_Domesticos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eletro_Domesticos.Controllers
{
    public class ListaEletrodomesticosController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomestico> eletrodomesticos = new List<Eletrodomestico>()
            {
                new Geladeira { Marca = "Eletrolux", Modelo = "Duplex Frost Free", ConsumoEnergetico = 4000, CapacidadeLitros = 250, TemFreezer = true },
                new Televisor { Marca = "Lg", Modelo = "Alexa", ConsumoEnergetico = 500, TamanhoTela = 75 },
                new Geladeira { Marca = "Samsung", Modelo = "Duplex", ConsumoEnergetico = 3500, CapacidadeLitros = 500, TemFreezer = false },
                new Televisor { Marca = "SEMP", Modelo = "Cinema", ConsumoEnergetico = 400, TamanhoTela = 90 }
            };
            return View(eletrodomesticos);
        }
    }
}

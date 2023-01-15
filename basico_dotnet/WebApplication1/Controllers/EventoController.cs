using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
    
        public EventoController() { 
        
        }   

        //[HttpGet(Name = "GetEvento")]
        //public Evento Get()
        //{
        //    return new Evento()
        //    {
        //        EventoId = 1,
        //        Tema = "Angular e .NET Core",
        //        Local = "Belo Horizonte",
        //        Lote = "1 lote",
        //        QtdPessoas = 250,
        //        DataEvento = DateTime.Now.AddDays(2).ToString(),
        //        ImagemURL = "foto.png"
        //    };
        //}

        public IEnumerable<Evento> _evento =  new Evento[]
        {
                new Evento()
                {
                    EventoId = 1,
                    Tema = "Angular e .NET Core",
                    Local = "Belo Horizonte",
                    Lote = "1 lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "foto.png"
                },
                new Evento()
                {
                    EventoId = 2,
                    Tema = "Angular e suas novidades",
                    Local = "Belo Horizonte",
                    Lote = "1 lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "foto1.png"
                }
        };

        [HttpGet(Name = "GetEvento")]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
    }
}
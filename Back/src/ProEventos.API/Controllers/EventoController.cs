using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[]{
            new Evento()
            {
                EventoId = 1,
                Tema = "Angula e Suas novidades",
                Local = "Belo Horizonte",
                Lote = "1° Lote ",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
                ImagemURL = "foto.png"
            },
             new Evento()
            {
                EventoId = 2,
                Tema = "Angula 11 e .NET 5",
                Local = "Rio de Janeiro",
                Lote = "2° Lote ",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
                ImagemURL = "foto2.png"
            },
             new Evento()
             {
                EventoId = 3,
                Tema = "C# e AspNet Core MVC",
                Local = "São Paulo",
                Lote = "3° Lote ",
                QtdPessoas = 450,
                DataEvento = DateTime.Now.AddDays(5).ToString("dd/mm/yyyy"),
                ImagemURL = "foto3.png"
            }

         };

    public EventoController()
    {

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de Put com id = {id}";
    }

    [HttpPost]
    public string Post()
    {
        return "Exemplo de Post";
    }

}


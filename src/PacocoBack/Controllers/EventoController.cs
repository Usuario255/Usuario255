﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back.src.Pacoco.Data.DataContext;
using Pacoco.Domain.Evento;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PacocoBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase //Todo controller tem que ter o sufixo Controller
    {

       private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetPorId(int id)
        {
            return _context.Eventos.Where(evento => evento.Id == id);
        }
        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put {id}";
        }
        [HttpDelete]
        public string Delete()
        {
            return "Exemplo de Delete";
        }
    }
}
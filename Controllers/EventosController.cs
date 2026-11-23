using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaGerenciamentoEventos.Models;

namespace SistemaGerenciamentoEventos.Controllers
{
    public class EventosController : Controller
    {
        private static List<Evento> _evento = new()
        {
            new Evento{
                Id = 1,
                Nome = "Mundo SENAI 2026 - Cyber e IA",
                Descricao = "Experiências interativas de programação, IA e desafios de cibersegurança CTF",
                Local = "SENAI Paulo Antonio Skaf - R. Niterói, 180, Centro, São Caetano do Sul",
                DataEvento = new DateTime(2026, 11, 5, 9, 0, 0),
                QntdVagas = 200,
                ValorIngresso = 2700.99m
            },

            new Evento
            {
                Id = 2,
                Nome = "Hackathon de Cibersegurança e Defesa em Nuvem",
                Descricao = "Competição prática de análise de vulnerabilidades, proteção de redes e resposta a incidentes.",
                Local = "SENAI Paulo Antonio Skaf (Cyber e IA) - R. Niterói, 180, Centro, SCS",
                DataEvento = new DateTime(2027, 3, 12, 8, 30, 0),
                QntdVagas = 80,
                ValorIngresso = 42.71m
            }
        };

        public IActionResult Index()
        {
            return View(_evento);
        }

        public IActionResult Detalhes (int id)
        {
            var evento = _evento.FirstOrDefault(e => e.Id == id);
            if(evento == null)
            {
                return NotFound();
            }
            return View(evento);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Evento evento)
        {
            if(!ModelState.IsValid)
            {
                return View(evento);
            }

            evento.Id = _evento.Any() ? _evento.Max(e => e.Id) + 1 : 1;
            _evento.Add(evento);

            return RedirectToAction("Index");
        }

        
    }
}
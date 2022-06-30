using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RpgAPI.DTOs;
using RpgAPI.Models;
using RpgAPI.Services;

namespace RpgAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JogadorController : ControllerBase
    {
        public JogadorController()
        {
            services = new JogadorService();
        }

        private readonly JogadorService services; // O readonly proíbe o objeto de ser criado fora do construtor

        [HttpGet]
        public List<Jogador> getJogadores()
        {
            return services.getJogadores();
        }

        [HttpGet ("{id}")]
        // maneira utilizada para encurtar um método que possui apenas uma linha
        public Jogador getById(int id) => services.getById(id);     


        [HttpPost]
        public void postJogador(CriarJogadorDTO infoJogador)
        {
            services.postJogador(infoJogador);
        }

        [HttpPut("{id}")]

        public void putJogador(CriarJogadorDTO jogadorATT, int id)
        {
            services.putJogador(jogadorATT, id);
        }

        [HttpDelete ("{id}")]

        public void deleteJogador(int id) => services.deleteJogador(id);
        




    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RpgAPI.Models;
using RpgAPI.Services;
using RpgAPI.DTOs;

namespace RpgAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();
        public PessoaController()
        {
            service = new PessoaService();
        }
        private readonly PessoaService service;

        [HttpGet]
        public List<Pessoa> getPessoas() => service.getPessoa();

        [HttpGet("{id}")] // acrescentamos um parâmetro ID na URL do GET, isso diferencia um GET do outro
        public Pessoa getById(int id) => service.getById(id);

        [HttpPost]
        public void postPessoa(CriarPessoaDTO infoPessoa) => service.postPessoa(infoPessoa);

        [HttpPut("{id}")]
        public void putPessoa(CriarPessoaDTO pessoaATT, int id) => service.putPessoa(pessoaATT, id);


        [HttpDelete("{id}")]
        public void deleteById(int id) => service.deletePessoaById(id);



    }
}

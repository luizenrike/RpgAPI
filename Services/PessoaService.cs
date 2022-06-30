using System.Collections.Generic;
using RpgAPI.DTOs;
using RpgAPI.Models;

namespace RpgAPI.Services
{
    public class PessoaService
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();

        public List<Pessoa> getPessoa()
        {
            return pessoas;
        }

        public Pessoa getById(int id)
        {
            foreach(Pessoa p in pessoas)
            {
                if (p.id == id)
                    return p;
            }
            return null;
        }

        public void postPessoa(CriarPessoaDTO infoPessoa)
        {
            Pessoa novaPessoa = new Pessoa();
            novaPessoa.nome = infoPessoa.nome;
            novaPessoa.sobreNome = infoPessoa.sobreNome;
            novaPessoa.id = pessoas.Count + 1;
            pessoas.Add(novaPessoa);
        }

        public void putPessoa(CriarPessoaDTO pessoaATT, int id)
        {
            foreach(Pessoa p in pessoas)
            {
                if(p.id == id)
                {
                    p.nome = pessoaATT.nome;
                    p.sobreNome = pessoaATT.sobreNome;
                }
            }
        }

        public void deletePessoaById(int id)
        {
            for(int i = 0; i < pessoas.Count; i++)
            {
                if(pessoas[i].id == id)
                {
                    pessoas.RemoveAt(i);
                }
            }
        }

        public void deletePessoaByName(string nome, string sobrenome)
        {
            for(int i = 0; i < pessoas.Count; i++)
            {
                if (pessoas[i].nome == nome && pessoas[i].sobreNome == sobrenome)
                    pessoas.RemoveAt(i);
            }
        }

    }
}

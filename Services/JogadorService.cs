using System.Collections.Generic;
using RpgAPI.DTOs;
using RpgAPI.Models;

// usamos o jogadorService para realizar as operações que não devem ser executadas no Controller
namespace RpgAPI.Services
{
    public class JogadorService
    {
        private static List<Jogador> jogadores = new List<Jogador>();

        public List<Jogador> getJogadores()
        {
            return jogadores;
        }

        public Jogador getById(int id)
        {
            foreach(Jogador jogador in jogadores)
            {
                if(jogador.id == id)
                    return jogador;
            }
            return null;
        }

        public void postJogador(CriarJogadorDTO infoJogador)
        {
            Jogador novoJogador = new Jogador();
            novoJogador.nome = infoJogador.nome;
            novoJogador.defesa = infoJogador.defesa;
            novoJogador.vida = infoJogador.vida;

            if(infoJogador.arma != null)
            {
                novoJogador.arma = new Arma();
                novoJogador.arma.NomeArma = infoJogador.arma.Nome;
                novoJogador.arma.DanoArma = infoJogador.arma.Dano;
            }

            novoJogador.id = jogadores.Count + 1;
            jogadores.Add(novoJogador);
        }

        public void putJogador(CriarJogadorDTO jogadorATT, int id)
        {
            foreach (Jogador j in jogadores)
            {
                if (j.id == id)
                {
                    j.nome = jogadorATT.nome;
                    j.vida = jogadorATT.vida;
                    j.defesa = jogadorATT.defesa;

                    if (jogadorATT.arma == null)
                    {
                        j.arma = j.arma;
                    }
                    else
                    {
                        j.arma.DanoArma = jogadorATT.arma.Dano;
                        j.arma.NomeArma = jogadorATT.arma.Nome;
                    }
                }
            }
        }

        public void deleteJogador(int id)
        {
            for(int i = 0; i < jogadores.Count; i++)
            {
                if (jogadores[i].id == id)
                    jogadores.RemoveAt(i);
            }
        }

    }
}

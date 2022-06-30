using System.ComponentModel.DataAnnotations;
using RpgAPI.Models;


namespace RpgAPI.DTOs
{
    public class CriarJogadorDTO
    {
        [Required]
        public string nome { get; set; }
        [Required]
        public int vida { get; set; }
        [Required]
        public int defesa { get; set; }
        public CriarArmaDTO arma {get; set;}
    }


}

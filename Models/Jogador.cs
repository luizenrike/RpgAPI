namespace RpgAPI.Models
{
    public class Jogador
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int vida { get; set; }
        public int defesa { get; set; }
        public Arma arma { get; set; }

    }
}

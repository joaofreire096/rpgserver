using System;

namespace RPGServer.Models
{
    public class Aventura
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public Cidade Cidade { get; set; }
    }

    public class Cidade
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }
    }
}
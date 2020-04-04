using System;
using System.Collections.Generic;
using RPGServer.Models;

namespace RPGServer.Mocks
{
    public static class CidadeMock
    {
        public static List<Cidade> GetCidades()
        {
            return new List<Cidade>() {
                new Cidade()
                {
                    Id = Guid.NewGuid(),
                    Descricao = "Cidade 1"
                },
                new Cidade()
                {
                    Id = Guid.NewGuid(),
                    Descricao = "Cidade 2"
                },
                new Cidade()
                {
                    Id = Guid.NewGuid(),
                    Descricao = "Cidade 3"
                }
            };
        }
    }
}
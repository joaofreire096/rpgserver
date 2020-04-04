using System;
using System.Collections.Generic;
using RPGServer.Extensions;
using RPGServer.Models;

namespace RPGServer.Mocks
{
    public static class AventuraMock
    {
        public static List<Aventura> GetAventuras()
        {
            return new List<Aventura>() {
                new Aventura()
                {
                    Id = Guid.NewGuid(),
                    Descricao ="Um ex-aventureiro enigmático chamado Burga procura uma companhia de aventureiros para frustrar o plano monstruoso da Hag of the Dragon's Vale. Além disso, a parte deve completar a missão em 12 dias.",
                    Cidade = CidadeMock.GetCidades().PickRandom()
                },
                new Aventura()
                {
                    Id = Guid.NewGuid(),
                    Descricao =" Um padre chamado Arippos procura uma companhia de aventureiros para resgatar a vila de Gremoor de Fela, a Imperatriz Gárgula.",
                    Cidade = CidadeMock.GetCidades().PickRandom()
                },
                new Aventura()
                {
                    Id = Guid.NewGuid(),
                    Descricao =" Uma dama élfica chamada Alodel procura uma companhia de aventureiros para escoltar a Relíquia de Saraz em segurança até a vila de Baham. Além disso, o grupo deve completar a missão em meio a uma terrível praga.",
                    Cidade = CidadeMock.GetCidades().PickRandom()
                },
                new Aventura()
                {
                    Id = Guid.NewGuid(),
                    Descricao =" Uma nobre frenética chamada Mantie procura uma companhia de aventureiros para frustrar o plano monstruoso de Ariunis, o Conde das Sombras. Além disso, o grupo não pode usar magia arcana em sua missão.",
                    Cidade = CidadeMock.GetCidades().PickRandom()
                }
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalApi.Domain.ModelViews
{
    public struct Home
    {
        public string Mensagem {get => "Bem Vindo a APi de veiculos - Minimal API";}
        public string Doc {get => "/swagger";}
    }
}
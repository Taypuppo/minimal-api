using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalApi.Domain.DTOs
{
    public record VeiculoDTO
    {
        public string Nome { get; set; } = string.Empty;

        public string Marca { get; set; } = string.Empty;

        public int Ano { get; set; } = default;
    }
}
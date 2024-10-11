using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinimalApi.Domain.Entities;


namespace MinimalApi.Infraestrutura.Db
{
    public class DbContexto : DbContext
    {
        private readonly IConfiguration _configuracaoAppSettings;

        public DbContexto(IConfiguration configuracaoAppSettings)
        {
            _configuracaoAppSettings = configuracaoAppSettings;
        }

        public DbSet<Administrador> Administradores { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {

            if (optionBuilder.IsConfigured)
            {
                var stringConexao = _configuracaoAppSettings.GetConnectionString("sql")?.ToString();
                if (!string.IsNullOrEmpty(stringConexao))
                {
                    optionBuilder.UseSqlServer(stringConexao);
                }
            }
        }
    }
}
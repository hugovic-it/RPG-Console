using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rpg_console.Models;

namespace rpg_console.Context;

public class AppDbContext : DbContext
{
    public DbSet<Jogador>? Jogadores { get; set; }
    public DbSet<Inimigo>?  Inimigos { get; set; }
    public DbSet<EquipamentoArma>? Armas { get; set; }
    public DbSet<EquipamentoArmadura>? Armaduras { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=banco.db;Cache=Shared");
    }
}

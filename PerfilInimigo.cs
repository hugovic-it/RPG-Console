using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rpg_console.Context;
using rpg_console.Models;

namespace rpg_console
{
    public static class PerfilInimigo
    {
        public static Inimigo Perfil(AppDbContext contexto)
        {
            int id = 1;
            //System.Console.Write($"O perfil ativo do inimigo é {id}");
            Inimigo inimigo = contexto.Inimigos.First(x => x.InimigoId == id);
            return inimigo;
        }
    
    }
}
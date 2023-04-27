using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_console.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
   
        public override string ToString()
        {
            return $"Id:{ItemId} Nome{Nome} \n Descricao:{Descricao}";
        }
    }
}
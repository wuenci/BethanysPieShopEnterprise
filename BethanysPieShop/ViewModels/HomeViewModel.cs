using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.ViewModels
{
    public class HomeViewModel
    {
        public String Title { get; set; }
        public IEnumerable<Pie> Pies { get; set; }
    }
}

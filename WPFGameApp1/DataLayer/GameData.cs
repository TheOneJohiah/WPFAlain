using System;
using System.Collections.Generic;
using System.Text;
using WPFGameApp1.Models;

namespace WPFGameApp1.DataLayer
{
    class GameData
    {


        public static List<SpellComponent> SpellComponentList()
        {
            return new List<SpellComponent>()
            {
                new SpellComponent("Aspect", "The main aspect component", 1, 10, 20, 1, 10, 1, 0, 0, 0)
            };
        }
        
        
    }
}

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
                new SpellComponent("Aspect", "The main aspect component", 1, 10, 20, 1, 10, 1, 0, 0, 0),
                new SpellComponent("Touch", "Base medium", 0, 0, 0, 1, 0, 1, 0, 0, 0),
                new SpellComponent("Projectile", "Base ranged medium", 0, 0, 0, 1.2, 10, 1, 100, 0, 0),
                new SpellComponent("Beam", "Advanced ranged medium", 0, 0, 0, 1.8, 20, 1, 200, 0, 0),
                new SpellComponent("Wall", "Base radius medium", 0, 0, 0, 1.3, 30, 1, 10, 5, 0),
                new SpellComponent("AOE", "Advanced radius medium", 0, 0, 0, 1.2, 10, 1, 0, 5, 0),
                new SpellComponent("Field", "Advanced radius medium", 0, 0, 0, 2.5, 40, 1, 0, 20, 1),
                new SpellComponent("Multicast", "Extra component, spell cast twice", 0, 0, 0, 2.2, 0, 1.7, 0, 0, 0),
                new SpellComponent("Stabilize", "Extra component, reduces focus cost of spell", 0, 0, 0, 1.3, 0, 0.9, 0, 0, 0),
                new SpellComponent("Channel", "Extra component, maintains spell over multiple turns", 0, 0, 0, 1.5, 0, 1.5, 0, 0, 0),
                new SpellComponent("Concentrate", "Extra component, focuses spell improving piercing", 0, 0, 0, 1.1, 10, 1, 0, 0, 0)
            };
        }
        
        
    }
}

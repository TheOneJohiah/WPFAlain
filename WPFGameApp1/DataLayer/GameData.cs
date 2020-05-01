using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPFGameApp1.Models;

namespace WPFGameApp1.DataLayer
{
    class GameData
    {
        public static List<Player> LoadPlayerList()
        {
            List<Player> playerList = new List<Player>();
            String connectionString = null;
            connectionString = "Server=localhost;Database=alainDB";
            //SqlConnection cnn = new SqlConnection(connectionString);



            return playerList;
        }

        public static List<Spell> LoadSpellList()
        {
            return new List<Spell>()
            {

            };
        }

        public static List<SpellComponent> SpellComponentList()
        {
            return new List<SpellComponent>()
            {
                new SpellComponent("Aspect", "The main aspect component", 10, 20, 1, 10, 1, 0, 0, 0, false, false, false, false, false),
                new SpellComponent("Touch", "Base medium", 0, 0, 1, 0, 1, 0, 0, 0, false, false, false, false, false),
                new SpellComponent("Projectile", "Base ranged medium", 0, 0, 1.2, 10, 1, 100, 0, 0, false, false, false, false, false),
                new SpellComponent("Beam", "Advanced ranged medium", 0, 0, 1.8, 20, 1, 200, 0, 0, false, false, false, false, false),
                new SpellComponent("Wall", "Base radius medium", 0, 0, 1.3, 30, 1, 10, 5, 0, false, false, false, false, false),
                new SpellComponent("AOE", "Advanced radius medium", 0, 0, 1.2, 10, 1, 0, 5, 0, false, false, false, false, false),
                new SpellComponent("Field", "Advanced radius medium", 0, 0, 2.5, 40, 1, 0, 20, 1, false, false, false, false, false),
                new SpellComponent("Multicast", "Extra component, spell cast twice", 0, 0, 2.2, 0, 1.7, 0, 0, 0, true, false, false, false, false),
                new SpellComponent("Stabilize", "Extra component, reduces focus cost of spell", 0, 0, 1.3, 0, 0.9, 0, 0, 0, false, false, false, false, false),
                new SpellComponent("Channel", "Extra component, maintains spell over multiple turns", 0, 0, 1.5, 0, 1.5, 0, 0, 0, false, true, false, false, false),
                new SpellComponent("Concentrate", "Extra component, focuses spell improving piercing", 0, 0, 1.1, 10, 1, 0, 0, 0, false, false, true, false, false),
                new SpellComponent("Inverse", "Extra component, marks as protection shield or disruption field", 0, 0, 1, 5, 1, 0, 0, 0, false, false, false, true, false),
                new SpellComponent("Duration", "Extra component, increases spell duration", 0, 0, 1.3, 0, 1.3, 0, 0, 1, false, false, false, false, false),
                new SpellComponent("Scale", "Extra component, increases spell radius", 0, 0, 1.4, 0, 1.4, 0, 5, 0, false, false, false, false, false),
                new SpellComponent("Range", "Extra component, increases spell range", 0, 0, 1.2, 0, 1.1, 30, 0, 0, false, false, false, false, false),
                new SpellComponent("Homing", "Extra component, doubles chance to hit", 0, 0, 1.8, 0, 1.8, 0, 0, 0, false, false, false, false, true)
            };
        }
        
        
    }
}

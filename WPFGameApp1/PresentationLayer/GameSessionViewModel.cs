using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPFGameApp1.Models;

namespace WPFGameApp1.PresentationLayer
{
    public class GameSessionViewModel : ObservableObject
    {
        #region PROPERTIES
        private List<Player> _players;
        private List<Spell> _spells;
        private List<Item> _items;
        private List<SpellComponent> _spellComponents;

        public List<SpellComponent> SpellComponents
        {
            get { return _spellComponents; }
            set { _spellComponents = value; }
        }

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public List<Spell> Spells
        {
            get { return _spells; }
            set { _spells = value; }
        }

        public List<Player> Players
        {
            get { return _players; }
            set { _players = value; }
        }
        #endregion

        #region METHODS
        public SpellComponent FindComponentByName(string searchName, List<SpellComponent> spellComponents)
        {
            return spellComponents.FirstOrDefault(i => i.Name == searchName);
        }

        #endregion

        #region CONSTRUCTORS
        public GameSessionViewModel(List<Player> player, List<Spell> spells, List<Item> items, List<SpellComponent> spellComponents)
        {
            _players = player;
            _spells = spells;
            _items = items;
            _spellComponents = spellComponents;
        }

        #endregion
    }
}

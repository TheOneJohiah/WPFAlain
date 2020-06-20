using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGameApp1.Models
{
    public class Player
    {
		#region PROPERTIES
		private int _playerId;
		private string _name;
		private string _description;
		private int _athleticism;
		private int _toughness;
		private int _mentalFortitude;
		private int _memory;
		private int _intellect;
		private int _maxHealth;
		private int _currentHealth;
		private int _manaCapacity;
		private int _currentMana;
		private int _manaRegen;
		private int _spellCap;
		private int _maxFocus;
		private List<Spell> _learnedSpells;
		private List<Item> _inventory;

		public int PlayerId
		{
			get { return _playerId; }
			set { _playerId = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		public int Athleticism
		{
			get { return _athleticism; }
			set { _athleticism = value; }
		}

		public int Toughness
		{
			get { return _toughness; }
			set { _toughness = value; }
		}

		public int MentalFortitude
		{
			get { return _mentalFortitude; }
			set { _mentalFortitude = value; }
		}

		public int Memory
		{
			get { return _memory; }
			set { _memory = value; }
		}

		public int Intellect
		{
			get { return _intellect; }
			set { _intellect = value; }
		}

		public int MaxHealth
		{
			get { return _maxHealth; }
			set { _maxHealth = value; }
		}

		public int CurrentHealth
		{
			get { return _currentHealth; }
			set { _currentHealth = value; }
		}

		public int ManaCapacity
		{
			get { return _manaCapacity; }
			set { _manaCapacity = value; }
		}

		public int CurrentMana
		{
			get { return _currentMana; }
			set { _currentMana = value; }
		}

		public int ManaRegen
		{
			get { return _manaRegen; }
			set { _manaRegen = value; }
		}

		public int MaxFocusCap
		{
			get { return _spellCap; }
			set { _spellCap = value; }
		}

		public int MaxFocus
		{
			get { return _maxFocus; }
			set { _maxFocus = value; }
		}

		public List<Spell> LearnedSpells
		{
			get { return _learnedSpells; }
			set { _learnedSpells = value; }
		}

		public List<Item> Inventory
		{
			get { return _inventory; }
			set { _inventory = value; }
		}
		#endregion


		// TODO: Refactor this constructor and the spellmaker window to account for which player the spell is being made.
		#region CONSTRUCTORS
		public Player(int playerId, string name, string description, int athleticism, int toughness, int mentalFortitude, int memory, int intellect, List<Spell> learnedSpells, List<Item> inventory)
		{
			_playerId = playerId;
			_name = name;
			_description = description;
			_athleticism = athleticism;
			_toughness = toughness;
			_mentalFortitude = mentalFortitude;
			_memory = memory;
			_intellect = intellect;
			_learnedSpells = learnedSpells;
			_inventory = inventory;
		}
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GameCalculatorV1
{
    class Player
    {
		private int _athleticism;
		private int _toughness;
		private int _mentalFortitude;
		private int _knowledge;
		private int _intellect;
		private int _maxHealth;
		private int _currentHealth;
		private int _manaCapacity;
		private int _currentMana;
		private int _manaRegen;
		private int _spellCap;
		private int _maxFocus;

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

		public int Knowledge
		{
			get { return _knowledge; }
			set { _knowledge = value; }
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

	}
}

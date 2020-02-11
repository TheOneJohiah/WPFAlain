using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGameApp1.Models
{
    class SpellComponent
    {
        #region PROPERTIES
        private string _name;
		private string _description;
		private int _magnitude;
		private int _damage;
		private int _manaCost;
		private int _manaMult;
		private int _focusCost;
		private int _focusMult;
		private int _range;
		private int _radius;
		private int _duration;
		private bool _concentrate;
		private bool _inverse;
		private bool _homing;

		public bool Homing
		{
			get { return _homing; }
			set { _homing = value; }
		}


		public bool Inverse
		{
			get { return _inverse; }
			set { _inverse = value; }
		}


		public bool Concentrate
		{
			get { return _concentrate; }
			set { _concentrate = value; }
		}


		public int Duration
		{
			get { return _duration; }
			set { _duration = value; }
		}


		public int Radius
		{
			get { return _radius; }
			set { _radius = value; }
		}

		public int Range
		{
			get { return _range; }
			set { _range = value; }
		}

		public int FocusMult
		{
			get { return _focusMult; }
			set { _focusMult = value; }
		}

		public int FocusCost
		{
			get { return _focusCost; }
			set { _focusCost = value; }
		}

		public int ManaMult
		{
			get { return _manaMult; }
			set { _manaMult = value; }
		}

		public int ManaCost
		{
			get { return _manaCost; }
			set { _manaCost = value; }
		}

		public int Damage
		{
			get { return _damage; }
			set { _damage = value; }
		}

		public int Magnitude
		{
			get { return _magnitude; }
			set { _magnitude = value; }
		}

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
        #endregion

        #region CONSTRUCTORS
		public SpellComponent(string name, string description, int magnitude, int damage, int manaCost, int manaMult, int focusCost, int focusMult, int range, int radius, int duration, bool concentrate, bool inverse, bool homing)
		{
			_name = name;
			_description = description;
			_magnitude = magnitude;
			_damage = damage;
			_manaCost = manaCost;
			_manaMult = manaMult;
			_focusCost = focusCost;
			_focusMult = focusMult;
			_range = range;
			_range = radius;
			_duration = duration;
			_concentrate = concentrate;
			_inverse = inverse;
			_homing = homing;
		}
        #endregion

    }
}

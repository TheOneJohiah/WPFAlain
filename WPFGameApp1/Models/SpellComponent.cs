using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGameApp1.Models
{
    public class SpellComponent
    {
        #region PROPERTIES
        private string _name;
		private string _description;
		private int _magnitude;
		private double _damage;
		private double _manaCost;
		private double _manaMult;
		private double _focusCost;
		private double _focusMult;
		private int _range;
		private int _radius;
		private int _duration;
		private bool _isMulti;
		private bool _isChannel;
		private bool _isConcentrate;
		private bool _isInverse;
		private bool _isHoming;

		public bool IsHoming
		{
			get { return _isHoming; }
			set { _isHoming = value; }
		}

		public bool IsInverse
		{
			get { return _isInverse; }
			set { _isInverse = value; }
		}

		public bool IsConcentrate
		{
			get { return _isConcentrate; }
			set { _isConcentrate = value; }
		}

		public bool IsChannel
		{
			get { return _isChannel; }
			set { _isChannel = value; }
		}

		public bool IsMulti
		{
			get { return _isMulti; }
			set { _isMulti = value; }
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

		public double FocusMult
		{
			get { return _focusMult; }
			set { _focusMult = value; }
		}

		public double FocusCost
		{
			get { return _focusCost; }
			set { _focusCost = value; }
		}

		public double ManaMult
		{
			get { return _manaMult; }
			set { _manaMult = value; }
		}

		public double ManaCost
		{
			get { return _manaCost; }
			set { _manaCost = value; }
		}

		public double Damage
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
		public SpellComponent(string name, string description, int magnitude, double damage, double manaCost, double manaMult, double focusCost, double focusMult, int range, int radius, int duration, bool isMulti, bool isChannel, bool isConcentrate, bool isInverse, bool isHoming)
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
			_isMulti = isMulti;
			_isChannel = isChannel;
			_isConcentrate = isConcentrate;
			_isInverse = isInverse;
			_isHoming = isHoming;
		}
        #endregion

    }
}

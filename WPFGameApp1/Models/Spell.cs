using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGameApp1.Models
{
    public class Spell
    {
        #region PROPERTIES
        private string _name;
		private string _description;
		private string _aspect;
		private int _magnitude;
		private double _damage;
		private double _mana;
		private double _focus;
		private int _range;
		private int _radius;
		private int _duration;

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

		public double Focus
		{
			get { return _focus; }
			set { _focus = value; }
		}

		public double Mana
		{
			get { return _mana; }
			set { _mana = value; }
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

		public string Aspect
		{
			get { return _aspect; }
			set { _aspect = value; }
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
		public Spell(string name, string description, string aspect, int magnitude, double damage, double mana, double focus, int range, int radius, int duration)
		{
			_name = name;
			_description = description;
			_aspect = aspect;
			_magnitude = magnitude;
			_damage = damage;
			_mana = mana;
			_focus = focus;
			_range = range;
			_radius = radius;
			_duration = duration;
		}

        #endregion

    }
}

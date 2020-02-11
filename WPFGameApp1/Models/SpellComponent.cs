using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGameApp1.Models
{
    class SpellComponent
    {
		private string _name;
		private int _magnitude;
		private int _manaCost;
		private int _manaMult;
		private int _focusCost;
		private int _range;
		private int _radius;
		private int _duration;
		private int _concentrate;
		private int _inverse;
		private int _homing;

		public int Homing
		{
			get { return _homing; }
			set { _homing = value; }
		}


		public int Inverse
		{
			get { return _inverse; }
			set { _inverse = value; }
		}


		public int Concentrate
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
			get { return __radius; }
			set { __radius = value; }
		}

		public int Range
		{
			get { return _range; }
			set { _range = value; }
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

		public int Magnitude
		{
			get { return _magnitude; }
			set { _magnitude = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

	}
}

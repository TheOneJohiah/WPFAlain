using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGameApp1.Models.Items
{
    public class Weapon : Item
    {
        #region PROPERTIES
        private int _damage;

		public int Damage
		{
			get { return _damage; }
			set { _damage = value; }
		}

		#endregion

		public Weapon(int itemId, string name, string description, int value) : base(itemId, name, description, value)
		{

		}
	}
}

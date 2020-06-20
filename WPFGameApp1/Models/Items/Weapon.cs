using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGameApp1.Models.Items
{
    class Weapon : Item
    {
        #region PROPERTIES
        private int _damage;

		public int Damage
		{
			get { return _damage; }
			set { _damage = value; }
		}

		#endregion
	}
}

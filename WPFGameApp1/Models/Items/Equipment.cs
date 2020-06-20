using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGameApp1.Models.Items
{
    class Equipment : Item
    {
        #region PROPERTIES
        private int _armorHard;
        private double _armorSoft;

        public int ArmorHard
        {
            get { return _armorHard; }
            set { _armorHard = value; }
        }

        public double ArmorSoft
        {
            get { return _armorSoft; }
            set { _armorSoft = value; }
        }

        #endregion
    }
}

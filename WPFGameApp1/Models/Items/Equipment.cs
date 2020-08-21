using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGameApp1.Models.Items
{
    class Equipment : Item
    {
        #region FIELDS

        private int _armorHard;
        private double _armorSoft;

        #endregion


        #region PROPERTIES

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


        #region CONSTRUCTORS

        public Equipment()
        {

        }

        public Equipment(int itemId, string name, string description, int value) : base(itemId, name, description, value)
        {

        }

        #endregion
    }
}

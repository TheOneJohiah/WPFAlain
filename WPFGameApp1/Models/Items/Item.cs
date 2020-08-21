using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGameApp1.Models.Items
{
    public class Item
    {
        #region ENUMERABLES

        public enum Enchant
        {
            NONE,
            ACTIVE,
            PASSIVE
        }

        #endregion


        #region FIELDS

        private int _itemId;
        private string _name;
        private string _description;
        private int _value;

        #endregion


        #region PROPERTIES

        public int ItemID
        {
            get { return _itemId; }
            set { _itemId = value; }
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

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        #endregion


        #region CONSTRUCTORS

        public Item()
        {

        }

        public Item(int itemId, string name, string description, int value)
        {
            _itemId = itemId;
            _name = name;
            _description = description;
            _value = value;
        }

        #endregion
    }
}

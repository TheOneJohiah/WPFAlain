using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGameApp1.Models
{
    public class Item
    {
        #region PROPERTIES
        private int _itemId;
        private string _name;
        private string _description;
        private int _value;
        
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

        public Item()
        {

        }
    }
}

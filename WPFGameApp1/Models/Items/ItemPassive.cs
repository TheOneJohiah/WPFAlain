﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGameApp1.Models.Items
{
    class ItemPassive : Item
    {
        #region PROPERTIES
        private int _castsPerTurn;
        private int _manaCap;
        private double _manaRegen;
        private double _enchantProficiency;
        private Spell _boundSpell;

        public int CastsPerTurn
        {
            get { return _castsPerTurn; }
            set { _castsPerTurn = value; }
        }

        public int ManaCap
        {
            get { return _manaCap; }
            set { _manaCap = value; }
        }

        public double ManaRegen
        {
            get { return _manaRegen; }
            set { _manaRegen = value; }
        }

        public double EnchantProficiency
        {
            get { return _enchantProficiency; }
            set { _enchantProficiency = value; }
        }

        public Spell BoundSpell
        {
            get { return _boundSpell; }
            set { _boundSpell = value; }
        }

        #endregion

        public ItemPassive(int itemId, string name, string description, int value) : base(itemId, name, description, value)
        {

        }
    }
}

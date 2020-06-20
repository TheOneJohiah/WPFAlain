using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGameApp1.Models.Items
{
    public class ItemActive : Item
    {
		#region PROPERTIES
		private int _castsPerTurn;
		private double _focusMod;
		private double _enchantProficiency;
		private Spell _boundSpell;


		public int CastsPerTurn
		{
			get { return _castsPerTurn; }
			set { _castsPerTurn = value; }
		}

		public double FocusMod
		{
			get { return _focusMod; }
			set { _focusMod = value; }
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

		public ItemActive(int itemId, string name, string description, int value, int casts, double focusMod, double enchantProf, Spell boundSpell) : base(itemId, name, description, value)
		{
			_castsPerTurn = casts;
			_focusMod = focusMod;
			_enchantProficiency = enchantProf;
			_boundSpell = boundSpell;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFGameApp1.Models;

namespace WPFGameApp1.PresentationLayer
{
    /// <summary>
    /// Interaction logic for SpellMaker.xaml
    /// </summary>
    public partial class SpellMaker : Window
    {
        GameSessionViewModel _gameSessionViewModel;
        
        public SpellMaker(GameSessionViewModel gameSessionViewModel)
        {
            _gameSessionViewModel = gameSessionViewModel;

            InitializeComponent();
        }
        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Confirm_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.Spells.Add(NewSpell());

        }

        private Spell NewSpell()
        {
            SpellComponent placeHolder;
            double damage = 0;
            double mana = 0;
            double focus = 0;
            int range = 0;
            int radius = 0;
            int duration = 0;

            if (aspect.Text.Length != 0)
            {
                placeHolder = _gameSessionViewModel.FindComponentByName(aspect.Text, _gameSessionViewModel.SpellComponents);
                damage = placeHolder.Damage;
                mana = placeHolder.ManaCost;
                focus = placeHolder.FocusCost;

            }

            Spell spell = new Spell(name.Text, description.Text, aspect.Text, damage, mana, focus, range, radius, duration);
            return spell;
        }
    }
}

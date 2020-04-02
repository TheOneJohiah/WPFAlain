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
            int magnitude = 0;
            double damage = 0;
            double mana = 0;
            double focus = 0;
            int range = 0;
            int radius = 0;
            int duration = 0;

            if (aspectBox.Text.Length != 0)
            {
                placeHolder = _gameSessionViewModel.FindComponentByName("Aspect", _gameSessionViewModel.SpellComponents);
                int.TryParse(magnitudeBox.Text, out magnitude);
                damage = placeHolder.Damage;
                mana = placeHolder.ManaCost;
                focus = placeHolder.FocusCost;
                for (int i = 1; i < magnitude; i++)
                {
                    damage *= 2;
                    mana *= 2;
                    focus *= 2;
                }
                foreach (SpellComponent spellComponent in _gameSessionViewModel.SpellComponents)
                {
                    if (spellComponent.Name == firstMediumBox.Text || spellComponent.Name == secondMediumBox.Text || spellComponent.Name == firstComponentBox.Text || spellComponent.Name == secondComponentBox.Text || spellComponent.Name == thirdComponentBox.Text || spellComponent.Name == fourthComponentBox.Text || spellComponent.Name == fifthComponentBox.Text)
                    {
                        damage = damage + spellComponent.Damage;
                        mana = mana + spellComponent.ManaCost;
                        focus = focus + spellComponent.FocusCost;
                        range = range + spellComponent.Range;
                        radius = radius + spellComponent.Radius;
                        duration = duration + spellComponent.Duration;
                    }
                }
            }

            Spell spell = new Spell(nameBox.Text, descriptionBox.Text, aspectBox.Text, magnitude, damage, mana, focus, range, radius, duration);
            return spell;
        }
    }
}

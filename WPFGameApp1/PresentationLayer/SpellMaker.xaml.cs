﻿using System;
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
using WPFGameApp1.DataLayer;
using WPFGameApp1.Models;

namespace WPFGameApp1.PresentationLayer
{
    /// <summary>
    /// Interaction logic for SpellMaker.xaml
    /// </summary>
    public partial class SpellMaker : Window
    {
        //GameSessionViewModel _gameSessionViewModel;
        
        public SpellMaker()
        {
            InitializeComponent();
        }
        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Confirm_Click(object sender, RoutedEventArgs e)
        {
            GameData.SpellList.Add(NewSpell());
        }

        private Spell NewSpell()
        {
            Spell spell = new Spell(name.Text, description.Text, aspect.Text, 0, 0, 0, 0, 0, 0);
            return spell;
        }
    }
}

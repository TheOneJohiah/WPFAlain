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

namespace WPFGameApp1.PresentationLayer
{
    /// <summary>
    /// Interaction logic for GameSessionView.xaml
    /// </summary>
    public partial class GameSessionView : Window
    {
        GameSessionViewModel _gameSessionViewModel;

        public GameSessionView(GameSessionViewModel gameSessionViewModel)
        {
            InitializeComponent();
        }

        private void Button_Player_Click(object sender, RoutedEventArgs e)
        {
            PlayerMaker playerMaker = new PlayerMaker();
            playerMaker.ShowDialog();
        }

        private void Button_Monster_Click(object sender, RoutedEventArgs e)
        {
            MonsterMaker monsterMaker = new MonsterMaker();
            monsterMaker.ShowDialog();
        }

        private void Button_Spell_Click(object sender, RoutedEventArgs e)
        {
            SpellMaker spellMaker = new SpellMaker();
            spellMaker.ShowDialog();
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {
            InfoEditor infoEditor = new InfoEditor();
            infoEditor.ShowDialog();
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

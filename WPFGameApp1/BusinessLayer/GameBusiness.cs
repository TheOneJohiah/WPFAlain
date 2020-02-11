using System;
using System.Collections.Generic;
using System.Text;
using WPFGameApp1.PresentationLayer;
using WPFGameApp1.DataLayer;
using WPFGameApp1.Models;

namespace WPFGameApp1.BusinessLayer
{
    public class GameBusiness
    {
        GameSessionViewModel _gameSessionViewModel;
        List<SpellComponent> _spellComponentList = new List<SpellComponent>();

        public GameBusiness()
        {
            InitializeDataSet();
            InstantiateAndShowView();
        }

        private void InitializeDataSet()
        {
            _spellComponentList = GameData.SpellComponentList();
        }

        private void InstantiateAndShowView()
        {
            _gameSessionViewModel = new GameSessionViewModel();

            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();
        }
    }
}

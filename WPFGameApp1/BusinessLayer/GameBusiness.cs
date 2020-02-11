using System;
using System.Collections.Generic;
using System.Text;
using WPFGameApp1.PresentationLayer;
using WPFGameApp1.DataLayer;

namespace WPFGameApp1.BusinessLayer
{
    public class GameBusiness
    {
        GameSessionViewModel _gameSessionViewModel;

        public GameBusiness()
        {
            InstantiateAndShowView();
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

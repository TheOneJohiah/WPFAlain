using System;
using System.Collections.Generic;
using System.Text;
using WPFGameApp1.Models;

namespace WPFGameApp1.PresentationLayer
{
    public class GameSessionViewModel : ObservableObject
    {
        private List<Player> _player = new List<Player>;




        #region CONSTRUCTORS
        public GameSessionViewModel(List<Player> player)
        {
            _player = player;
        }

        #endregion
    }
}

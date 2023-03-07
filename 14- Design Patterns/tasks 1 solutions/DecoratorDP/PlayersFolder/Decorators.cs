using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.PlayersFolder
{
    public class ShadowStriker:Player 
    {
        private Player _player;
        public ShadowStriker(Player Player)
        {
            this._player = Player;
        }

        public override string Role
        {
            get { return _player.Role + ", Shadow striker"; }  
        }
        public override string Number 
        { 
            get { return _player.Number + ", 13"; }
        }
    }
    public class Libro : Player
    {
        private Player _player;
        public Libro(Player Player)
        {
            this._player = Player;
        }

        public override string Role
        {
            get { return _player.Role + ", libro"; }
        }
        public override string Number
        {
            get { return _player.Number + ", 2"; }
        }
    }
    public class PlayMaker : Player
    {
        private Player _player;
        public PlayMaker(Player Player)
        {
            this._player = Player;
        }

        public override string Role
        {
            get { return _player.Role + ", Playmaker"; }
        }
        public override string Number
        {
            get { return _player.Number + ", 10"; }
        }
    }
}

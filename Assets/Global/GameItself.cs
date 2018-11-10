using System.Runtime.InteropServices;
using Global.States;
using RookBirdTools.Patterns;

namespace Global
{
    public class GameItself:ScriptSingleton<GameItself>
    {
        private void Start()
        {
            var init = new InitializerTurn();
            init.Start();
        }
    }
}
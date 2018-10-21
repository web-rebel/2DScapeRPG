
using Engine.Models;

namespace Engine.ViewModels
{
    class GameSession
    {
        Player CurrentPlayer { get; set; }

        public GameSession()
        {
            /**
             * This is a test player object.  
             * The player will be loaded from disk or other in future
             */
            CurrentPlayer.Name = "Richard";
            CurrentPlayer.CharacterClass = "Wizard";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
            CurrentPlayer.Gold = 10;

        }
    }
}

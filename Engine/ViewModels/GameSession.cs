
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            /**
             * This is a test player object.  
             * The player will be loaded from disk or other in future
             */
            CurrentPlayer = new Player
            {
                Name = "Richard",
                CharacterClass = "Wizard",
                HitPoints = 10,
                ExperiencePoints = 10,
                Level = 1,
                Gold = 10
            };

        }
    }
}

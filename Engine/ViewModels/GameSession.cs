
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            /**
             * Player Object
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

            CurrentLocation = new Location
            {
                XCoordinate = 0,
                YCoordinate = -1,
                Name = "Home",
                Description = "This is your home.",
                ImageName = "/Engine;component/Images/Locations/Home.png"
            };
        }
    }
}

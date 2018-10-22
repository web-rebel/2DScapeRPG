
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public World CurrentWorld { get; set; }
        

        public GameSession()
        {
           
            CurrentPlayer = new Player
            {
                Name = "Richard",
                CharacterClass = "Wizard",
                HitPoints = 10,
                ExperiencePoints = 0,
                Level = 1,
                Gold = 10
            };

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0,0);
        }
    }
}

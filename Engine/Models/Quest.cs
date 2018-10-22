using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Quest
    {
        public int ID { get; set; }
        public int RewardGold { get; set; }
        public int RewardExperiencePoints { get; set; }
        public string Name { get; set; }
        public string Desription { get; set; }
        public List<ItemQuantity> ItemsToComplete { get; set; }
        public List<ItemQuantity> RewardItems { get; set; }

        public Quest(
            int id, int rewardGold, int rewardExperiencePoints, 
            string name, string description, 
            List<ItemQuantity> itemsToComplete, List<ItemQuantity> rewardItems)
        {
            ID = id;
            RewardGold = rewardGold;
            RewardExperiencePoints = rewardExperiencePoints;
            Name = name;
            Desription = description;
            ItemsToComplete = itemsToComplete;
            RewardItems = rewardItems;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imageName)
        {
            Location location = new Location
            {
                XCoordinate = xCoordinate,
                YCoordinate = yCoordinate,
                Name = name,
                Description = description,
                ImageName = imageName
            };

            _locations.Add(location); 
        }

        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location location in _locations)
            {
                if (location.XCoordinate == xCoordinate && location.YCoordinate == yCoordinate)
                {
                    return location;
                }
            }

            return null;
        }
    }
}

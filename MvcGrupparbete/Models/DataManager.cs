using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcGrupparbete.Models
{
    public static class DataManager
    {
        static List<Band> bandList = new List<Band>
        {
            new Band {Name = "Den Svenska Björnstammen", Description = "Svensk musikgrupp och konstnärskollektiv.", Album = "Ett fel närmare rätt, I förhållande till, Dansmusik EP." , Id = 1},
            new Band {Name = "Kent", Description = "Svenskt rockband från Eskilstuna.", Album = "Du & jag döden, Tigerdrottningen, Vapen & Ammunition.", Id = 2},
            new Band {Name = "Bo Kaspers Orkester", Description = "Svensk pop- och rockgrupp med starka influenser av jazz.", Album = "Söndag i sängen, På hotell, Kaos.", Id = 3}

        };

        public static Band GetBandById(int id)
        {
            return bandList
                .FirstOrDefault(b => b.Id == id);
        }

        public static Band[] GetAllBands()
        {
            return bandList
                .ToArray();
        }

        
    }
}

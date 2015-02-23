﻿using System.Collections.Generic;

using LeagueSharp.Common;

namespace Avoid
{
    public class ObjectDatabase
    {
        private static readonly List<AvoidObject> _avoidObjects = new List<AvoidObject>();
        public static List<AvoidObject> AvoidObjects
        {
            get { return new List<AvoidObject>(_avoidObjects); }
        }

        static ObjectDatabase()
        {
            foreach (var enemy in HeroManager.Enemies)
            {
                switch (enemy.ChampionName)
                {
                    case "Jinx":

                        // E
                        _avoidObjects.Add(new AvoidObject("Jinx - Flame Chompers! (E)", "Cupcake Trap", 75, "JinxEMine"));
                        break;

                    case "Teemo":

                        // R
                        _avoidObjects.Add(new AvoidObject("Teemo - Noxious Trap (R)", "Noxious Trap", 75, "Noxious Trap"));
                        break;

                    case "Ziggs":

                        // E
                        _avoidObjects.Add(new AvoidObject("Ziggs - Hexplosive Minefield (E)", "ZiggsE_red.troy", 50));
                        break;
                }
            }
        }
    }
}
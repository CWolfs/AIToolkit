﻿using System;
using System.Linq;

namespace AIToolkit.Selectors.Team
{
    public class Faction : Selector<AITeam>
    {
        public override bool Select(string selectString, AITeam team)
        {
            var factions = selectString.Split(' ');
            return factions.Contains(Enum.GetName(typeof(Faction), team.Faction));
        }
    }
}

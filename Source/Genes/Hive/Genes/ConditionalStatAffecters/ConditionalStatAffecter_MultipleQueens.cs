﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RimWorld;
using Verse;

namespace RJW_Genes
{

    /// <summary>
    /// Checks if there are multiple queens on the map.
    /// </summary>
    public class ConditionalStatAffecter_MultipleQueens : ConditionalStatAffecter
    {
        public override string Label => (string)"StatsReport_MultipleQueens".Translate();

        public override bool Applies(StatRequest req)
        {
            // => ModsConfig.BiotechActive && req.HasThing && req.Thing.Spawned && req.Thing.Position.InSunlight(req.Thing.Map);
            throw new NotImplementedException();
        } 
    }
}

﻿using System;

using CommunityCoreLibrary;
using RimWorld;
using Verse;

namespace CCLModTweaks
{
    
    public class QualifyLowPowerRareTickerRefrigerator : DefInjectionQualifier
    {

        public override bool DefIsUsable( Def def )
        {
            var thingDef = def as ThingDef;
            if( thingDef == null )
            {
                return false;
            }
            if( !thingDef.HasComp( typeof( CompRefrigerated ) ) )
            {
                return false;
            }
            if( !thingDef.HasComp( typeof( CompPowerTrader ) ) )
            {
                return false;
            }
            if( !thingDef.HasComp( typeof( CompPowerLowIdleDraw ) ) )
            {
                return false;
            }
            if( thingDef.tickerType != TickerType.Never )
            {
                return false;
            }
            return true;
       }

    }
}

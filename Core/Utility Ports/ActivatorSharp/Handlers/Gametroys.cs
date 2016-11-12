#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	Handlers/ObjectHandler.cs
// Date:		28/07/2016
// Author:		Robin Kurisu
#endregion

using System;
using System.Linq;
using Activator.Base;
using Activator.Data;
using LeagueSharp;
using LeagueSharp.Common;

using EloBuddy; 
 using LeagueSharp.Common; 
 namespace Activator.Handlers
{
    public class Gametroys
    {
        public static void StartOnUpdate()
        {
            Game.OnUpdate += Game_OnUpdate;
            GameObject.OnCreate += GameObject_OnCreate;
            GameObject.OnDelete += GameObject_OnDelete;
        }

        static void GameObject_OnDelete(GameObject obj, EventArgs args)
        {
            if (obj.IsValid<MissileClient>())
                return;

            foreach (var troy in Gametroy.Troys)
            {
                if (troy.Included && obj.Name.Contains(troy.Name))
                {
                    troy.Obj = null;
                    troy.Start = 0;
                    troy.Limiter = 0; // reset limiter
                    troy.Included = false;
                }
            }
        }

        static void GameObject_OnCreate(GameObject obj, EventArgs args)
        {
            if (obj.IsValid<MissileClient>())
                return;

            foreach (var troy in Gametroy.Troys)
            {
                if (obj.Name.Contains(troy.Name) && obj.IsValid<GameObject>())
                {                    
                    troy.Obj = obj;
                    troy.Start = Utils.GameTimeTickCount;

                    if (!troy.Included)
                         troy.Included = Helpers.IsEnemyInGame(troy.Owner);
                }
            }
        }

        static void Game_OnUpdate(EventArgs args)
        {
            foreach (var hero in Activator.Allies())
            {
                var troy = Gametroy.Troys.FirstOrDefault(x => x.Included);
                if (troy == null)
                {
                    continue;
                }

                if (!troy.Obj.IsVisible || !troy.Obj.IsValid)
                {
                    continue;
                }

                foreach (var entry in Troydata.Troys.Where(x => x.Name == troy.Name))
                {
                    var owner = Activator.Heroes.FirstOrDefault(x => x.Player.ChampionName == entry.ChampionName);
                    if (owner == null || !owner.Player.IsEnemy)
                    {
                        continue;
                    }

                    Gamedata data = null;

                    if (entry.ChampionName == null && entry.Slot == SpellSlot.Unknown)
                        data = new Gamedata();

                    if (entry.ChampionName != null && entry.Slot != SpellSlot.Unknown)
                        data = Gamedata.CachedSpells.Find(x => x.ChampionName.ToLower() == entry.ChampionName.ToLower());

                    if (hero.Player.Distance(troy.Obj.Position) <= entry.Radius + hero.Player.BoundingRadius)
                    {
                        // check delay (e.g fizz bait)
                        if (Utils.GameTimeTickCount - troy.Start >= entry.DelayFromStart)
                        {
                            if (hero.Player.IsValidTarget(float.MaxValue, false))
                            {
                                if (!hero.Player.IsZombie && !hero.Immunity)
                                {
                                    // limit the damage using an interval
                                    if (Utils.GameTimeTickCount - troy.Limiter >= entry.Interval * 1000)
                                    {
                                        Projections.PredictTheDamage(owner.Player, hero, data, HitType.Troy, "troy.OnUpdate");
                                        troy.Limiter = Utils.GameTimeTickCount;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
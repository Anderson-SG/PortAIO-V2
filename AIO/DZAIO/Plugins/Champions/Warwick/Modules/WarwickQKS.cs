using System;
using System.Linq;
using DZAIO_Reborn.Core;
using DZAIO_Reborn.Helpers;
using DZAIO_Reborn.Helpers.Modules;
using DZAIO_Reborn.Plugins.Champions.Kalista;
using LeagueSharp;
using LeagueSharp.Common;

using EloBuddy; 
 using LeagueSharp.Common; 
 namespace DZAIO_Reborn.Plugins.Champions.Warwick.Modules
{
    class WarwickQKS : IModule
    {
        public void OnLoad()
        {

        }

        public bool ShouldGetExecuted()
        {
            return Variables.AssemblyMenu.GetItemValue<bool>("dzaio.champion.warwick.extra.autoQKS") && Variables.Spells[SpellSlot.Q].IsReady();
        }

        public DZAIOEnums.ModuleType GetModuleType()
        {
            return DZAIOEnums.ModuleType.OnUpdate;
        }

        public void OnExecute()
        {
            var target = HeroManager.Enemies.FirstOrDefault(enemy => enemy.Health + 5 < Variables.Spells[SpellSlot.Q].GetDamage(enemy)
                && enemy.IsValidTarget(Variables.Spells[SpellSlot.Q].Range));

            if (target != null
                && (target.NetworkId != Variables.Orbwalker.GetTarget().NetworkId))
            {
                Variables.Spells[SpellSlot.Q].Cast(target);
            }
        }
    }
}

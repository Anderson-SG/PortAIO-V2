using EloBuddy; 
using LeagueSharp.Common; 
namespace ReformedAIO.Champions.Gragas.OrbwalkingMode.Combo
{
    using System;
    using System.Linq;

    using LeagueSharp;
    using LeagueSharp.Common;

    using ReformedAIO.Champions.Gragas.Core.Spells;

    using RethoughtLib.FeatureSystem.Implementations;

    using HitChance = SebbyLib.Prediction.HitChance;

    internal sealed class RQCombo : OrbwalkingChild
    {
        public override string Name { get; set; } = "Q & R";

        private readonly QSpell qSpell;

        private readonly RSpell rSpell;

        public RQCombo(QSpell qSpell, RSpell rSpell)
        {
            this.qSpell = qSpell;
            this.rSpell = rSpell;
        }

        private int Range => Menu.Item("Gragas.Combo.RQ.Range").GetValue<Slider>().Value;

        private AIHeroClient Target => TargetSelector.GetTarget(1000 - Range, TargetSelector.DamageType.Magical);

        private static AIHeroClient Ally
            =>  HeroManager.Allies.Where(x => x.IsAlly && !x.IsMe && !x.IsMinion)
                .FirstOrDefault(x => x.Distance(ObjectManager.Player) < 860);

        private static Obj_AI_Turret AllyTurret
            =>  ObjectManager.Get<Obj_AI_Turret>()
                .FirstOrDefault(x => x.Distance(ObjectManager.Player) < 860 && x.IsAlly && !x.IsDead);

        private void OnUpdate(EventArgs args)
        {
            if (!CheckGuardians() || Target == null)
            {
                return;
            }

            qSpell.ExplodeHandler(Target);

            if (qSpell.CanThrow() && qSpell.Spell.IsReady())
            {
                Combo();
            }

            if (rSpell.Spell.IsReady())
            {
                Insec();
            }
        }

        private void Combo()
        {
            switch (Menu.Item("Gragas.Combo.RQ.Hitchance").GetValue<StringList>().SelectedIndex)
            {
                case 0:
                    if (qSpell.OKTW(Target).Hitchance >= HitChance.High)
                    {
                        qSpell.Handle(qSpell.OKTW(Target).CastPosition);
                        qSpell.Spell.Cast(qSpell.OKTW(Target).CastPosition);
                    }
                    break;
                case 1:
                    if (qSpell.OKTW(Target).Hitchance >= HitChance.VeryHigh)
                    {
                        qSpell.Handle(qSpell.OKTW(Target).CastPosition);
                        qSpell.Spell.Cast(qSpell.OKTW(Target).CastPosition);
                    }
                    break;
            }
        }

        private void Insec()
        {
            if (Menu.Item("Gragas.Combo.RQ.Turret").GetValue<bool>() && AllyTurret != null)
            {
                rSpell.Spell.Cast(rSpell.OKTW(Target).CastPosition.Extend(AllyTurret.Position, Range));
            }

            // IT JUST LOOKS NESTED, IT'S REALLY NOT OKAY.
            else if (Menu.Item("Gragas.Combo.RQ.Q").GetValue<bool>())
            {
                var pred = rSpell.OKTW(Target).CastPosition;

                if (qSpell.CanThrow() && qSpell.Spell.IsReady())
                {
                    qSpell.Handle(Target.Position.Extend(pred, 140).Extend(ObjectManager.Player.Position, 600));

                    qSpell.Spell.Cast(Target.Position.Extend(pred, 140).Extend(ObjectManager.Player.Position, 600));
                }

                rSpell.Spell.Cast(Target.Position.Extend(pred, 140));
            }
            else if (Menu.Item("Gragas.Combo.RQ.Ally").GetValue<bool>() && Ally != null)
            {
                rSpell.Spell.Cast(rSpell.OKTW(Target).CastPosition.Extend(Ally.Position, Range));
            }
            else if (Menu.Item("Gragas.Combo.RQ.Gragas").GetValue<bool>())
            {
                var pred = rSpell.OKTW(Target).CastPosition;

                rSpell.Spell.Cast(Target.Position.Extend(pred, 140));
            }
        }

        protected override void OnDisable(object sender, FeatureBaseEventArgs eventArgs)
        {
            base.OnDisable(sender, eventArgs);

            Game.OnUpdate -= OnUpdate;
        }

        protected override void OnEnable(object sender, FeatureBaseEventArgs eventArgs)
        {
            base.OnEnable(sender, eventArgs);

            Game.OnUpdate += OnUpdate;
        }

        protected override void OnLoad(object sender, FeatureBaseEventArgs eventArgs)
        {
            base.OnLoad(sender, eventArgs);

            Menu.AddItem(new MenuItem("Gragas.Combo.RQ.Hitchance", "Hitchance:").SetValue(new StringList(new[] { "High", "Very High" })));

            Menu.AddItem(new MenuItem("Gragas.Combo.RQ.Range", "Range Behind Target").SetValue(new Slider(300, 140, 350)));

            Menu.AddItem(new MenuItem("Gragas.Combo.RQ.Q", "Insec To: Q Barrel").SetValue(true));

            Menu.AddItem(new MenuItem("Gragas.Combo.RQ.Turret", "Insec To: Turret").SetValue(true));

            Menu.AddItem(new MenuItem("Gragas.Combo.RQ.Ally", "Insec To: Ally").SetValue(true));

            Menu.AddItem(new MenuItem("Gragas.Combo.RQ.Gragas", "Insec To: Gragas").SetValue(false));
        }
    }
}

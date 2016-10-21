using EloBuddy; namespace ElUtilitySuite.Items.DefensiveItems
{
    using System;
    using System.Linq;

    using ElUtilitySuite.Vendor.SFX;

    using LeagueSharp;
    using LeagueSharp.Common;

    internal class FaceOfTheMountain : Item
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Loads this instance.
        /// </summary>
        public FaceOfTheMountain()
        {
            IncomingDamageManager.RemoveDelay = 500;
            IncomingDamageManager.Skillshots = true;
            Face_of_the_moutain = new EloBuddy.SDK.Item(ItemId.Face_of_the_Mountain);
            Game.OnUpdate += this.Game_OnUpdate;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>
        ///     The identifier.
        /// </value>
        public override ItemId Id => ItemId.Face_of_the_Mountain;

        /// <summary>
        ///     Gets or sets the name of the item.
        /// </summary>
        /// <value>
        ///     The name of the item.
        /// </value>
        public override string Name => "Face of the Mountain";

        public static EloBuddy.SDK.Item Face_of_the_moutain;

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Creates the menu.
        /// </summary>
        public override void CreateMenu()
        {
            this.Menu.AddItem(new MenuItem("UseFaceCombo", "Activate").SetValue(true));
            this.Menu.AddItem(new MenuItem("Mode-face", "Activation mode: "))
                .SetValue(new StringList(new[] { "Use always", "Use in combo" }, 1));
            this.Menu.AddItem(new MenuItem("face-min-health", "Use on Hp %").SetValue(new Slider(50)));
            this.Menu.AddItem(new MenuItem("face-min-damage", "Incoming damage percentage").SetValue(new Slider(50, 1)));

            this.Menu.AddItem(new MenuItem("blank-line", ""));
            foreach (var x in ObjectManager.Get<AIHeroClient>().Where(x => x.IsAlly))
            {
                this.Menu.AddItem(new MenuItem("Faceon" + x.ChampionName, "Use for " + x.ChampionName)).SetValue(true);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Called when the game updates
        /// </summary>
        /// <param name="args">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Game_OnUpdate(EventArgs args)
        {
            try
            {
                if (!Face_of_the_moutain.IsOwned() || !Face_of_the_moutain.IsReady() || !this.Menu.Item("UseFaceCombo").IsActive())
                {
                    return;
                }

                if (this.Menu.Item("Mode-face").GetValue<StringList>().SelectedIndex == 1 && !this.ComboModeActive)
                {
                    return;
                }

                foreach (var ally in EloBuddy.SDK.EntityManager.Heroes.Allies.Where(a => a.IsValidTarget(850f, false) && !a.IsDead && !a.IsRecalling()))
                {
                    if (!this.Menu.Item(string.Format("Faceon{0}", ally.ChampionName)).IsActive())
                    {
                        return;
                    }

                    var enemies = ally.CountEnemiesInRange(800);
                    var totalDamage = IncomingDamageManager.GetDamage(ally) * 1.1f;

                    if (ally.HealthPercent <= this.Menu.Item("face-min-health").GetValue<Slider>().Value && enemies >= 1)
                    {
                        if ((int)(totalDamage / ally.Health)
                            > this.Menu.Item("face-min-damage").GetValue<Slider>().Value
                            || ally.HealthPercent < this.Menu.Item("face-min-health").GetValue<Slider>().Value)
                        {
                            Face_of_the_moutain.Cast(ally);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[ELUTILITYSUITE - FACE OF THE MOUNTAIN] Used for: {0} - health percentage: {1}%", ally.ChampionName, (int)ally.HealthPercent);
                        }
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(@"An error occurred: '{0}'", e);
            }
        }

        #endregion
    }
}
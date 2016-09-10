﻿using EloBuddy;
using LeagueSharp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortAIO.Dual_Port
{
    class Misc
    {
        public static Menu menu;

        public static void Load()
        {
            (menu = new Menu("PortAIO Misc", "PAIOMisc", true)).AddToMainMenu();

            var dualPort = new Menu("Dual-Port", "DualPAIOPort");
            menu.AddSubMenu(dualPort);

            var hasDualPort = true;

            string[] champ = new string[] { };
            switch (ObjectManager.Player.Hero)
            {
                case Champion.Aatrox:
                    champ = new string[] { "BrianSharp", "KappaSeries", "SAutoCarry", "NoobAatrox" };
                    break;
                case Champion.Ahri:
                    champ = new string[] { "OKTW", "DZAhri", "EloFactory Ahri", "KappaSeries", "xSalice", "BadaoSeries", "DZAIO", "M1D 0R F33D", "AhriSharp", "[SDK] Flowers' Series" };
                    break;
                case Champion.Akali:
                    champ = new string[] { "xQx Akali", "Kappa Series", "Korean Akali", "Trookali", "xSalice", "StonedSeriesAIO", "M1D 0R F33D", "[SDK] ExorAIO", "[SDK] Flowers' Akali", "[SDK] Flowers' Series", "[SDK] TroopAIO" };
                    break;
                case Champion.Alistar:
                    champ = new string[] { "ElAlistar", "Support Is Easy", "FreshBooster", "vSeries" };
                    break;
                case Champion.Amumu:
                    champ = new string[] { "Amumu#", "BrianSharp", "StonedSeriesAIO", "ShineAIO", "[SDK] ExorAIO" };
                    break;
                case Champion.Anivia:
                    champ = new string[] { "OKTW", "Anivia#", "xSalice", "[SDK] ExorAIO" };
                    break;
                case Champion.Annie:
                    champ = new string[] { "OKTW", "Korean Annie", "SharpyAIO", "Support is Easy" };
                    break;
                case Champion.Ashe:
                    champ = new string[] { "OKTW", "ProSeries", "ReformedAIO", "SharpShooter", "SurvivorSeries", "xSalice", "Marksman#", "[SDK] The Queen of the Ice", "[SDK] ChallengerSeriesAIO", "[SDK] Dicaste's Ashe", "[SDK] ExorAIO", "[SDK] Flowers' Series", "[SDK] xcsoft's Ashe" };
                    break;
                case Champion.AurelionSol:
                    champ = new string[] { "ElAurelionSol", "SkyLv_Aurelion", "vAurelionSol" };
                    break;
                case Champion.Azir:
                    champ = new string[] { "HeavenStrike Azir", "Creator of Elo", "SAutoCarry", "xSalice" };
                    break;
                case Champion.Bard:
                    champ = new string[] { "DZBard", "DZAIO", "FreshBooster", "xBard", "[SDK] ChallengerSeriesAIO" };
                    break;
                case Champion.Blitzcrank:
                    champ = new string[] { "OKTW", "FreshBooster", "KurisuBlitz", "SAutoCarry", "SharpShooter", "ShineAIO", "Support is Easy", "vSeries", "[SDK] Flowers' Series", "[SDK] xcsoft's Blitzcrank" };
                    break;
                case Champion.Brand:
                    champ = new string[] { "The Brand", "Hikicarry Brand", "OKTW", "Survivor Series", "yol0 Brand" };
                    break;
                case Champion.Braum:
                    champ = new string[] { "OKTW", "FreshBooster", "Support is Easy" };
                    break;
                case Champion.Caitlyn:
                    champ = new string[] { "OKTW", "SharpShooter", "Marksman#", "[SDK] ChallengerSeriesAIO", "[SDK] ExorAIO" };
                    break;
                case Champion.Cassiopeia:
                    champ = new string[] { "SAutoCarry", "SFXChallenger", "SharpyAIO", "xSalice", "TheCassiopeia", "[SDK] ExorAIO" };
                    break;
                case Champion.Chogath:
                    champ = new string[] { "UnderratedAIO", "Windwalker Cho'Gath", "xSalice" };
                    break;
                case Champion.Corki:
                    champ = new string[] { "El Corki", "ADCPackage", "D-Corki", "hikiMarksman", "OKTW", "ProSeries", "SAutoCarry", "SharpShooter", "xSalice", "Marksman#", "[SDK] ExorAIO" };
                    break;
                case Champion.Darius:
                    champ = new string[] { "OKTW", "ElEasy", "SAutoCarry", "[SDK] ExorAIO", "[SDK] Flowers' Series" };
                    break;
                case Champion.Diana:
                    champ = new string[] { "ElDiana", "D-Diana", "ReformedAIO", "[SDK] ExorAIO" };
                    break;
                case Champion.DrMundo:
                    champ = new string[] { "Hestia's Mundo", "BrianSharp", "KappaSeries", "SAutoCarry", "SharpyAIO", "StonedSeriesAIO", "[SDK] ExorAIO", "[SDK] Valvrave#" };
                    break;
                case Champion.Draven:
                    champ = new string[] { "OKTW", "hikiMarksman", "SharpShooter", "Marksman#", "M00N Draven", "[SDK] ExorAIO", "[SDK] Tyler1.exe" };
                    break;
                case Champion.Ekko:
                    champ = new string[] { "OKTW", "EloFactory Ekko", "xSalice" };
                    break;
                case Champion.Elise:
                    champ = new string[] { "GFUEL Elise", "D-Elise", "EliseGod", "Hikigaya Elise" };
                    break;
                case Champion.Evelynn:
                    champ = new string[] { "Evelynn#", "OKTW", "UnderratedAIO", "[SDK] ExorAIO", "[SDK] TroopAIO" };
                    break;
                case Champion.Ezreal:
                    champ = new string[] { "OKTW", "ADCPackage", "D-Ezreal", "DZAIO", "hikiMarksman", "iSeriesReborn", "ProSeries", "SFXChallenger", "SharpShooter", "ShineAIO", "UnderratedAIO", "xSalice", "Marksman#", "[SDK] ChallengerSeriesAIO", "[SDK] DarkChild's Ezreal", "[SDK] ExorAIO", "[SDK] Flowers' Series" };
                    break;
                case Champion.FiddleSticks:
                    champ = new string[] { "Feedlesticks", "Support is Easy", "vSeries" };
                    break;
                case Champion.Fiora:
                    champ = new string[] { "Project Fiora", "UnderratedAIO", "xSalice" };
                    break;
                case Champion.Fizz:
                    champ = new string[] { "Math Fizz", "ElFizz", "UnderratedAIO" };
                    break;
                case Champion.Galio:
                    champ = new string[] { "UnderratedAIO", "Desomond Galio", "Galio#" };
                    break;
                case Champion.Gangplank:
                    champ = new string[] { "UnderratedAIO", "Badao Gangplank", "Bangplank", "BePlank", "e.Motion Gangplank" };
                    break;
                case Champion.Garen:
                    champ = new string[] { "UnderratedAIO", "TheGaren", "TroopGaren", "yol0 Garen" };
                    break;
                case Champion.Gnar:
                    champ = new string[] { "Hellsing's Gnar", "SluttyGnar", "Marksman#" };
                    break;
                case Champion.Gragas:
                    champ = new string[] { "The Drunk Carry", "ReformedAIO", "UnderratedAIO" };
                    break;
                case Champion.Graves:
                    champ = new string[] { "OKTW", "D-Graves", "hikiMarksman", "Kurisu Graves", "SFXChallenger", "SharpShooter", "Marksman#", "[SDK] ExorAIO", "[SDK] Flowers' Series", "[SDK] VSTGraves" };
                    break;
                case Champion.Hecarim:
                    champ = new string[] { "JustHecarim", "SharpyAIO", "UnderratedAIO", "[SDK] [SBTW] Hecarim", "[SDK] Flowers' Series" };
                    break;
                case Champion.Heimerdinger:
                    champ = new string[] { "2Girls1Donger", "TheDonger" };
                    break;
                case Champion.Illaoi:
                    champ = new string[] { "Tentacle Kitty", "SharpShooter", "[SDK] Flowers' Series", "[SDK] Kraken Priestess" };
                    break;
                case Champion.Irelia:
                    champ = new string[] { "Irelia II", "Irelia to the Challenger", "xSalice", "[SDK] ChallengerSeriesAIO" };
                    break;
                case Champion.Janna:
                    champ = new string[] { "LCS Janna", "FreshBooster", "Support is Easy", "vSeries" };
                    break;
                case Champion.JarvanIV:
                    champ = new string[] { "BrianSharp", "D-Jarvan", "StonedSeries AIO" };
                    break;
                case Champion.Jax:
                    champ = new string[] { "xQx Jax", "BrianSharp", "NoobJaxReloaded", "SAutoCarry", "UnderratedAIO", "[SDK] ExorAIO" };
                    break;
                case Champion.Jayce:
                    champ = new string[] { "OKTW", "Hikicarry Jayce", "xSalice" };
                    break;
                case Champion.Jhin:
                    champ = new string[] { "OKTW", "Hikigaya's Jhin", "SAutoCarry", "Marksman#", "[SDK] ExorAIO", "[SDK] hJhin" };
                    break;
                case Champion.Jinx:
                    champ = new string[] { "OKTW", "ADCPackage", "GENESIS Jinx", "iSeriesReborn", "ProSeries", "SharpShooter", "xSalice", "Marksman#", "[SDK] ExorAIO" };
                    break;
                case Champion.Kalista:
                    champ = new string[] { "S+ Class Kalista", "DZAIO", "HERMES Kalista", "Hikicarry Kalista", "iSeriesReborn", "OKTW", "SAutoCarry", "SFXChallenger", "SharpShooter", "Marksman#", "[SDK] ChallengerSeriesAIO", "[SDK] ExorAIO", "[SDK] xcsoft's Kalista" };
                    break;
                case Champion.Karma:
                    champ = new string[] { "Kortatu's Karma", "KarmaXD", "Support is Easy", "vSeries", "[SDK] Karma Never Falter", "[SDK] ExorAIO", "[SDK] Flowers' Series", "[SDK] SpiritKarma" };
                    break;
                case Champion.Karthus:
                    champ = new string[] { "OKTW", "SharpShooter", "xSalice", "[SDK] RAREKarthus" };
                    break;
                case Champion.Kassadin:
                    champ = new string[] { "PainInMyKass", "SharpyAIO", "Slutty Kassadin", "[SDK] PreservedKassadin" };
                    break;
                case Champion.Katarina:
                    champ = new string[] { "Staberina", "ElEasy", "ElSmartKatarina", "xSalice", "e.Motion Katarina" };
                    break;
                case Champion.Kayle:
                    champ = new string[] { "SephKayle", "BrianSharp", "D-Kayle", "OKTW", "[SDK] ChallengerSeriesAIO" };
                    break;
                case Champion.Kennen:
                    champ = new string[] { "UnderratedAIO", "BrianSharp", "Hestia's Kennen", "[SDK] Valvrave#" };
                    break;
                case Champion.Khazix:
                    champ = new string[] { "Seph Kha'Zix", "KhaZix#" };
                    break;
                case Champion.Kindred:
                    champ = new string[] { "Yin & Yang", "OKTW", "SharpShooter", "Marksman#" };
                    break;
                // Kled - HikiKled
                case Champion.KogMaw:
                    champ = new string[] { "OKTW", "D-Kog'Maw", "iSeriesReborn", "ProSeries", "SFXChallenger", "SharpShooter", "xSalice", "Marksman#", "[SDK] ChallengerSeriesAIO", "[SDK] ExorAIO" };
                    break;
                case Champion.Leblanc:
                    champ = new string[] { "Leblanc II", "FreshBooster", "LCS Leblanc", "M1D 0R F33D" };
                    break;
                case Champion.LeeSin:
                    champ = new string[] { "ElLeeSin", "BrianSharp", "FreshBooster", "Hikicarry LeeSin", "Lee is Back", "Slutty LeeSin", "[SDK] Valvrave#" };
                    break;
                case Champion.Leona:
                    champ = new string[] { "ElEasy", "Support is Easy", "vSeries" };
                    break;
                case Champion.Lissandra:
                    champ = new string[] { "SephLissandra", "xSalice" };
                    break;
                case Champion.Lucian:
                    champ = new string[] { "LCS Lucian", "BrianSharp", "hikiMarksman", "Hoola Lucian", "iLucian", "iSeriesReborn", "KoreanLucian", "OKTW", "SAutoCarry", "SharpShooter", "xSalice", "Marksman#", "[SDK] ChallengerSeriesAIO", "[SDK] ExorAIO" };
                    break;
                case Champion.Lulu:
                    champ = new string[] { "Lululicious", "HeavenStrikeLulu", "SharpShooter", "Support is Easy" };
                    break;
                case Champion.Lux:
                    champ = new string[] { "OKTW", "vSeries", "M1D 0R F33D", "M00N Lux", "[SDK] ExorAIO" };
                    break;
                case Champion.Malphite:
                    champ = new string[] { "ElEasy", "JustMalphite", "SephMalphite" };
                    break;
                case Champion.Malzahar:
                    champ = new string[] { "OKTW", "SurvivorSeries", "M1D 0R F33D" };
                    break;
                case Champion.Maokai:
                    champ = new string[] { "UnderratedAIO", "BrianSharp" };
                    break;
                case Champion.MasterYi:
                    champ = new string[] { "MasterSharp", "Hoola Yi", "SAutoCarry" };
                    break;
                case Champion.MissFortune:
                    champ = new string[] { "OKTW", "Alex's MissFortune", "D-MissFortune", "SAutoCarry", "SFXChallenger", "SharpShooter", "Marksman#", "[SDK] ExorAIO" };
                    break;
                case Champion.Mordekaiser:
                    champ = new string[] { "xQx Mordekaiser", "UnderratedAIO" };
                    break;
                case Champion.Morgana:
                    champ = new string[] { "Kurisu Morgana", "FreshBooster", "OKTW", "ShineAIO", "Support is Easy", "vSeries", "[SDK] Flowers' Series" };
                    break;
                case Champion.Nami:
                    champ = new string[] { "ElNami", "FreshBooster", "Support is Easy", "vSeries" };
                    break;
                case Champion.Nasus:
                    champ = new string[] { "ElEasy", "BrianSharp", "UnderratedAIO" };
                    break;
                case Champion.Nautilus:
                    champ = new string[] { "Nautilus - Danz", "PlebNautilus", "vSeries", "[SDK] ExorAIO" };
                    break;
                case Champion.Nidalee:
                    champ = new string[] { "KurisuNidalee", "HeavenStrikeNidalee", "NechritoNidalee", "D-Nidalee", "Flowers' Nidalee" };
                    break;
                case Champion.Nocturne:
                    champ = new string[] { "UnderratedAIO", "xQx Nocturne", "[SDK] ExorAIO" };
                    break;
                case Champion.Nunu:
                    champ = new string[] { "Nunu by Alqohol", "Support Is Easy", "[SDK] ExorAIO" };
                    break;
                case Champion.Olaf:
                    champ = new string[] { "Olaf is Back II", "UnderratedAIO", "[SDK] ExorAIO" };
                    break;
                case Champion.Orianna:
                    champ = new string[] { "Kortatu Orianna", "DZAIO", "OKTW", "SAutoCarry", "SFXChallenger", "xSalice", "[SDK] ExorAIO" };
                    break;
                case Champion.Pantheon:
                    champ = new string[] { "xQx Pantheon", "SAutoCarry", "[SDK] ExorAIO" };
                    break;
                case Champion.Poppy:
                    champ = new string[] { "UnderratedAIO", "FreshBooster", "vSeries" };
                    break;
                case Champion.Quinn:
                    champ = new string[] { "OKTW", "GFUEL Quinn", "Marksman#", "[SDK] ExorAIO" };
                    break;
                case Champion.Rammus:
                    champ = new string[] { "BrianSharp", "Rammus is OK" };
                    break;
                case Champion.RekSai:
                    champ = new string[] { "D-Reksai", "HeavenStrike Rek'Sai", "Rek'Sai Winner of Fights" };
                    break;
                case Champion.Renekton:
                    champ = new string[] { "UnderratedAIO", "SharpyAIO", "[SDK] ExorAIO" };
                    break;
                case Champion.Rengar:
                    champ = new string[] { "ElRengar", "D-Rengar", "SAutoCarry", "[SDK] Pridestalker Rengar" };
                    break;
                case Champion.Riven:
                    champ = new string[] { "KurisuRiven", "Hoola Riven", "SAutoCarry", "Nechrito Riven", "[SDK] Flowers' Series", "[SDK] ReforgedRiven" };
                    break;
                case Champion.Rumble:
                    champ = new string[] { "UnderratedAIO", "xSalice" };
                    break;
                case Champion.Ryze:
                    champ = new string[] { "Survivor Ryze", "BrianSharp", "FreshBooster", "ReformedAIO", "Sharpshooter", "StonedSeries AIO", "[SDK] ArcaneRyze", "[SDK] EvictRyze", "[SDK] ExorAIO", "[SDK] Flowers' Series" };
                    break;
                case Champion.Sejuani:
                    champ = new string[] { "ElSejuani", "UnderratedAIO" };
                    break;
                case Champion.Shaco:
                    champ = new string[] { "UnderratedAIO", "Ch3wyM00N Shaco" };
                    break;
                case Champion.Shen:
                    champ = new string[] { "UnderratedAIO", "BrianSharp", "Kimbaeng Shen" };
                    break;
                case Champion.Shyvana:
                    champ = new string[] { "D-Shyvana", "HeavenStrike Shyvana", "JustShyvana", "SAutoCarry" };
                    break;
                case Champion.Singed:
                    champ = new string[] { "UnderratedAIO", "ElSinged" };
                    break;
                case Champion.Sion:
                    champ = new string[] { "UnderratedAIO", "SimpleSion" };
                    break;
                case Champion.Sivir:
                    champ = new string[] { "OKTW", "DZAIO", "hikiMarksman", "ProSeries", "SFXChallenger", "SharpShooter", "ShineAIO", "Marksman#", "[SDK] ExorAIO", "[SDK] Flowers' Series", "[SDK] xcsoft's Sivir" };
                    break;
                case Champion.Skarner:
                    champ = new string[] { "UnderratedAIO", "kSkarner", "SneakySkarner" };
                    break;
                case Champion.Sona:
                    champ = new string[] { "ElEasy", "Royal Song of Sona", "Support is Easy", "Vodka Sona", "vSeries", "[SDK] ExorAIO" };
                    break;
                case Champion.Soraka:
                    champ = new string[] { "SephSoraka", "FreshBooster", "Heal-Bot", "MLG Soraka", "Support is Easy", "vSeries", "[SDK] ChallengerSeriesAIO" };
                    break;
                case Champion.Swain:
                    champ = new string[] { "OKTW", "SluttySwain", "The Mocking Swain" };
                    break;
                case Champion.Syndra:
                    champ = new string[] { "Syndra by Kortatu", "BadaoSeries", "ElEasy", "Hikigaya Syndra", "OKTW", "Syndra by L33T", "vSeries", "xSalice" };
                    break;
                case Champion.TahmKench:
                    champ = new string[] { "UnderratedAIO", "FreshBooster", "STahmKench", "vSeries" };
                    break;
                case Champion.Taliyah:
                    champ = new string[] { "Toph#", "[SDK] ExorAIO", "[SDK] StoneWeaver" };
                    break;
                case Champion.Talon:
                    champ = new string[] { "GFUEL Talon", "Hoola Talon" };
                    break;
                case Champion.Taric:
                    champ = new string[] { "SkyLv_Taric", "ElEasy", "PippyTaric", "Support is Easy", "vSeries" };
                    break;
                case Champion.Teemo:
                    champ = new string[] { "PandaTeemo", "SharpShooter", "Marksman#", "[SDK] ChallengerSeriesAIO", "[SDK] SwiftlyTeemo" };
                    break;
                case Champion.Thresh:
                    champ = new string[] { "Chain Warden", "FreshBooster", "OKTW", "Support is Easy", "vSeries", "Dark Star Thresh" };
                    break;
                case Champion.Tristana:
                    champ = new string[] { "ElTristana", "ADCPackage", "D-Tristana", "iSeriesReborn", "OKTW", "PewPewTristana", "ProSeries", "SharpShooter", "Marksman#", "[SDK] ExorAIO", "[SDK] Flowers' Series" };
                    break;
                case Champion.Trundle:
                    champ = new string[] { "ElTrundle", "DZAIO", "UnderratedAIO", "vSeries", "[SDK] xD Trundle" };
                    break;
                case Champion.Tryndamere:
                    champ = new string[] { "BrianSharp", "The Lich King", "UnderratedAIO", "[SDK] ExorAIO" };
                    break;
                case Champion.TwistedFate:
                    champ = new string[] { "TwistedFate by Kortatu", "SharpShooter", "BadaoSeries", "EloFactory TF", "OKTW", "SAutoCarry", "SFXChallenger", "Twisted Fate - Danz", "[SDK] Flowers' Series", "[SDK] RARETwistedFate" };
                    break;
                case Champion.Twitch:
                    champ = new string[] { "OKTW", "iSeriesReborn", "iTwitch 2.0", "SAutoCarry", "SharpShooter", "Marksman#", "[SDK] ExorAIO", "[SDK] Flowers' Series", "[SDK] InfectedTwitch" };
                    break;
                case Champion.Udyr:
                    champ = new string[] { "BrianSharp", "D-Udyr", "EloFactory Udyr", "LCS Udyr", "UnderratedAIO", "[SDK] ExorAIO" };
                    break;
                case Champion.Urgot:
                    champ = new string[] { "OKTW", "xSalice", "Marksman#", "[SDK] Discaste's Urgot", "[SDK] TroopAIO" };
                    break;
                case Champion.Varus:
                    champ = new string[] { "ElVarus", "OKTW", "SFXChallenger", "SharpShooter", "Marksman#" };
                    break;
                case Champion.Vayne:
                    champ = new string[] { "VayneHunterReborn", "hikiMarksman", "iSeriesReborn", "OKTW", "SAutoCarry", "SharpShooter", "xSalice", "Marksman#", "hi im gosu", "[SDK] ChallengerSeriesAIO", "[SDK] ExorAIO", "[SDK] Flowers' Series", "[SDK] hVayne" };
                    break;
                case Champion.Veigar:
                    champ = new string[] { "UnderratedAIO", "DZAIO", "FreshBooster", "SAutoCarry", "[SDK] ExorAIO" };
                    break;
                case Champion.Velkoz:
                    champ = new string[] { "Vel'Koz by Kortatu", "OKTW" };
                    break;
                case Champion.Vi:
                    champ = new string[] { "ElVi", "xQx Vi" };
                    break;
                case Champion.Viktor:
                    champ = new string[] { "TRUSt in my Viktor", "Hikicarry Viktor", "Perplexed Viktor", "SAutoCarry", "SFXChallenger", "Badao's Viktor", "xSalice", "[SDK] Flowers' Series", "[SDK] Flowers' Viktor" };
                    break;
                case Champion.Vladimir:
                    champ = new string[] { "ElVladimir", "DZAIO", "SFXChallenger", "xSalice", "[SDK] The Rivers will Run Red", "[SDK] Flowers' Series", "[SDK] TroopAIO", "[SDK] Valvrave#" };
                    break;
                case Champion.Volibear:
                    champ = new string[] { "UnderratedAIO", "KappaSeries", "NoobVolibear", "StonedSeries AIO" };
                    break;
                case Champion.Warwick:
                    champ = new string[] { "The Blood Hunter", "BrianSharp", "D-Warwick", "DZAIO", "[SDK] ExorAIO" };
                    break;
                case Champion.MonkeyKing:
                    champ = new string[] { "UnderratedAIO", "2Girls1Monkey", "Hoola Wukong", "JustWukong", "mztikk's Wukong", "xQx Wukong" };
                    break;
                case Champion.Xerath:
                    champ = new string[] { "Kortatu's Xerath", "OKTW", "SluttyXerath", "M1D 0R F33D", "[SDK] ChallengerSeriesAIO" };
                    break;
                case Champion.XinZhao:
                    champ = new string[] { "xQx XinZhao", "BrianSharp", "XinZhao God" };
                    break;
                case Champion.Yasuo:
                    champ = new string[] { "YasuoPro", "BrianSharp", "GosuMechanics", "YasuoSharpv2", "[Yasuo] Master of Wind", "M1D 0R F33D", "YasuoMemeBender", "Media's Yasuo", "[SDK] Valvrave#" };
                    break;
                case Champion.Yorick:
                    champ = new string[] { "UnderratedAIO", "The Staffer" };
                    break;
                case Champion.Zac:
                    champ = new string[] { "UnderratedAIO", "The Secret Flubber" };
                    break;
                case Champion.Zed:
                    champ = new string[] { "Korean Zed", "SharpyAIO", "[SDK] Valvrave#" };
                    break;
                case Champion.Ziggs:
                    champ = new string[] { "Ziggs#", "Royal Ziggy" };
                    break;
                case Champion.Zilean:
                    champ = new string[] { "ElZilean", "Support is Easy" };
                    break;
                case Champion.Zyra:
                    champ = new string[] { "D-Zyra", "Support is Easy", "xSalice", "[SDK] RAREZyra" };
                    break;
                default:
                    hasDualPort = false;
                    dualPort.AddItem(new MenuItem("info1", "There are no dual-port for this champion."));
                    dualPort.AddItem(new MenuItem("info2", "Feel free to request one."));
                    break;
            }

            if (hasDualPort)
            {
                dualPort.AddItem(new MenuItem(ObjectManager.Player.Hero.ToString(), "Which dual-port?").SetValue(new StringList(champ)));
            }

            var autoPlay = new Menu("Auto Play", "PortAIOAUTOPLAY");
            autoPlay.AddItem(new MenuItem("AutoPlay", "Enable AutoPlay?").SetValue(false));
            autoPlay.AddItem(new MenuItem("selectAutoPlay", "Which AutoPlay?").SetValue(new StringList(new[] { "AramDETFull", "AutoJungle" })));
            menu.AddSubMenu(autoPlay);

            var utility = new Menu("Utilities", "Utilitiesports");
            utility.AddItem(new MenuItem("enableActivator", "Enable Activator?").SetValue(false));
            utility.AddItem(new MenuItem("Activator", "Which Activator?").SetValue(new StringList(new[] { "ElUtilitySuite", "Activator#" })));

            utility.AddItem(new MenuItem("enableTracker", "Enable Tracker?").SetValue(false));
            utility.AddItem(new MenuItem("Tracker", "Which Tracker?").SetValue(new StringList(new[] { "SFXUtility", "ShadowTracker" })));

            utility.AddItem(new MenuItem("enableEvade", "Enable Evade?").SetValue(false));
            utility.AddItem(new MenuItem("Evade", "Which Evade?").SetValue(new StringList(new[] { "EzEvade", "Evade" })));

            utility.AddItem(new MenuItem("enableHuman", "Enable Humanizer?").SetValue(false));
            utility.AddItem(new MenuItem("Humanizer", "Which Humanizer?").SetValue(new StringList(new[] { "Humanizer#", "Sebby Ban Wars" })));
            menu.AddSubMenu(utility);

            menu.AddItem(new MenuItem("UtilityOnly", "Utility Only?").SetValue(false));
            menu.AddItem(new MenuItem("ChampsOnly", "Champs Only?").SetValue(false));
        }
    }
}

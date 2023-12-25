﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.simulation
{
    internal class SimulationResult
    {
        public ArmySide Winner { get; set; } = ArmySide.None;
        public double ConfidenceLevel { get; set; } = 0.0;

        public int TotalBattles { get; set; } = 0;
        public int AllyWins { get; set;  } = 0;
        public int EnemyWins { get; set; } = 0;

        public double AllyWinsConfidence { get; set; } = 0.0;
        public double EnemyWinsConfidence { get; set; } = 0.0;

        public int AllyLuck { get; set; } = 0;
        public int AllyBestLuck { get; set; } = 0;
        public int EnemyLuck { get; set; } = 0;
        public int EnemyBestLuck { get; set; } = 0;

        public int TotalBestRoll { get; set; } = 0;
        public int TotalRoolsCount { get; set; } = 0;

        public int AllyBestRoll { get; set; } = 0;
        public int EnemyBestRoll { get; set; } = 0;

        public int AllyRoolsCount { get; set; } = 0;
        public int EnemyRoolsCount { get; set; } = 0;

        public int AllyTotalAmount { get; set; } = 0;
        public int AllyAverageLooses { get; set; } = 0;
        public int AllyWorstLooses { get; set; } = 0;

        public int EnemyTotalAmount { get; set; } = 0;
        public int EnemyAverageLooses { get; set; } = 0;
        public int EnemyWorstLooses { get; set; } = 0;

        public Dictionary<string, string> AllyStats { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> EnemyStats { get; set; } = new Dictionary<string, string>();

        public void Clear() 
        {
            AllyStats.Clear();
            EnemyStats.Clear();

            Winner = ArmySide.None;
            ConfidenceLevel = 0.0;

            TotalBattles = 0;
            AllyWins = 0;
            EnemyWins = 0;

            AllyWinsConfidence = 0.0;
            EnemyWinsConfidence = 0.0;

            AllyLuck = 0;
            AllyBestLuck = 0;
            EnemyLuck = 0;
            EnemyBestLuck = 0;

            TotalBestRoll = 0;
            TotalRoolsCount = 0;

            AllyBestRoll = 0;
            EnemyBestRoll = 0;

            AllyRoolsCount = 0;
            EnemyRoolsCount = 0;

            AllyAverageLooses = 0;
            AllyWorstLooses = 0;
            EnemyAverageLooses = 0;
            EnemyWorstLooses = 0;

            AllyTotalAmount = 0;
            EnemyTotalAmount = 0;
        }

        public void CalculateStats(List<BattleResult> results) 
        {
            this.Clear();

            //Get wins ratio
            this.TotalBattles = results.Count;
            this.AllyWins = results.Where(r => r.Winner == ArmySide.Ally).Count();
            this.EnemyWins = results.Where(r => r.Winner == ArmySide.Enemy).Count();

            //Get luck
            this.AllyLuck = (int)results.Select(r => r.LuckAlly).Average();
            this.AllyBestLuck = results.Select(r => r.LuckAlly).Max();

            this.EnemyLuck = (int)results.Select(r => r.LuckEnemy).Average();
            this.EnemyBestLuck = results.Select(r => r.LuckEnemy).Max();

            //Set winner
            this.Winner = this.AllyWins > this.EnemyWins ? ArmySide.Ally : ArmySide.Enemy;
            if ( this.AllyWins == this.EnemyWins )
            {
                this.Winner = this.AllyLuck > this.EnemyLuck ? ArmySide.Ally : ArmySide.Enemy;
            }

            //Get confidence level
            this.ConfidenceLevel = this.Winner == ArmySide.Ally ? (double)this.AllyWins/this.TotalBattles : (double)this.EnemyWins / this.TotalBattles;
            this.ConfidenceLevel *= 100;

            this.AllyWinsConfidence = results.Where(r => r.Winner == ArmySide.Ally).Select(r => r.ConfidenceLevel).Average() * 100;
            this.EnemyWinsConfidence = results.Where(r => r.Winner == ArmySide.Enemy).Select(r => r.ConfidenceLevel).Average() * 100;

            //Get rools stats
            if( results.Select(d => d.Rools.Count).Sum() != 0 ) 
            {
                this.AllyBestRoll = results.Select(d => d.Rools).Where(d => d.Keys.All(a => a.ArmySide == ArmySide.Ally)).SelectMany(dict => dict.Values).Max();
                this.AllyRoolsCount = results.Select(d => d.Rools).Where(d => d.Keys.All(a => a.ArmySide == ArmySide.Ally)).SelectMany(dict => dict.Values).Count();

                this.EnemyBestRoll = results.Select(d => d.Rools).Where(d => d.Keys.All(a => a.ArmySide == ArmySide.Enemy)).SelectMany(dict => dict.Values).Max();
                this.EnemyRoolsCount = results.Select(d => d.Rools).Where(d => d.Keys.All(a => a.ArmySide == ArmySide.Enemy)).SelectMany(dict => dict.Values).Count();

                this.TotalBestRoll = this.AllyBestRoll > this.EnemyBestRoll ? this.AllyBestRoll : this.EnemyBestRoll;
                this.TotalRoolsCount = this.AllyRoolsCount + this.EnemyRoolsCount;
            }

            //Get looses
            if ( results.Select(d => d.Losses.Count).Sum() != 0 ) 
            {
                this.AllyTotalAmount = (int)results.Select(r => r.TotalAmountAlly).Average();
                double averageLoosesAlly = results.Select(d => d.Losses).Where(d => d.Keys.All(a => a.ArmySide == ArmySide.Ally)).Select(dict => dict.Values.Sum()).Average();
                this.AllyAverageLooses = (int)averageLoosesAlly;
                this.AllyWorstLooses = results.Select(d => d.Losses).Where(d => d.Keys.All(a => a.ArmySide == ArmySide.Enemy)).Select(dict => dict.Values.Sum()).Max();

                this.EnemyTotalAmount = (int)results.Select(r => r.TotalAmountEnemy).Average();
                double averageLoosesEnemy = results.Select(d => d.Losses).Where(d => d.Keys.All(a => a.ArmySide == ArmySide.Enemy)).Select(dict => dict.Values.Sum()).Average();
                this.EnemyAverageLooses = (int)averageLoosesEnemy;
                this.AllyWorstLooses = results.Select(d => d.Losses).Where(d => d.Keys.All(a => a.ArmySide == ArmySide.Ally)).Select(dict => dict.Values.Sum()).Max();
            }
        }

        public void FillStats() 
        {
            //Ally
            AllyStats.Add("Is Winner?", $"{this.Winner == ArmySide.Ally}");
            AllyStats.Add("Wins", $"{this.AllyWins} / {this.TotalBattles}");
            AllyStats.Add("Average wins confidence (%)", $"{this.AllyWinsConfidence:F2}");
            AllyStats.Add("Average loss confidence (%)", $"{(100.0 - this.AllyWinsConfidence):F2}");
            AllyStats.Add("Average Luck", $"{this.AllyLuck}");
            AllyStats.Add("Best Luck", $"{this.AllyBestLuck}");
            AllyStats.Add("Best roll", $"{this.AllyBestRoll}");
            AllyStats.Add("Rolls count", $"{this.AllyRoolsCount}");
            AllyStats.Add("Average losses", $"{this.AllyAverageLooses} / {this.AllyTotalAmount}");
            AllyStats.Add("Worst losses", $"{this.AllyWorstLooses} / {this.AllyTotalAmount}");

            //Enemy
            EnemyStats.Add("Is Winner?", $"{this.Winner == ArmySide.Enemy}");
            EnemyStats.Add("Wins", $"{this.EnemyWins} / {this.TotalBattles}");
            EnemyStats.Add("Average wins confidence (%)", $"{this.EnemyWinsConfidence:F2}");
            EnemyStats.Add("Average loss confidence (%)", $"{(100.0 - this.EnemyWinsConfidence):F2}");
            EnemyStats.Add("Average Luck", $"{this.EnemyLuck}");
            EnemyStats.Add("Best Luck", $"{this.EnemyBestLuck}");
            EnemyStats.Add("Best roll", $"{this.EnemyBestRoll}");
            EnemyStats.Add("Rolls count", $"{this.EnemyRoolsCount}");
            EnemyStats.Add("Average losses", $"{this.EnemyAverageLooses} / {this.EnemyTotalAmount}");
            EnemyStats.Add("Worst losses", $"{this.EnemyWorstLooses} / {this.EnemyTotalAmount}");
        }
    }
}
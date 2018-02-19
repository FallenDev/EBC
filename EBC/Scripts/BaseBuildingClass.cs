using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBC
{
    public class BaseBuildingClass
    {
        // Player Name
        private string _name;

        // Main Buildings
        private int _level;
        private float _armor;
        private float _townHall;
        private float _sanctum;
        private float _heroHall;
        private float _goldVault;
        private float _goldMine;

        // Variable Buildings
        private float _alchemy;
        private float _ancientRelic;
        private float _bastion;

        // Defenses
        private float _reaper;
        private float _sniperTower;
        private float _magicTower;
        private float _airDefense;
        private float _ermahGuard;
        private float _mortar;
        private float _cannon;
        private float _victoryStatue;
       
        // Side Buildings -- Low HP
        private int _forgingBlock = 7500;
        private int _builderShack = 815;
        private int _arena = 7500;

        public string Name { get; set; }
        public int Level { get; set; }
        public float Armor { get; set; }
        public float TownHall { get; set; }
        public float Sanctum { get; set; }
        public float HeroHall { get; set; }
        public float GoldVault { get; set; }
        public float GoldMine { get; set; } 
        public float Alchemy { get; set; }
        public float AncientRelic { get; set; }
        public float Bastion { get; set; }
        public float Reaper { get; set; }
        public float SniperTower { get; set; }
        public float MagicTower { get; set; }
        public float AirDefense { get; set; }
        public float ErmahGuard { get; set; }
        public float Mortar { get; set; }
        public float Cannon { get; set; }
        public float VictoryStatue { get; set; }
        public int ForgingBlock { get; set; }
        public int BuilderShack { get; set; }
        public int Arena { get; set; }
    }
}

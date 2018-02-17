using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBC
{
    public class StatueModifierClass
    {
        // Statues that affect HP
        private float _guardianStatue = .25f;
        private float _battleRoyaleStatue;
        private float _arenaStatue;

        // Other Modifiers
        private float _continentRankStatue;
        private float _heroTrialsStatue;

        public float GuardianStatue { get; set; }
        public float BattleRoyaleStatue { get; set; }
        public float ArenaStatue { get; set; }
        public float ContinentRankStatue { get; set; }
        public float HeroTrialsStatue { get; set; }
    }
}

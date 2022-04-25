using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Agent.Player
{
    internal class PlayerAttack : AgentAttack
    {
        public override Creature ThisAgent { get; set; }
        public override int BaseAttackHitpoints { get; set; }
        public override int BaseAttackSpeed { get; set; }
        public override int CurrentAttackHitpoints { get; set; }
        public override int CurrentAttackSpeed { get; set; }

        public PlayerAttack(Creature player, int baseAttackHitpoints, int baseAttackSpeed)
        {
            ThisAgent = player;
            BaseAttackHitpoints = baseAttackHitpoints;
            BaseAttackSpeed = baseAttackSpeed;
            CurrentAttackHitpoints = baseAttackHitpoints;
            CurrentAttackSpeed = baseAttackSpeed;
        }

        public PlayerAttack(Creature player, int baseAttackHitpoints, int baseAttackSpeed, int currentAttackHitpoints, int currentAttackSpeed)
        {
            ThisAgent = player;
            BaseAttackHitpoints = baseAttackHitpoints;
            BaseAttackSpeed = baseAttackSpeed;
            CurrentAttackHitpoints = currentAttackHitpoints;
            CurrentAttackSpeed = currentAttackSpeed;
        }
    }
}

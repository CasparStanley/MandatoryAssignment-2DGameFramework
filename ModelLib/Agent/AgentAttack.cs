using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Agent
{
    public abstract class AgentAttack
    {
        public abstract Creature ThisAgent { get; set; }
        public abstract int BaseAttackHitpoints { get; set; }
        public abstract int BaseAttackSpeed { get; set; }
        public abstract int CurrentAttackHitpoints { get; set; }
        public abstract int CurrentAttackSpeed { get; set; }

        public virtual void OnAttack()
        {
            foreach (Creature target in World.Creatures)
            {
                if ((Vector2.Distance(target.Position, ThisAgent.Position) < ThisAgent.InteractionDistance))
                {
                    if ((Vector2.Distance(target.Position, ThisAgent.Position) < ThisAgent.InteractionDistance))
                    {
                        if (ThisAgent.WeaponEquiped != null)
                        {
                            target.GetHit(ThisAgent.WeaponEquiped.Damage);
                        }
                        else
                        {
                            target.GetHit(BaseAttackHitpoints);
                        }
                    }
                }
            }
        }
    }
}

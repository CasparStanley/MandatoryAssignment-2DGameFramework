using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Agent
{
    public class AgentAttack
    {
        public virtual int BaseAttackHitpoints { get; set; }
        public virtual int BaseAttackSpeed { get; set; }

        public virtual void OnAttack(Creature target, Item_Attack weapon = null)
        {
            if (weapon != null)
            {
                target.GetHit(weapon.Damage);
            }
            else
            {
                target.GetHit(BaseAttackHitpoints);
            }
        }
    }
}

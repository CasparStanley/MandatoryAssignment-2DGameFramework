using ModelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class Creature : GameObject, IHittable
    {
        public int Health { get; set; }

        private int MaxHealth;

        public Creature(Vector2 position, string name) : base(position, name)
        {
            Health = MaxHealth;
        }

        public void UpdatePosition(Vector2 newPosition)
        {
            throw new NotImplementedException();
        }

        public void GetHit(int damage, GameObject damageDealer)
        {
            throw new NotImplementedException();
        }

    }
}

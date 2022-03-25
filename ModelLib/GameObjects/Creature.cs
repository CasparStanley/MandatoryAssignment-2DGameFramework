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

        private int _maxHealth;
        private bool dead = false;

        public Creature() { }

        public Creature(int maxHealth, string name) : base(name)
        {
            Health = _maxHealth = maxHealth;
        }

        public Creature(int maxHealth, string name, Vector2 position) : base(name, position)
        {
            Health = _maxHealth = maxHealth;
        }

        public void GetHit(int damage, GameObject damageDealer)
        {
            Debug.Log("Player got hit");

            if (!dead)
            {
                Health -= damage;
                OnGetHit();
                if (Health <= 0)
                {
                    Debug.Log("Player diead");

                    OnDie();
                    dead = true;

                    World.Destroy(this, 0.25f);
                }
            }
        }

        public void Heal(int addedHealth)
        {
            Health += addedHealth;
            if (Health > _maxHealth) { Health = _maxHealth; }
        }

        private void OnGetHit()
        {

        }

        private void OnDie()
        {

        }
    }
}

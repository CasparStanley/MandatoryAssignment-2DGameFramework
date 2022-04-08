using ModelLib.Agent;
using ModelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public abstract class Creature : GameObject, IHittable
    {
        public abstract AgentAttack Attack { get; set; }

        public Item HoldingItem { get; set; }
        public Item_Attack WeaponEquiped { get; set; }
        public List<Item_Defence> ArmorEquiped { get; set; } = new List<Item_Defence>();

        public int Health { get; set; }

        private int _maxHealth;
        private bool dead = false;

        public Creature() 
        {
            OnCreate();
        }

        public Creature(int maxHealth, string name) : base(name)
        {
            Health = _maxHealth = maxHealth;
            OnCreate();
        }

        public Creature(int maxHealth, string name, Vector2 position) : base(name, position)
        {
            Health = _maxHealth = maxHealth;
            OnCreate();
        }

        public Creature(int maxHealth, string name, Vector2 position, char shape) : base(name, position, shape)
        {
            Health = _maxHealth = maxHealth;
            OnCreate();
        }

        public void GetHit(int damage)
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

        public abstract void DoMove(char dir);

        public virtual void OnCreate()
        {
            World.Creatures.Add(this);
        }

        public virtual void Heal(int addedHealth)
        {
            Health += addedHealth;
            if (Health > _maxHealth) { Health = _maxHealth; }
        }

        public virtual void PickUpItem(Item item)
        {
            if (item is Item)
            {
                DropItem(HoldingItem);
                HoldingItem = item;
            }
            else if (item is Item_Attack)
            {
                DropItem(WeaponEquiped);
                WeaponEquiped = (Item_Attack)item;
            }
            else if (item is Item_Defence)
            {
                ArmorEquiped.Add((Item_Defence)item);
            }

            item.SetActive(false);
        }

        public virtual void DropItem(Item item)
        {
            // Drop the item below the creature
            item.UpdatePosition(Position + Vector2.down);
            item.SetActive(true);
        }

        private void OnGetHit()
        {

        }

        private void OnDie()
        {

        }
    }
}

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
        // HACK: DESIGN PATTERN - TEMPLATE

        public abstract AgentAttack Attack { get; set; }

        public Item HoldingItem { get; set; }
        public Item_Attack WeaponEquiped { get; set; }
        public List<Item_Defence> ArmorEquiped { get; set; } = new List<Item_Defence>();
        public int InteractionDistance { get; set; }

        public int Health { get; set; }

        private int _maxHealth;
        private bool dead = false;

        public Creature() 
        {
            OnCreateCreature();
        }

        public Creature(int maxHealth, int interactionDist, string name) : base(name)
        {
            Health = _maxHealth = maxHealth;
            InteractionDistance = interactionDist;
            OnCreateCreature();
        }

        public Creature(int maxHealth, int interactionDist, string name, Vector2 position) : base(name, position)
        {
            Health = _maxHealth = maxHealth;
            InteractionDistance = interactionDist;
            OnCreateCreature();
        }

        public Creature(int maxHealth, int interactionDist, string name, Vector2 position, char shape) : base(name, position, shape)
        {
            Health = _maxHealth = maxHealth;
            InteractionDistance = interactionDist;
            OnCreateCreature();
        }

        // Would be better to use damage class instead of int
        public virtual void GetHit(int damage)
        {
            Debug.Log($"Creature got hit for {damage} health points");

            if (!dead)
            {
                Health -= damage;
                if (Health <= 0)
                {
                    Debug.Log("Creature died");

                    dead = true;

                    World.Destroy(this, 0.25f);
                }
            }
        }

        public abstract void DoMove(string dir);

        public virtual void OnCreateCreature()
        {
            World.Creatures.Add(this);
        }

        public virtual void Heal(int addedHealth)
        {
            Health += addedHealth;
            if (Health > _maxHealth) { Health = _maxHealth; }
        }

        // TODO: DESIGN PATTERN - POTENTIAL USE OF DECORATOR - To have a separate class to "decorate" the creature. Also good for SOLID/Loose coupling.
        public virtual void PickUpItem()
        {
            foreach (GameObject item in World.GetObjects())
            {
                if ((Vector2.Distance(item.Position, Position) < InteractionDistance))
                {
                    if (item is Item_Attack)
                    {
                        item.SetActive(false);

                        DropItem(WeaponEquiped);
                        WeaponEquiped = (Item_Attack)item;
                        Attack.CurrentAttackHitpoints = WeaponEquiped.Damage;
                        Debug.Log("Equipped attack item");
                    }
                    else if (item is Item_Defence)
                    {
                        item.SetActive(false);

                        ArmorEquiped.Add((Item_Defence)item);
                        Debug.Log("Equipped defence item");
                    }
                    else if(item is Item)
                    {
                        item.SetActive(false);

                        DropItem(HoldingItem);
                        HoldingItem = (Item)item;
                        Debug.Log("Picked up item");
                    }
                }
            }
        }

        public virtual void DropItem(Item item)
        {
            if (item != null)
            {
                // Drop the item below the creature
                item.UpdatePosition(Position + Vector2.down);
                item.SetActive(true);
            }
        }

        public override string ToString()
        {
            return $"{nameof(Name)}={Name}: {nameof(Attack)}={Attack}, {nameof(HoldingItem)}={HoldingItem}, {nameof(WeaponEquiped)}={WeaponEquiped}, {nameof(ArmorEquiped)}={ArmorEquiped}, {nameof(InteractionDistance)}={InteractionDistance.ToString()}, {nameof(Health)}={Health.ToString()}, {nameof(Id)}={Id.ToString()}, {nameof(Position)}={Position.ToString()}, {nameof(Active)}={Active.ToString()}, {nameof(Shape)}={Shape.ToString()}";
        }

        public override bool Equals(object obj)
        {
            return obj is Creature creature &&
                   base.Equals(obj) &&
                   Id == creature.Id &&
                   Name == creature.Name &&
                   Position.Equals(creature.Position) &&
                   Active == creature.Active &&
                   Shape == creature.Shape &&
                   EqualityComparer<AgentAttack>.Default.Equals(Attack, creature.Attack) &&
                   EqualityComparer<Item>.Default.Equals(HoldingItem, creature.HoldingItem) &&
                   EqualityComparer<Item_Attack>.Default.Equals(WeaponEquiped, creature.WeaponEquiped) &&
                   EqualityComparer<List<Item_Defence>>.Default.Equals(ArmorEquiped, creature.ArmorEquiped) &&
                   InteractionDistance == creature.InteractionDistance &&
                   Health == creature.Health &&
                   _maxHealth == creature._maxHealth &&
                   dead == creature.dead;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(base.GetHashCode());
            hash.Add(Id);
            hash.Add(Name);
            hash.Add(Position);
            hash.Add(Active);
            hash.Add(Shape);
            hash.Add(Attack);
            hash.Add(HoldingItem);
            hash.Add(WeaponEquiped);
            hash.Add(ArmorEquiped);
            hash.Add(InteractionDistance);
            hash.Add(Health);
            hash.Add(_maxHealth);
            hash.Add(dead);
            return hash.ToHashCode();
        }
    }
}

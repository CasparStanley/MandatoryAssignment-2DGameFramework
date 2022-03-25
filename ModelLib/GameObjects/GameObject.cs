using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLib
{
    public enum G
    {
        GameObject,
        Item,
        Creature
    }
    public class GameObject
    {
        public int Id { get; }
        public string Name { get; set; }
        public Vector2 Position { get; set; }
        public bool Active { get; set; } = true;

        public GameObject() 
        {
            Name = "";
            Position = Vector2.zero;

            Id = World.NextGameObjectId;
            OnCreate();
        }

        public GameObject(string name)
        {
            Name = name;
            Position = Vector2.zero;

            Id = World.NextGameObjectId;
            OnCreate();
        }

        public GameObject(string name, Vector2 position)
        {
            Name = name;
            Position = position;

            Id = World.NextGameObjectId;
            OnCreate();
        }

        private void OnCreate()
        {
            World.Objects.Add(Id, this);
        }

        public void SetActive(bool state)
        {
            Active = state;
        }

        public virtual void UpdatePosition(Vector2 newPosition)
        {
            Position = newPosition;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Position)}={Position.ToString()}, {nameof(Active)}={Active.ToString()}}}";
        }
    }
}

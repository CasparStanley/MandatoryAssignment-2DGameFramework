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
        // HACK: SOLID - Open-Closed princible - GameObject is open for extension, but closed for modification (Item as example)

        public int Id { get; }
        public string Name { get; set; }
        public Vector2 Position { get; set; }
        public bool Active { get; set; } = true;
        public char Shape { get; set; } = '\u00D7';

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

        public GameObject(string name, Vector2 position, char shape)
        {
            Name = name;
            Position = position;
            Shape = shape;

            Id = World.NextGameObjectId;
            OnCreate();
        }

        public virtual void OnCreate()
        {
            World.Objects.Add(Id, this);
        }

        public virtual void SetActive(bool state)
        {
            Active = state;
        }

        public virtual void UpdatePosition(Vector2 newPosition)
        {
            Position = newPosition;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}={Name}: {nameof(Id)}={Id.ToString()}, {nameof(Position)}={Position.ToString()}, {nameof(Active)}={Active.ToString()}";
        }

        public override bool Equals(object obj)
        {
            return obj is GameObject @object &&
                   Id == @object.Id &&
                   Name == @object.Name &&
                   Position.Equals(@object.Position) &&
                   Active == @object.Active &&
                   Shape == @object.Shape;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Position, Active, Shape);
        }
    }
}

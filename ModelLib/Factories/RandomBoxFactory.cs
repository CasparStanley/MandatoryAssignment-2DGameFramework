using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Factories
{
    public class RandomBoxFactory : GameObjectFactory
    {
        Vector2 Range { get; set; }

        public RandomBoxFactory(Vector2 range, string name) : base(name)
        {
            Range = range;
        }

        public override GameObject GetGameObject()
        {
            Random r = new Random();
            int x = r.Next((int)Range.x, (int)Range.y);
            int y = r.Next((int)Range.x, (int)Range.y);
            Vector2 pos = new Vector2(x, y);

            return new GameObject(_name, pos);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Interfaces
{
    internal interface IHittable
    {
        void GetHit(int damage);
    }
}

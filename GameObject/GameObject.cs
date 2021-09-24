using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject
{
    public abstract class GameObject
    {
        public abstract int GameValue
        {
            get;
        }

        public abstract GameObjectMedium Medium
        {
            get;
        }
    }
}

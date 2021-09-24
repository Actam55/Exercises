using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject
{
    public enum GameObjectMedium { Paper, Plastic, Electronic }

    public interface IGameObject
    {

        int GameValue
        {
            get;
        }

        GameObjectMedium Medium
        {
            get;
        }
    }
}

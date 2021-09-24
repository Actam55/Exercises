using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject
{
    using System;

    public class Die : GameObject
    {
        private int numberOfEyes;
        private Random randomNumberSupplier;
        private readonly int maxNumberOfEyes;

        public Die() : this(6) { }

        public Die(int maxNumberOfEyes)
        {
            randomNumberSupplier =
              new Random(unchecked((int)DateTime.Now.Ticks));
            this.maxNumberOfEyes = maxNumberOfEyes;
            numberOfEyes = NewTossHowManyEyes();
        }

        public void Toss()
        {
            numberOfEyes = NewTossHowManyEyes();
        }

        private int NewTossHowManyEyes()
        {
            return randomNumberSupplier.Next(1, maxNumberOfEyes + 1);
        }

        public int NumberOfEyes()
        {
            return numberOfEyes;
        }

        public override String ToString()
        {
            return String.Format("Die[{0}]: {1}", maxNumberOfEyes, numberOfEyes);
        }

        public override int GameValue
        {
            get
            {
                return numberOfEyes;
            }
        }

        public override GameObjectMedium Medium
        {
            get
            {
                return
                 GameObjectMedium.Plastic;
            }
        }

    }
}

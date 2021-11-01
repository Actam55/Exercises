using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Car : IComparable, IComparer<Car>
    {
            public string Make { get; set; }
            public string Model { get; set; }
            public double Price { get; set; }

        public int Compare(Car x, Car y)
        {
            if (x.Make.CompareTo(y.Make) >= 1)
            {
                return 1;
            }
            else if (x.Make.CompareTo(y.Make) <= -1)
            {
                return -1;
            }
            else
            {
                if (x.Model.CompareTo(y.Model) >= 1)
                {
                    return 1;
                }
                else if (x.Model.CompareTo(y.Model) <= -1)
                {
                    return -1;
                }
                else
                {
                    if (x.Price.CompareTo(y.Price) >= 1)
                    {
                        return -1;
                    }
                    else if (x.Price.CompareTo(y.Price) <= -1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        public int CompareTo(object obj)
        {
            Car otherCar = obj as Car;

            return Compare(this, otherCar);
        }
    }

    public class CarComparerer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (x.Model.CompareTo(y.Model) >= 1)
            {
                return 1;
            }
            else if (x.Model.CompareTo(y.Model) <= -1)
            {
                return -1;
            }
            else
            {
                if (x.Price.CompareTo(y.Price) >= 1)
                {
                    return -1;
                }
                else if (x.Price.CompareTo(y.Price) <= -1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

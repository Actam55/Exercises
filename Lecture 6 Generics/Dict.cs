using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_6_Generics
{
    class Dict<K, V>
    {
        public Dict(List<Pair<K, V>> list)
        {
            Dic = list;
        }

        public List<Pair<K, V>> Dic { get; set; }

        public V Get(K key)
        {
            foreach (var item in Dic)
            {
                if (item.RaymondsType.Equals(key))
                {
                    return item.LarsType;
                }
            }
            throw new Exception("No such item exists");
        }

        public void Put(K key, V value)
        {
            Pair<K, V> check = new Pair<K, V>(key, value);

            for (int i = 0; i < Dic.Count; i++)
            {
                if (Dic[i].RaymondsType.Equals(key))
                {
                    Dic[i] = check;
                    return;
                }
            }
            Dic.Add(check);
        }
    }
}

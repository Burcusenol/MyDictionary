using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictonary
{
    class MyDictionary<Key,Value>
    {
        Key[] keys;
        Value[] values;

        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }
        public void Add(Key key,Value value)
        {
            Key[] tempKey = keys;
            keys = new Key[keys.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }
            keys[keys.Length - 1]=key;


            Value[] tempValue = values;
            values = new Value[values.Length + 1];
            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }
            values[values.Length - 1] = value;

        }
        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("İsim : "+keys[i] + " -- Yaş : " + values[i]);
            }
        }
        public void Length()
        {
            Console.WriteLine("Kişi Sayısı : "+keys.Length);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Key,Value>
    {
        Key[] _key;
        Value[] _value;

        public MyDictionary()
        {
            _key = new Key[0];
            _value = new Value[0];
        }

        public void Add(Key key,Value value)
        {
            Key[] tempKey = _key;
            _key = new Key[_key.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                _key[i] = tempKey[i];
            }
            _key[_key.Length - 1] = key;
            Value[] tempValue = _value;
            _value = new Value[_value.Length + 1];
            for (int i = 0; i < tempValue.Length; i++)
            {
                _value[i] = tempValue[i];
            }
            _value[_value.Length - 1] = value;
            Console.WriteLine(" Plaka : " + key + " , "+ " Şehir : " +value);
        }

    }
}

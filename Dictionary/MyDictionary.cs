using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TK, TV>
    {
        TK[] key;
        TV[] value;
        public MyDictionary()
        {
            key = new TK[0];
            value = new TV[0];
        }
        public void Add(TK addedKey, TV addedValue)
        {
            TK[] _tempKey = key;
            key = new TK[key.Length + 1];

            TV[] _tempValue = value;
            value = new TV[value.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                key[i] = _tempKey[i];
                {
                    for (int j = 0; j < _tempValue.Length; j++)
                    {
                        value[j] = _tempValue[j];
                    }
                }
            }

            key[key.Length - 1] = addedKey;
            value[value.Length - 1] = addedValue;

        }
        public void List()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine("[" + key[i] + ", " + value[i] + "]");
            }
        }
    }
}
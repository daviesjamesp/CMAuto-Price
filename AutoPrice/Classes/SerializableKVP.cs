using System;

namespace AutoPrice
{
    [Serializable]
    public class SerializableKVP
    {
        public string index { get; set; }
        public string value { get; set; }

        public SerializableKVP()
        {
            index = "";
            value = "";
        }

        public void Set(string i, string v)
        {
            index = i;
            value = v;
        }
    }
}

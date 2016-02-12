using UnityEngine;
using System.Collections;

namespace Resources
{
    [System.Serializable]
    public class MyMaterial
    {
        const string name = "Material";
        public int amount;
        
        public static string Name
        {
            get { return name; }
        }      
    }

    [System.Serializable]
    public class Uranium : MyMaterial
    {
        const string name = "Uranium";

        public static new string Name
        {
            get { return name; }
        }
    }

    [System.Serializable]
    public class Duronium : MyMaterial
    {
        const string name = "Duronium";

        public static new string Name
        {
            get { return name; }
        }
    }
}

using UnityEngine;
using Resources;

public class Minerals : MonoBehaviour {

    [System.Serializable]
    public class Mineral
    {
        public int amount;
        public float access;
    }

    public Mineral uranium;
    public Mineral duranium;
    

    public MyMaterial[] Materials;
	// Use this for initialization
	
	void Mine ()
    {

    }
}

using UnityEngine;
using System.Collections;

public class FactionInfo : MonoBehaviour {
    //public string factionName = "Terran"; //HACK Use GameObject.name instead. Can be removed.
    public Texture2D factionIcon; //Used on this factions units
    [System.Serializable]
    public class Leader {
        public string name;
        [TextArea(3, 10)]public string bio;
    }
    public Leader leader;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

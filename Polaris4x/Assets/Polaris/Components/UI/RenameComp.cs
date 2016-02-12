
namespace RenameSpace
{
    using UnityEngine;

    public delegate void RenamedEventHandler(string newName);

    public class RenameComp : MonoBehaviour {
    
    public string theme; //TODO Yet to be implemented, ignore.

    public event RenamedEventHandler renamed;

    public int maxLength = 64;

    /// <summary>
    /// Call to change an objects name, and notify listeners.
    /// </summary>
    /// <param name="what">New name</param>
    public void Rename (string what)
    {
        if (what.Length > 0 & what.Length <= maxLength) //Make sure the string is valid.
        {
                //Debug.Log(name + " was renamed to " + what, gameObject);

                name = what;
            
                if (renamed != null)
                {
                    renamed(what); 
                    
                }
                else
                {
                }
        }
        else
        {
            Debug.Log("Tried to rename to nothing.");

        }
    }
}
 /**/
	}
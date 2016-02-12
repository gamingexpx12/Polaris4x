using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using RenameSpace;

/// <summary>
/// Component for getting and displaying the current star system's name.
/// </summary>
[RequireComponent(typeof(Text))]
public class SystemName : MonoBehaviour
{
    
    //TODO Support multiple systems
    public string targetTag = "Star"; 

    public string prefix = "The ";
    public string suffix = " System";
    Text text;
    GameObject target;
    RenameComp rename;

    void OnEnable()
    {
        //Get
        target = GameObject.FindWithTag(targetTag);
        text = GetComponent<Text>();
        rename = target.GetComponent<RenameComp>();

        Set(target.name);
        //Subsribe
        rename.renamed += Set;
    }

    void OnDisable()
    {
        rename.renamed -= Set;
    }
    /// <summary>
    /// Method to be invoked by either start or rename
    /// </summary>
    /// <param name="name">Name to use</param>
    void Set (string name)
    {
        text.text = prefix + name + suffix;
    }
}

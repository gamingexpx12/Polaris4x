using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
[System.Serializable]
public class ScenePrefs : MonoBehaviour
{
    /// <summary>
    /// Makes the planets move along their orbits (Only affects planets)
    /// </summary>
    public bool orbitalSimulation;
    public bool enableTimestep;
    public bool autoIncrement;
    //public Camera camera;


    void Start()
    {
        Scene.orbitSim = orbitalSimulation;
        Scene.disableUpdate = enableTimestep;
        Scene.autoIncrement = autoIncrement;
    }

}

public static class Scene
{
    public static bool orbitSim = false;
    public static bool disableUpdate = true;
    public static bool autoIncrement = false;
}

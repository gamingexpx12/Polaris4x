using UnityEngine;
using System;

public class Orbit : MonoBehaviour, ITimeStep {
    public float orbitDuration = 365;
    private const int scale = 365; //Scale of 365 since we're working with days.
    private const float timescaleInSeconds = 60;
	// Use this for initialization
	void Start () {
        var obj = GameObject.Find("SceneManager");
	}
	
	// Update is called once per frame
	void Update () {
        if (Scene.orbitSim )
        {
            var time = Time.deltaTime;
            float rotate = 360 * (time / timescaleInSeconds) / (orbitDuration / scale);

            transform.Rotate(0, rotate, 0); 
        }
	}

    private void rotate(float amount)
    {
        
    }

    void OnEnable ()
    {
        TimeStepModule.TimestepEvent += TimeStep;
    }

    void OnDisable ()
    {

    }
    /// <summary>
    /// Called every timestep in order to make the system bodies move
    /// </summary>
    /// <param name="days"></param>
    public void TimeStep(TimeSpan time)
    {
        float rotate = 360 * (float)time.TotalDays / orbitDuration;

        transform.Rotate(0, rotate, 0);
    }
}

using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
    public GameObject target;
    public GameObject springArm;
    public GameObject cam;

    public string XAxisName = "Horizontal";
    public string YAxisName = "Vertical";
    public string ZAxisName = "Mouse ScrollWheel";
    public float speed = 500f;
    public float scrollSpeed = 500f;
    
    private float x;
    private float y;
    private float z;
    
    private float dt;

	private 
	void Update ()
    {
        x = Input.GetAxis(XAxisName);
        y = Input.GetAxis(YAxisName);
        z = Input.GetAxis(ZAxisName);

        dt = Time.deltaTime;
       
        //Move
        transform.Translate(Vector3.right * x * speed * dt);
        transform.Translate(Vector3.forward * y * speed * dt);
        
        //Zoom
        var locPos = cam.transform.localPosition; 
        z *= locPos.z;
        //var fwd = springArm.transform.forward;
        //cam.transform.Translate(fwd * z * scrollSpeed * dt);
        z *= scrollSpeed * dt;
        locPos = new Vector3(0,0,locPos.z + z);

        cam.transform.localPosition = locPos;
    }
}

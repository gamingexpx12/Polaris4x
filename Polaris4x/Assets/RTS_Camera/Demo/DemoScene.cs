using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using RTS_Cam;

public class DemoScene : MonoBehaviour 
{
    public Button btn45;
    public Button btn90;

    public Toggle keyboard;
    public Toggle pan;
    public Toggle mouse;

    private RTS_Camera rts;

    private void Start()
    {
        Transform camT = Camera.main.transform;
        btn45.onClick.AddListener(() => SetXRotation(camT, 45f));
        btn90.onClick.AddListener(() => SetXRotation(camT, 90f));

        rts = Camera.main.GetComponent<RTS_Camera>();
    }

    private void Update()
    {
        ToggleToggle(rts.keyboardMove, keyboard);
        ToggleToggle(rts.panningMove, pan);
        ToggleToggle(rts.mouseMove, mouse);
    }

    private void SetXRotation(Transform t, float angle)
    {
        t.localEulerAngles = new Vector3(angle, t.localEulerAngles.y, t.localEulerAngles.z);
    }

    private void ToggleToggle(bool condition, Toggle target)
    {
        if (condition)
        {
            target.isOn = true;
        }

        else
        {
            target.isOn = false;
        }
    }
}

using UnityEngine;
using System.Collections;
using RenameSpace;
using UI;

public class BodyName : MonoBehaviour
{
    public GameObject TargetName;
    public GameObject textMesh;

    private GameObject textObj;
    private RenameComp renameComp;
    private NameTag nTag;
    private Camera cam;

    void Start()
    {
        cam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
    }

    void OnEnable()
    {
        textObj = (GameObject)Instantiate(textMesh, gameObject.transform.position, Quaternion.Euler(Vector3.forward));
        textObj.transform.parent = transform;
        nTag = textObj.GetComponent<NameTag>();

        if (TargetName = null)
        {
            TargetName = transform.parent.gameObject;
        }
        nTag.SetName(TargetName.name);
        TargetName.GetComponent<RenameComp>().renamed += OnRename;
    }

    private void OnRename(string newName)
    {
        nTag.SetName(newName);
    }

    void Update()
    {
        textObj.transform.rotation = cam.transform.rotation;
    }

    void OnDisable()
    {
        TargetName.GetComponent<RenameComp>().renamed -= OnRename;
        Destroy(textObj);


    }
}
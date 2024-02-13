using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LensCamera : MonoBehaviour
{
    // Start is called before the first frame update
    private Camera mainCamera;
    private GameObject magnifyingGlass;
    void Start()
    {
        mainCamera = Camera.main;
        magnifyingGlass = GameObject.Find("Magnifying Glass");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mainCamPos = mainCamera.transform.position;
        Vector3 localMainCamPos = transform.InverseTransformPoint(mainCamPos);
        Vector3 lookAtPoint = transform.TransformPoint(-1*localMainCamPos.x, -1*localMainCamPos.y, -1*localMainCamPos.z);

        transform.LookAt(lookAtPoint, magnifyingGlass.transform.up);
    }
}

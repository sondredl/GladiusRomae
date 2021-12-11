using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairTest : MonoBehaviour
{


    public Transform crosshair;
    public Camera cam;
    public Transform muzzle;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(muzzle.transform.position, muzzle.transform.forward, out hit))
        {
            if (hit.collider)
            {
                crosshair.transform.position = cam.WorldToScreenPoint(hit.point);
            }
        }
    }
}
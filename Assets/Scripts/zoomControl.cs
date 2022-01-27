using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomControl : MonoBehaviour
{
    public float zoomSize = 5;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if(zoomSize > 3)
            {
                zoomSize -= 1;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (zoomSize < 8)
            {
                zoomSize += 1;
            }
        }

        GetComponent<Camera>().orthographicSize = zoomSize;
    }
}

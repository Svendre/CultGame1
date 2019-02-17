using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    // Update is called once per frame
    void Update()
    {
        float xAxisValue = Input.GetAxis("Horizontal");
        float zAxisValue = Input.GetAxis("Vertical") * (float)0.3;
        float yAxisValue = Input.GetAxis("Vertical") * (float)0.6;
        if (Camera.current != null)
        {
            Camera.current.transform.Translate(new Vector3(xAxisValue, yAxisValue, zAxisValue));
        }
    }
}

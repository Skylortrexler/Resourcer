using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float camSize;
    Vector3 lastPos = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        camSize = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
            lastPos = Input.mousePosition;

		} else if (Input.GetMouseButton(0))
		{
            Vector3 curPos = Input.mousePosition;
            Vector3 delta = curPos - lastPos;
            Camera.main.transform.Translate(-Vector3.Scale(delta,new Vector3(0.05f,0.05f,0.05f)));
            lastPos = Input.mousePosition;
		}

        camSize = Input.mouseScrollDelta.y != 0 ? camSize += Input.mouseScrollDelta.y : camSize;
        camSize = camSize < 5 ? 5 : camSize > 15 ? 15 : camSize;
        Camera.main.orthographicSize = camSize;
    }
	
}

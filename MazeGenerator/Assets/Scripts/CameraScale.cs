using UnityEngine;

public class CameraScale : MonoBehaviour
{

    private float x;
    private float y;
    private float z;
    
	void Start ()
    {
        // Getting maze length and width
        x = (float)PlayerPrefs.GetInt("Length") / 2;
        z = (float)PlayerPrefs.GetInt("Width") / 2-1;

        // Checking how high the camera should be so that all maze could be seen
        if (x > z) y = x*2+1;
        else y = z*2+1;

        // Moving camera so that all maze can be seen
        transform.position = new Vector3(x, y, z);
	}
}

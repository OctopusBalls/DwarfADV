using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tango;

public class TestScript : MonoBehaviour {
    public TangoPointCloud pointCloud;
	public Vector3 pos;
	public Plane plane;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            TouchPhase p = t.phase;
            if(p == TouchPhase.Began)
            {
                StartCoroutine(FindPlane(t.position));
            }
        }

	}

    private IEnumerator FindPlane(Vector2 touchPosition)
    {
        Camera cam = Camera.main;

        if(!pointCloud.FindPlane(cam,touchPosition,out pos,out plane))
        {
            yield break;
        }
        transform.position = pos;
        transform.forward = new Vector3(
            cam.transform.position.x - transform.position.x,
            0,
            cam.transform.position.z - transform.position.z).normalized;
		
    }
}

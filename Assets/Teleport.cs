using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public Transform black;
    public Transform blue;
    public Transform red;
    public Transform green;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) > 0)
            transform.position = new Vector3(black.position.x, 4, black.position.z);
        else if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) > 0)
            transform.position = new Vector3(blue.position.x, 4, blue.position.z);
        else if(OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0)
            transform.position = new Vector3(red.position.x, 4, red.position.z);
        else if (OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) > 0)
            transform.position = new Vector3(green.position.x, 4, green.position.z);
    }
}

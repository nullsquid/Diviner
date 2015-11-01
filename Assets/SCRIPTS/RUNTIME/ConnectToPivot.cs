using UnityEngine;
using System.Collections;

public class ConnectToPivot : MonoBehaviour {

    DistanceJoint2D distanceJoint;
    GameObject connectedBody;
    void Awake() {
        connectedBody = GameObject.Find("INTESTINE_PIVOT");
        {
            distanceJoint = gameObject.GetComponent<DistanceJoint2D>();
            if (distanceJoint.enabled) {
                distanceJoint.connectedBody = connectedBody.GetComponent<Rigidbody2D>();

            }

        }

    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

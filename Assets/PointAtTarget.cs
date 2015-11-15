using UnityEngine;
using System.Collections;

public class PointAtTarget : MonoBehaviour {

    public Transform target;

    private Vector3 v_diff;
    private float atan2; 
	// Update is called once per frame
	void Update () {
        v_diff = (transform.position - target.position);
        atan2 = Mathf.Atan2(v_diff.y, v_diff.x);
        transform.rotation = Quaternion.Euler(0f, 0f, atan2 * Mathf.Rad2Deg);
	}
}

using UnityEngine;
using System.Collections;

public class Cloud : MonoBehaviour {
    public float speed;
    public float[] speeds = { .1f, .2f, .3f, .4f, .5f };
	// Use this for initialization
	void Start () {
        speed = speeds[Random.Range(0, speeds.Length)];
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * Time.deltaTime *speed);
	}
}

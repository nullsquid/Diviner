using UnityEngine;
using System.Collections;

public class GroundDetection : MonoBehaviour {
    public Sprite newSprite;
    public GameObject targetObject;
	void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "FLOOR") {
            Debug.Log("working?");
            targetObject.GetComponent<SpriteRenderer>().sprite = newSprite;
        }

    }
}

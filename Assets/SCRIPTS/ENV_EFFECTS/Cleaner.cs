﻿using UnityEngine;
using System.Collections;

public class Cleaner : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {

        Destroy(coll.gameObject);
    }
}

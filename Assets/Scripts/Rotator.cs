using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	// rotates collectibles for aesthetic
	void Update () {
        transform.Rotate (new Vector3 (15, 30, 45) *Time.deltaTime);
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject player;

    private Vector3 cameraoffset;

    //initialize camera offset value
    void Start()
    {
        cameraoffset = transform.position - player.transform.position;
    }

    //update camera offset every frame
    void LateUpdate()
    {
        transform.position = player.transform.position + cameraoffset;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMovement : MonoBehaviour
{

    public Vector2 cameraChangeMin;
    public Vector2 cameraChangeMax;
    public Vector3 playerChange;
    private CameraMovement _cameraMovement;
    private void Start() {
        _cameraMovement = Camera.main.GetComponent<CameraMovement>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            _cameraMovement.minPosition += cameraChangeMin;
            _cameraMovement.maxPosition += cameraChangeMax;
            other.transform.position += playerChange;
        }
    }
}

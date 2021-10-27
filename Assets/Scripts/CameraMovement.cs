using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public Transform target;
    public float smoothing;
    public Vector2 maxPosition;
    public Vector2 minPosition;
    private void Start() {
        
    }

    private void LateUpdate() {
        var position = transform.position;
        var currentTargetPosition = target.position;
        if (position != currentTargetPosition) {
            Vector3 targetPosition = new Vector3(currentTargetPosition.x, currentTargetPosition.y, position.z);
            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);
            transform.position = Vector3.Lerp(position, targetPosition, smoothing);
        }
    }
}
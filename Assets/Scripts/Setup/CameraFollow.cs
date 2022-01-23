using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [Header("References")]
    [SerializeField] private Transform cameraPosition;

    private void Update() =>
        transform.position = cameraPosition.position;
}

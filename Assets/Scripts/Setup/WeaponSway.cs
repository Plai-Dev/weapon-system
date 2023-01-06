/* Importing Namespaces. */
using System;
using UnityEngine;
using UnityEngine.InputSystem;

/* Setup our class */
public class WeaponSway : MonoBehaviour
{

    /* Sway settings for use in Inspector. */
    [Header("Sway Settings")]
    [SerializeField] private float speed;
    [SerializeField] private float sensitivityMultiplier;

    /* Variables! Oh deary me! */
    private Quaternion refRotation;
    private float xRotation;
    private float yRotation;

    /* Update function. Gets ran every tick! */
    private void Update() {

        /* The following line makes the jump from the old Input Package to the new UnityEngine.InputSystem. */
        Vector2 mousePosition = Mouse.current.delta.ReadValue();

        /* Get Mouse-Delta, Multiply such with the Sensitivity Multiplier we set in the inspector. */
        float mouseX = mousePosition.x * sensitivityMultiplier;
        float mouseY = mousePosition.y * sensitivityMultiplier;

        /* Manipulate the Quaternions. */
		Quaternion rotationX = Quaternion.AngleAxis(-mouseY, Vector3.right);
		Quaternion rotationY = Quaternion.AngleAxis(mouseX, Vector3.up);

        /* Put them into a package! */
		Quaternion targetRotation = rotationX * rotationY;

        /* We SWAYYYYS! :O */
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, speed * Time.deltaTime);
    }

}

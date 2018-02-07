using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;

	public float speedH = 2.0f;

    private float yaw = 0.0f;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		Cursor.lockState = CursorLockMode.Locked;
	}

	void FixedUpdate()
	{
		//var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		//transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);

		yaw = speedH * Input.GetAxis("Mouse X");
        transform.Rotate(0.0f, yaw, 0.0f);
	}
}

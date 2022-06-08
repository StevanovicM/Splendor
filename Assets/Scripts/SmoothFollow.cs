using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
	public Transform target;
	public float movementTime = 1;
	public float rotationSpeed = 0.1f;

	private Vector3 refPos;
	private Vector3 refRot;

	// Update is called once per frame
    void Update()
	{
		if (!target)
			return;
		// Interpolate Position
		transform.position = Vector3.SmoothDamp(transform.position, target.position, ref refPos, movementTime);
		// Interpolate Rotation
		transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, rotationSpeed = Time.deltaTime);

	}
}

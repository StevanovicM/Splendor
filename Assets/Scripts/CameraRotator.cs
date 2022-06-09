using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
	public float speed;
	// Update is called once per frame
    public void Rotate()
	{
		transform.Rotate(0, 0, -90);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject Target;
	public float DesiredDistance = 4f;
	float pitch = 0f;
	public float pitchmin = -40;
	public float pitchmax = 60;
	float yaw = 0f;
	float roll = 0f;
	public float sensitivity = 15f;
	// Update is called once per frame
	void Update()
	{
		pitch -= sensitivity * Input.GetAxis("Mouse Y");
		yaw += sensitivity * Input.GetAxis("Mouse X");
		transform.localEulerAngles = new Vector3(pitch, yaw, roll);
		transform.position = Target.transform.position - DesiredDistance * transform.forward + Vector3.up * 2f;
		pitch = Mathf.Clamp(pitch, pitchmin, pitchmax);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
	public Animator Anim;
	public bool IsAiming;

	private void Start()
	{
		Anim = GetComponent<Animator>();	
	}

	void Update()
    {
		Aiming();
    }

	void Aiming() {
		if (Input.GetMouseButton(1))
		{
			IsAiming = true;
			Anim.SetBool("IsAiming", IsAiming);
		}
		else if (Input.GetMouseButtonUp(1))
		{
			IsAiming = false;
			Anim.SetBool("IsAiming", IsAiming);
		}
	}
}

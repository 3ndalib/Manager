using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{

	public enum States {
		Movement,
		Aim,
	}

	void SetAnimation(States CS){
		SetMovementState(CS == States.Movement);
		SetAimState(CS == States.Aim);
	}

	void SetMovementState(bool State) {
		if (State){
			PlayerMovement EnableMovement = GetComponent<PlayerMovement>();
			EnableMovement.enabled = true;
		}
		else {
			PlayerMovement EnableMovement = GetComponent<PlayerMovement>();
			EnableMovement.enabled = false;
		}
	}

	void SetAimState(bool State)
	{
		if (State)
		{
			Aim EnableAim = GetComponent<Aim>();
			EnableAim.enabled = true;
		}
		else
		{
			Aim EnableAim = GetComponent<Aim>();
			EnableAim.enabled = false;
		}
	}
}

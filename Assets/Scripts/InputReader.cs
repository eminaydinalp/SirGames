using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour, IInputReader
{
	Vector2 _direction;
	public Vector2 Direction => _direction;

	public void OnMove(InputAction.CallbackContext callbackContext)
	{
		_direction = callbackContext.ReadValue<Vector2>();
	}
}

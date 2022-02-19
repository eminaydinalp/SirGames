using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : IMover
{
	PlayerController _playerController;
	public PlayerMover(PlayerController playerController)
	{
		_playerController = playerController;
	}


	public void Move(float directionX, float directionY, float moveSpeed, float rotationSpeed)
	{
		Vector3 movementDirection = new Vector3(directionX, 0, directionY);
		movementDirection.Normalize();

		_playerController.transform.Translate(movementDirection * moveSpeed * Time.fixedDeltaTime, Space.World);

		if (movementDirection != Vector3.zero)
		{
			Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
			_playerController.transform.rotation = Quaternion.RotateTowards(_playerController.transform.rotation, toRotation, rotationSpeed * Time.fixedDeltaTime);
		}
	}
}

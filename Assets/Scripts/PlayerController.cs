using UnityEngine;

public class PlayerController : MonoBehaviour
{
	IInputReader _input;
	IMover _mover;

	public float moveSpeed;
	public float rotationSpeed;

	public int scoreAmount›ncreased = 10;
	public int finishScore = 20;

	private void Awake()
	{
		_input = GetComponent<InputReader>();
		_mover = new PlayerMover(this);
	}
	private void Start()
	{
		PlayerPrefs.DeleteKey("Score");
	}

	private void FixedUpdate()
	{
		_mover.Move(_input.Direction.x, _input.Direction.y, moveSpeed, rotationSpeed);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Ball"))
		{
			ObjectPooler.instance.activeBalls.Remove(other.gameObject);
			other.gameObject.SetActive(false);
			ScoreManager.instance.UpdateScore(scoreAmount›ncreased, finishScore);
		}
	}

}

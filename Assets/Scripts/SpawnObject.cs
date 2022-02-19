using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
	ObjectPooler _objectPooler;
	public GameObject ball;
	public Vector3 size;
	public Vector3 center;
	public float ballY = 0.56f;
	private void Awake()
	{
		_objectPooler = ObjectPooler.instance;
	}
	private void Start()
	{
		InvokeRepeating(nameof(SpawnBall), 0, 1f);
	}

	public void SpawnBall()
	{
		if (_objectPooler.activeBalls.Count > 4) return;

		Vector3 pos = new Vector3(Random.Range(-size.x / 2, size.x / 2), ballY, Random.Range(-size.z / 2, size.z / 2));
		_objectPooler.SpawnFromPool("Ball", pos, Quaternion.identity);
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = new Color(1, 0, 0, 0.5f);
		Gizmos.DrawCube(center, size);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public GameObject enemyProjectile;
	private float timer = 0;
	private float randomSpawnTime;

	private void Start()
	{
		PickRandomSpawnTime();
	}

	void Update()
    {
		if (timer > randomSpawnTime)
		{
			Instantiate(enemyProjectile, transform);
			PickRandomSpawnTime();
			timer = 0;
		}

		timer += Time.deltaTime;
	}

	void PickRandomSpawnTime()
	{
		randomSpawnTime = Random.Range(0.5f, 3f);
	}
}

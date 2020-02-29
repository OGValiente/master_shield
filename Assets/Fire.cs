using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
	private GameObject target;
	private GameObject circle;
	public float fireSpeed;

	private void Start()
	{
		target = GameObject.Find("Player");
		circle = GameObject.Find("ShieldCircle");
	}
	void Update()
	{
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, fireSpeed * Time.deltaTime);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject == target)
		{
			//Game over
			Time.timeScale = 0;
		} else if (collision.gameObject == circle)
		{
			Destroy(gameObject);
		}
	}
}

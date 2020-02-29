using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
	public GameObject playerShield;
	public GameObject shieldCircle;
	private Transform playerShieldTransform;
	private Transform knightTransform;
	private Transform shieldCircleTransform;

	void Start()
    {
		playerShieldTransform = playerShield.GetComponent<Transform>();
		knightTransform = GetComponent<Transform>();
		shieldCircleTransform = playerShieldTransform.GetComponent<Transform>();
	}

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
		{
			knightTransform.rotation = new Quaternion(0, 180, 0, 0);
			playerShieldTransform.position = new Vector3(playerShieldTransform.position.x, playerShieldTransform.position.y, 1);
			shieldCircleTransform.rotation = new Quaternion(0, -45, 0, 0);
		} else if (Input.GetKey(KeyCode.RightArrow))
		{
			knightTransform.rotation = new Quaternion(0, 0, 0, 0);
			playerShieldTransform.position = new Vector3(playerShieldTransform.position.x, playerShieldTransform.position.y, -1);
			shieldCircleTransform.rotation = new Quaternion(0, 45, 0, 0);
		}
	}
}

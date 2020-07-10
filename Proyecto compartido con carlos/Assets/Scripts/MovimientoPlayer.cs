using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
	public GameObject player;
	public float runSpeed;
	float horizontalMove = 0f;

	// Update is called once per frame
	void Update()
    {
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		if (Input.GetButton("Left"))
		{
			//player.GetComponent<Rigidbody2D>().velocity.x += horizontalMove;
		}
    }
}

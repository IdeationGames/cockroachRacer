using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDriver : MonoBehaviour
{
	[SerializeField] int playerIndex;
	private bool accelerate;
	private Rigidbody rb;
	private float xVelocity = 10f;

	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		GetInput();

        if (rb == null)
		{
			return;
		}

		if (accelerate)
		{
			Vector3 velo = rb.velocity;
			velo.x = xVelocity;
			rb.velocity = velo;
		}
	}

	private void GetInput()
	{
		switch(playerIndex)
		{
			case 0:
				if (Input.GetButtonUp("P1_accelerate"))
				{
					accelerate = false;
				}
				if (Input.GetButtonDown("P1_accelerate"))
				{
					accelerate = true;
				}
				break;
			default:
				if (Input.GetButtonUp("P1_accelerate"))
				{
					accelerate = false;
				}
				if (Input.GetButtonDown("P1_accelerate"))
				{
					accelerate = true;
				}
				break;
		}
	}
}

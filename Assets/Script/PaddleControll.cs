using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControll : MonoBehaviour
{
	public int speed;
	public KeyCode upKey;
	public KeyCode downKey;

	private Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
		rigid = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
		MoveObject(GetInput());
    }
	private Vector2 GetInput()
	{
		if (Input.GetKey(upKey))
		{
			return Vector2.up * speed;
		}
		else if (Input.GetKey(downKey))
		{
			return Vector2.down * speed;
		}
		return Vector2.zero;
	}
	private void MoveObject(Vector2 movement)
	{
		rigid.velocity = movement;
	}
}

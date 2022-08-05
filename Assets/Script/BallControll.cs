using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;

public class BallControll : MonoBehaviour
{
	private Rigidbody2D rigid;
	public Vector2 speed;
	public Vector2 resetPos;
    // Start is called before the first frame update
    void Start()
    {
		rigid = GetComponent<Rigidbody2D>();
		rigid.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void SpawnBall()
	{
		transform.position = new Vector3 (resetPos.x, resetPos.y, 2);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;

public class BallControll : MonoBehaviour
{
	private Rigidbody2D rigid;
	public Vector2 speed;
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
}

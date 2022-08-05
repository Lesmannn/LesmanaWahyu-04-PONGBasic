using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
	public Collider2D ball;
	public bool isRight;
	public GameManager manager;
    
	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col == ball)
		{
			if (isRight)
			{
				manager.AddScore1(1);
			}
			else
			{
				manager.AddScore2(1);
			}
		}
	}
}

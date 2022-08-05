using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public int Score1;
	public int Score2;

	public int maxScore;
	public BallControll ball;
    
	public void AddScore1(int increment)
	{
		Score1 += increment;
		ball.SpawnBall();

		if (Score1 >= maxScore)
		{
			GameOver();
		}
	}
	public void AddScore2(int increment)
	{
		Score2 += increment;
		ball.SpawnBall();
		if (Score2 >= maxScore)
		{
			GameOver();
		}
	}
	public void GameOver()
	{
		SceneManager.LoadScene("MainMenu");
	}
}

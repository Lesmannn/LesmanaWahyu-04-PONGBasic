using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
	public Text skorKiri;
	public Text skorKanan;

	public GameManager manager;
    // Update is called once per frame
    void Update()
    {
		skorKiri.text = manager.Score1.ToString();
		skorKanan.text = manager.Score2.ToString();
    }
}

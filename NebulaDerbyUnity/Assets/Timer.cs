using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    //coroutine start off 2 min 
    public float timeLeft = 30.0f;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            GameOver();
        }
    }

    void Start ()
    {
		
	}
	
	public void GameOver()
    {
        Debug.Log("GameOver");
    }


}

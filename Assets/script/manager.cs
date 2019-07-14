using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
	public GameObject player;
	public GameObject spawn;
	public int score;
	public int time = 20;
	public float tempTime = 0f;
	
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(player, spawn.transform.position, Quaternion.identity);
		score= 0;
    }

    // Update is called once per frame
    void Update()
    {
		if(tempTime < 1f)
		{
			tempTime += Time.deltaTime;
		}
		else 
		{
			time -= 1;
			tempTime = 0f;
		}
		
		displayScore();
    }
	
	public void displayScore()
	{
		GameObject.Find("score").GetComponent<Text>().text = score.ToString();
	}
}

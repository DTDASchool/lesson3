using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonus : MonoBehaviour
{
	public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
       manager = GameObject.Find ("manager");	 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter (Collider other)
	{ 
		if(other.gameObject.tag == "Player")
		{
			manager.GetComponent<manager>().score +=  1;
			Debug.Log("touché");
		}
	}
}

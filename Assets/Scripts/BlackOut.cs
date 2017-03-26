using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackOut : MonoBehaviour {

    // Use this for initialization
    private float waitSec = 15.0f;

	
    public void Start()
    {
        gameObject.SetActive(false);
       InvokeRepeating("LateCall", waitSec, waitSec);
    }
	
	private void LateCall()
    {
        
        if(gameObject.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }
        else if(!gameObject.activeInHierarchy)
        {
            gameObject.SetActive(true);
        }
    }
}

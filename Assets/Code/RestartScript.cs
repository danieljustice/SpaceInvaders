﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("lvl1");
        }else if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }


	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.X)) {
			SceneManager.LoadScene("Game2");

		if (Input.GetKeyDown(KeyCode.Y)) {
			SceneManager.LoadScene("Game3");
			}
		}
    }
}

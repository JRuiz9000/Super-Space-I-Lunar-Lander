﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D platform_collision)
    {
        if (platform_collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("SuccessScene");
        }
    }
}

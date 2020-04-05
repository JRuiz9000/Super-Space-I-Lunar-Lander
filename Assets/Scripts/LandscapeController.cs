using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LandscapeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D landscape_collision)
    {
        if (landscape_collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("FailedScene");
        }
    }
}

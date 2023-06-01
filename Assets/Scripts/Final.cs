using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D colision){
        if(colision.gameObject.name == "player"){
            // Debug.Log("Final");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

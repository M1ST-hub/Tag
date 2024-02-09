using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{


    void Start()
    {
        DontDestroyOnLoad(this.gameObject); 
    }

    void Update()
    {
        if(Input.anyKey && (SceneManager.GetActiveScene().buildIndex == 0))
        {
            LoadScene(1);
        }
    }

    void LoadScene( int scene)
    {
        SceneManager.LoadScene(scene);
    }

}

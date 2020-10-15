using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFlag : MonoBehaviour
{
    public bool finalLevel;
    public string nextSceneName;
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if (finalLevel)
            {
                SceneManager.LoadScene(0); // 0 = main menu, todo high score menu
            }
            else
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}

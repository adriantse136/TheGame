using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedStuff : MonoBehaviour
{
    void Start()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        System.Threading.Thread.Sleep(1000);
        print("You died");
        SceneManager.LoadScene("GameOver");

    }
}

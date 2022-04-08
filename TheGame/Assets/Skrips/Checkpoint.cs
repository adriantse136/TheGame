using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    public string Next = "";
    public LevelManager lm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        lm.LoadIt(Next);
        print("Collided checkpoint");

    }
}

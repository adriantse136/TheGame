using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGarbageTruck : MonoBehaviour
{

    private Rigidbody2D rb2D;
    public float moveHorizontal;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2D.AddForce(new Vector2(moveSpeed * moveHorizontal, 0f), ForceMode2D.Impulse);

        
    }
}

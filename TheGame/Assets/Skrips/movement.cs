using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float MovementSpeed = 1;
    Animator animate;
    private Rigidbody2D rigid;
    // Start is called before the first frame update  
    void Start()
    {

    }

    // Update is called once per frame  
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement * 100, 0, 0) * Time.deltaTime * MovementSpeed;
        //print("update");

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigid.velocity.y) < 0.001f)
        {
            //this.GetComponent<AudioSource>().Play();
            rigid.AddForce(new Vector2(0, 4), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            //animate.SetInteger("state", 1);
            //print("right");
        }
        else
        {
            //animate.SetInteger("state", 0);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float MovementSpeed = 1;
    Animator animate;
    private Rigidbody2D rigid;
    public float jumpforce;
    public BulletBehavior bullet;
    public Transform BulletOffset;
    public static int direction;
    // Start is called before the first frame update  
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        direction = 1;
    }

    // Update is called once per frame  
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(movement * MovementSpeed, 0, 0) * Time.deltaTime);
        //print("update");

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigid.velocity.y) < 0.001f)
        {
            //this.GetComponent<AudioSource>().Play();
            print("Try to jump");
            rigid.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            //animate.SetInteger("state", 1);
            //print("right");
            if (Input.GetKey(KeyCode.D))
                direction = 1;
            else if (Input.GetKey(KeyCode.A))
                direction = -1;
        }
        if(Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(bullet, BulletOffset.position, transform.rotation);
        }
        else
        {
            //animate.SetInteger("state", 0);
        }
    }
}
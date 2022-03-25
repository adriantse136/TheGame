using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchWidth : MonoBehaviour
{

    // Set this to the in-world distance between the left & right edges of your scene.
    public float sceneWidth = 3000;

    Camera _camera;
    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    // Adjust the camera's height so the desired scene width fits in view
    // even if the screen/window size changes dynamically.
    void Update()
    {
        print("Camera Y: " + GameObject.Find("Main Camera").transform.position[1]);
        print("Player Y: " + GameObject.Find("Player").transform.position[1]);
        transform.position = new Vector3(0, GameObject.Find("Player").transform.position[1], 0);
    }
}
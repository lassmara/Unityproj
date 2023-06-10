using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    // fro movement of a game object
    private Transform mss;
    private scar scr; 
    private float speed = 1f;
    void Start()
    {
        mss = GetComponent<Transform>();
        scr = GetComponent<scar>();
    }

    // Update is called once per frame
    void Update()
    {
        var pos = mss.position;
        pos.x += speed * Time.deltaTime*Input.GetAxis("Horizontal");
        mss.position = pos; 
        print(Input.GetAxis("Horizontal"));

    }

}

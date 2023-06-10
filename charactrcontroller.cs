using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactrcontroller : MonoBehaviour
{
    private CharacterController  _chr;
    // Start is called before the first frame update
    void Start()
    {
       
        _chr = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _chr.Move(new Vector3(0.05f, 0f, 0f));
    }
}

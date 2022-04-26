using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    public float power = 10;
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

         rigidbody.AddForce(new Vector3((Convert.ToInt32(Input.GetKey(KeyCode.RightArrow)) - Convert.ToInt32(Input.GetKey(KeyCode.LeftArrow))), 0, (Convert.ToInt32(Input.GetKey(KeyCode.UpArrow)) - Convert.ToInt32(Input.GetKey(KeyCode.DownArrow)))).normalized * power);

    }
}

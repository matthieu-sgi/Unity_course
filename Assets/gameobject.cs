using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameobject : MonoBehaviour
{
    public GameObject obj;
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = obj.GetComponent<Rigidbody>();
        // display.error("Hello World");
        Debug.Log(_rb.velocity);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity += new Vector3(0.5f, 0, 0);   
        
    }
}

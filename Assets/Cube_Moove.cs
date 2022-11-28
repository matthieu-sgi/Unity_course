using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Moove : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(this.transform.position.x, obj.GetComponent<Transform>().position.y + (obj.GetComponent<MeshRenderer>().bounds.size.y/2), this.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

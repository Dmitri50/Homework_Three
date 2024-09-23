using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObject : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer meshRenderer;

    new Rigidbody rigidbody;

    float timeToWait = 5f;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidbody.useGravity = false;   
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait) 
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true; 
        }
    }
}

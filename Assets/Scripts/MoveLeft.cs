using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 5.0f;

    private float xDestroy = -10f;
    
    private Rigidbody objectRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        objectRigidbody = GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        objectRigidbody.AddForce(Vector3.left * speed);
        if (transform.position.x < xDestroy)
        {
            Destroy(gameObject);
        }
    }
}

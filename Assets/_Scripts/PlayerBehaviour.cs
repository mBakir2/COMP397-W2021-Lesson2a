using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
       // rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            //Move right
            rigidbody.AddForce(Vector3.right * movementForce);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            //Move left
            rigidbody.AddForce(Vector3.left * movementForce);
        }
    }
}

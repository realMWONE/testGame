using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)){
            //Debug.Log("Space hold down");
            GetComponent<Rigidbody>().AddForce(Vector3.up*5, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A)) {
            GetComponent<Rigidbody>().AddForce(Vector3.left/2, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right/2, ForceMode.VelocityChange);
        }
    }
}

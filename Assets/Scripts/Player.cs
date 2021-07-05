using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rigidBodyComponent;
    private int numberJumped;

    // Start is called before the first frame update
    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
        numberJumped = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)){
            //Debug.Log("Space hold down");
            if (numberJumped < 2)
            {
                rigidBodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
                numberJumped++;
            }
        }

        /**TODO: Reset numberJumped to 0 when object touches ground**/


        if (Input.GetKey(KeyCode.A)) {
            rigidBodyComponent.AddForce(Vector3.left/2, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidBodyComponent.AddForce(Vector3.right/2, ForceMode.VelocityChange);
        }
    }
}

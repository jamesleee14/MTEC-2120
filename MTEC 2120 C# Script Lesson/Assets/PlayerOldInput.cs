using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOldInput : MonoBehaviour
{
    public float jumpForce = 250f;
    bool isJumping = false;
    bool isFiring = false;

    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * jumpForce);
        }
    }
}

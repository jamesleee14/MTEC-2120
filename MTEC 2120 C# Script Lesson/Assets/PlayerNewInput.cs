using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerNewInput))]

public class PlayerNewInput : MonoBehaviour
{
    public float jumpForce = 250f;
    Rigidbody rigid;

    // Start is called before the first frame update
    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump is called.");
        rigid.AddForce(Vector3.up * jumpForce);
    }
}

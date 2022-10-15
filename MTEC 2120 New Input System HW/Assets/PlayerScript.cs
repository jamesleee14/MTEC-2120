using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerScript))]

public class PlayerScript : MonoBehaviour
{
    public float jumpForce = 100f;
    Rigidbody rigid;

    public float bulletSpeed = 5;
    public GameObject Bullet;

    // Start is called before the first frame update
    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump is called.");
        rigid.AddForce(Vector3.up*jumpForce);
    }

    public void Shoot()
    {
        Vector3 offset = new Vector3(0, 0.5f, 0);
        GameObject bullet = Instantiate(Bullet, transform.position + offset, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

        float yMove = Input.GetAxis("Horizontal") * bulletSpeed * Time.deltaTime;

        transform.Translate(0, yMove, 0);

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
}

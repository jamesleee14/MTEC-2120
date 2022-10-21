using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class BulletScript : MonoBehaviour
{
    public GameObject bullet;
    public float projectileForce = 100f;
    public void OnFire(InputAction.CallbackContext context)
    {
        GameObject go = Instantiate(bullet);
        go.GetComponent<Rigidbody>().AddForce(transform.forward);
    }

}

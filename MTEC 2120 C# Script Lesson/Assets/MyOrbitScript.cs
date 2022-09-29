using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyOrbitScript : MonoBehaviour
{

    public GameObject objectToOrbit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Transform orbitTransform = objectToOrbit.transform;
        Vector3 orbitPosition = orbitTransform.position;
        Vector3 orbitAxis = Vector3.up;
        float orbitAngle = 1.0f;

        transform.RotateAround(orbitPosition, orbitAxis, orbitAngle);

    }
}

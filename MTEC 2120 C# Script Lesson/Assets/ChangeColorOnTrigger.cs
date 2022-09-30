using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnTrigger : MonoBehaviour
{

    Renderer[] rends;

    // Start is called before the first frame update
    void Start()
    {
        rends = GetComponentsInChildren<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter(Collider other)
    {
        foreach(var rend in rends)
        {
            rend.material.color = GetRandomColor();
        }
    }

    Color GetRandomColor()
    {
        return new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    public GameObject cube;
    public GameObject sphere;
    public GameObject capsule;

    // Start is called before the first frame update
    void Start()
    {
        
        for (int i=0; i<10; i++)
        {
           Instantiate(cube, new Vector3(i * 5.0f, 0, 0), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(sphere, new Vector3(i*5.0f, 2.5f, 0), Quaternion.identity);
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            for (int i=0; i<10; i++)
            {
                Instantiate(capsule, new Vector3(i * 5.0f, 5.0f, 0), Quaternion.identity);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel(0);
        }

    }
}

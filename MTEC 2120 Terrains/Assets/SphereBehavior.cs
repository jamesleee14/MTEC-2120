using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehavior : MonoBehaviour
{

    float valueA = 10.5f;
    float valueB = 11.0f;

    string name = "John";
    int i = 0;
    float speed = 10.0f;
    char testChar = 'a';
    bool testBool = false;
    bool isCSharpFun = true;

    public GameObject myFirstObject;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("My name is " + name);
        Debug.Log("The smaller value is: " + Mathf.Min(valueA, valueB));
        Debug.Log("The larger value is: " + Mathf.Max(valueA, valueB));
        
        Debug.Log(Mathf.Max(5,10));
        Debug.Log(Mathf.Min(5, 10));
        Debug.Log(Mathf.Sqrt(64));
        Debug.Log(Mathf.Abs(-4.7f));
        Debug.Log(Mathf.Round(9.99f));


        if(isCSharpFun)
        {
            Debug.Log("C# is fun!!!");
        }

        if(name=="John")
        {
            Debug.Log("Yes, my name is John");
        }

        for (int i=0; i<10; i++)
        {
            //Will print out 0-9
            Debug.Log("Value is " + i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("You pressed the left mouse button.");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("You pressed the A key.");
        }

    }
}

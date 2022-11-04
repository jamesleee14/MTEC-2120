using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class Particles : MonoBehaviour
{
    ParticleSystem ps;

    public GameObject particle1;
    public GameObject particle2;
    public GameObject particle3;
    public GameObject particle4;
    public GameObject particle5;

    bool isActive;

    private void Start()
    {
        ps = particle1.GetComponent<ParticleSystem>();
        ps = particle2.GetComponent<ParticleSystem>();
        ps = particle3.GetComponent<ParticleSystem>();
        ps = particle4.GetComponent<ParticleSystem>();
        ps = particle5.GetComponent<ParticleSystem>();
    }

    public void firstInput(InputAction.CallbackContext context)
    {
        ParticleSystem.MainModule settings = ps.main;
        isActive = !isActive;
        particle1.SetActive(isActive);
    }

    public void secondInput(InputAction.CallbackContext context)
    {
        ParticleSystem.MainModule settings = ps.main;
        isActive = !isActive;
        particle2.SetActive(isActive);
    }

    public void thirdInput(InputAction.CallbackContext context)
    {
        ParticleSystem.MainModule settings = ps.main;
        isActive = !isActive;
        particle3.SetActive(isActive);
    }

    public void fourthInput(InputAction.CallbackContext context)
    {
        ParticleSystem.MainModule settings = ps.main;
        isActive = !isActive;
        particle4.SetActive(isActive);
    }

    public void fifthInput(InputAction.CallbackContext context)
    {
        ParticleSystem.MainModule settings = ps.main;
        isActive = !isActive;
        particle5.SetActive(isActive);
    }

}

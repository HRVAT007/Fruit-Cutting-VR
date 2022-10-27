using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject sphereContainer;
    private Sphere[] spheres;
    private Sphere sphereThrowing;
    public float timerShootNextSphere = 2f;
    private float timerCurrentlyShown;

    void Start()
    {
        spheres = sphereContainer.GetComponentsInChildren<Sphere>();
        timerCurrentlyShown = timerShootNextSphere;
    }

    // Update is called once per frame
    void Update()
    {
        timerCurrentlyShown -= Time.deltaTime;
        
        if(timerCurrentlyShown < 0)
        {
            sphereThrowing = spheres[Random.Range(0, spheres.Length)];

            sphereThrowing.transform.position = transform.position;

            sphereThrowing.ShowWholeFruit();

            timerCurrentlyShown = timerShootNextSphere;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    //Sphere Variables
    public GameObject wholeSphere;
    private GameObject throwingSphere;

    //Sphere throwing variables
    public float minVerticalForce;
    public float maxVerticalForce;
    public float minHorizontalForce;
    public float maxHorizontalForce;
    private float verticalForce;
    private float horizontalForce;
    private int throwDirection = 1; 

    void Start()
    {
        verticalForce = Random.Range(minVerticalForce, maxVerticalForce);
        horizontalForce = Random.Range(minHorizontalForce, maxHorizontalForce);
        Physics.IgnoreLayerCollision(6, 7, true);
    }

    void Update()
    {
        
    }

    public void ShowWholeFruit()
    {
        Destroy(throwingSphere = Instantiate(wholeSphere, transform.position, transform.rotation), 10);
        throwingSphere.GetComponent<Rigidbody>().AddForce(transform.up * verticalForce);
        throwingSphere.GetComponent<Rigidbody>().AddForce(transform.right * horizontalForce * throwDirection);
        //throwDirection *= -1;
    }

    //private void SetThrowingDirection()
    //{
    //    if (Random.value > 0.5f)
    //    {
    //        throwDirection = 1;
    //    }
    //    else
    //    {
    //        throwDirection = -1;
    //    }
    //}
}

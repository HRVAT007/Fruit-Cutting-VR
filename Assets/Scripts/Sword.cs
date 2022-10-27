using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sword : MonoBehaviour
{
    public GameObject lowerHalfBlue;
    public GameObject lowerHalfGreen;
    public GameObject lowerHalfRed;
    public GameObject lowerHalfYellow;
    public GameObject upperHalfBlue;
    public GameObject upperHalfGreen;
    public GameObject upperHalfRed;
    public GameObject upperHalfYellow;
    public ScoreSystem scoreSystem;


    void Start()
    {
        
    }

    
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        string sphereNameHit = collision.gameObject.name.Replace("(Clone)","");

        if (sphereNameHit.Contains("SphereBlue"))
        {
            ShowSlicedSphere(upperHalfBlue, lowerHalfBlue, collision.gameObject);
            scoreSystem.AddScore(1);
            scoreSystem.SubtractHealth(1);

        }    
        if (sphereNameHit.Contains("SphereGreen"))
        {
            ShowSlicedSphere(upperHalfGreen, lowerHalfGreen, collision.gameObject);
            scoreSystem.AddScore(1);
        }
        if (sphereNameHit.Contains("SphereRed"))
        {
            ShowSlicedSphere(upperHalfRed, lowerHalfRed, collision.gameObject);
            scoreSystem.AddScore(1);
        }  
        if (sphereNameHit.Contains("SphereYellow"))
        {
            ShowSlicedSphere(upperHalfYellow, lowerHalfYellow, collision.gameObject);
            scoreSystem.AddScore(1);
        }
            

    }

    private void ShowSlicedSphere(GameObject slicedSphereUpperToShow, GameObject slicedSphereLowerToShow, GameObject wholeSphereToDelete)
    {
        Destroy(Instantiate(slicedSphereUpperToShow, wholeSphereToDelete.transform.position, wholeSphereToDelete.transform.rotation), 60);
        Destroy(Instantiate(slicedSphereLowerToShow, wholeSphereToDelete.transform.position, wholeSphereToDelete.transform.rotation), 60);
        Destroy(wholeSphereToDelete);
    }
}

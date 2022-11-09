using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollisionEvent : MonoBehaviour
{
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Heart"))
        {
        
            GameObject Heartcoin = other.gameObject;
            Destroy(Heartcoin);

            Debug.Log(other.gameObject.tag);
        }      

    }








    void Start()
    {
        
    }


    void Update()
    {
        
    }
}

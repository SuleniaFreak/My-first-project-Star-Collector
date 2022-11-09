using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiamondCollisionEvent : MonoBehaviour
{
    public GameObject YouWinText;
    

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Diamond"))
        {
            GameObject DiamondCoin = other.gameObject;
            Destroy(DiamondCoin);
            YouWinText.SetActive(true);

        }
    }




    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

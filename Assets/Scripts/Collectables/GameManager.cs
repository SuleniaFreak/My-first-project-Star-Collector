using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Actival libreria para poder usar textos de la UI
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI CoinText;
    public GameObject DiamondAppearedText;

    public float timeToDestroy = 2;

    public GameObject Diamond;
    int numCoins;

    //método que será llamado desde el script "starCollisionEvent"
    //cuando el jugador obtenga una estrella

    public void AddCoin()
    {
        numCoins++; //Sumo 1 al contador de la estrella
     
        //Muestra por la interfaz
        CoinText.text = "" + numCoins.ToString();

        ActivateDiamond();
    }


    public void ActivateDiamond()
    {
        if(numCoins == 3)
        { 
            DiamondAppearedText.SetActive(true);
            Destroy(DiamondAppearedText, timeToDestroy);
            Diamond.SetActive(true);
        }
    }
   
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}

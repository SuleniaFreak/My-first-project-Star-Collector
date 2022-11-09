using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollisionEvent : MonoBehaviour
{
    //variable que guardará la info del script game manager*******
    public GameManager gameManagerScript;
    //Versión alternativa: public GameManager gameManager;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Si el objeto contra el que ha colisionado el personaje tiene la etiqueta coin, la destruye
        if (other.CompareTag("Coin"))
        {
            //llama al método AddCoin que se encuentra en el script gameManager
            gameManagerScript.AddCoin();
             //Versión alternativa: gameManager.GetComponent<GameManager>().AddCoin();
            GameObject starCoin = other.gameObject;
            Destroy(starCoin);
        }
        //Muestra los objetos que han colisionado
        Debug.Log(other.gameObject.tag);
    }


    void Update()
    {
        
    }
}

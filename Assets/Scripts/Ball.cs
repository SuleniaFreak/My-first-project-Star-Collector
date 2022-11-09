using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script encargado de gestionar la fuerza de impulso de la bola
/// </summary>

public class Ball : MonoBehaviour
{
    //variables que determinan la fuerza y la direcci�n a la que se mover� la bola
    public float force;
    public Vector3 direction;
    //Variable que elimina los clones de los prefabs de la bola
    public float timeToDestroy = 3;
    //Variable que guarda la info de un material
    public Material mat;

    Rigidbody rb;
    
    void Start()
    {
        //Destruye el objeto clonado despu�s del tiempo almacenado en la variable timeToDestroy
        Destroy(gameObject, timeToDestroy);

        rb = GetComponent<Rigidbody>();
        //A�ade fuerza a la bola
        rb.AddForce(direction * force);
    }

    //m�todo que usa el contacto de colisiones para cambiar 
    private void OnCollisionEnter(Collision collision)
    {
        //Si la etiqueta del gameobject con el que choca la bola es "Coin"
        if (collision.collider.CompareTag("Coin"))
        {
            //guardo en una variable local el gameobject con el que estoy chocando
            GameObject StarCoin = collision.gameObject;

            StarCoin.GetComponent<MeshRenderer>().material = mat;
            //Destruye el gameobject contra el que ha chocado la bola
            Destroy(collision.gameObject);
        }
    }

    //Alternativa al m�todo anterior utilizando la funci�n trigger
    //Los gameObjects tienen que tener la opci�n "is trigger" activada para que funcione
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            //guardo en una variable local el gameobject con el que estoy chocando
            GameObject StarCoin = other.gameObject;
            //cambia el material de un gamObject
            StarCoin.GetComponent<MeshRenderer>().material = mat;

            //Muestra los objetos que han colisionado
            //Debug.Log(other.gameObject.tag);
        }
    }

    void Update()
    {
        
    }
}

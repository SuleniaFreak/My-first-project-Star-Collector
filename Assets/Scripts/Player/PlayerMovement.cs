using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables que recojen la velocidad de movimiento y rotaci�n del personaje
    public int Speed,
               TurnSpeed;
    //variables que recojen la info de los inputs pulsados
    float h, v;

    void Start()
    {
        
    }
    void Update()
    {
        InputPlayer();
        Movement();
        Rotate();
    }


    
    void InputPlayer()
    {//m�todo que recoje info de las teclas AD o flechas izq/der (h), o las teclas WS o las flechas arriba/abajo (v)
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }

    void Movement()
    {//m�todo que activa el movimiento del personaje
        transform.Translate(Vector3.forward * Speed * v * Time.deltaTime);
    }

    void Rotate()
    {//m�todo que activa la rotaci�n del personaje
        transform.Rotate(Vector3.up * TurnSpeed * h * Time.deltaTime);
    }
}

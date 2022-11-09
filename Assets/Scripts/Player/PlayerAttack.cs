using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    //Referencia al prefab de la bola
    //El que está en la carpeta Assets (NUNCA INCLUIR AQUI UN OBJETO QUE SE ENCUENTRE EN LA ESCENA!!)
    public GameObject Ball;

    //Posición de salida del prefab "Ball"
    public Transform PosBall;

    //Variable para aplicar un delay en el ataque
    public float timeBetweenAttacks;

    //Variable para un contador de segundos
    float timer;
    void Start()
    {
        
    }
    void Update()
    {
        //Contador de segundos: 0, 1, 2, .......
        timer += Time.deltaTime; //Versión alternativa: timer = timer + Time.deltaTime;
        //Debug.Log("Timer " + timer);

        //Condicional para el disparo de la bola
        if(Input.GetMouseButtonDown(0) && timer >= timeBetweenAttacks)
        {
            CreateBall();
            timer = 0;
        }
    }

    //Método que crea los clones de la bola
    void CreateBall()
    {
        //se crea el clon del prefab y se guarda en una variable local
        GameObject cloneBallPreFab = Instantiate(Ball, PosBall.position, PosBall.rotation);

        cloneBallPreFab.GetComponent<Ball>().direction = transform.forward;
    }
}

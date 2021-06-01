using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploDeArray : MonoBehaviour
{
    private List<string> ballsToPass = new List<string>();
    private int currentBall;
    public GameObject[] balls;
    public GameObject[] passedBalls;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {


            currentBall = Random.Range(0, balls.Length); // basically generates a random number from the length of the balls array, to be used as an index

            GameObject ball = Instantiate(balls[currentBall]) as GameObject;  // "as gameobjects" is type casting the instance to a gameobject. 
            if (ball.name != "Red(Clone)") {

                ballsToPass.Add(ball.name); //adds element name to list
                Debug.Log(ball.name); // logs name
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            for (int i = 0; i < ballsToPass.Count; i++)  //logs the list in console

                Debug.Log(ballsToPass[i]);
        }
    }
}

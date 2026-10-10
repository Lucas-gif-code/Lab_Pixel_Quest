using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.XR;

using UnityEngine.SceneManagement;



public class Geocontroller : MonoBehaviour
{
    // Start is called before the first frame update
    string Var2 = "Hello ";
    int VarNumber = 2;

    private Rigidbody2D rb;


    public int speed = 2;









    void Start()
    {

        rb = GetComponent<Rigidbody2D>();



        Debug.Log(Var2 + "World");
        Var2 = "Goodbye";
        Debug.Log(Var2 + "World");


    }

    // Update is called once per frame
    void Update()
    {



        float xInput = Input.GetAxis("Horizontal");



        xInput *= speed;
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);






    }

    public string nextLevel = "Level2";



    private void OnTriggerEnter2D(Collider2D collision)
    {

          
            switch (collision.tag)
            {
         case "Death":
            {
                string thisLevel = SceneManager.GetActiveScene().name;
    SceneManager.LoadScene(nextLevel);
                break;

            }

        case "Finish":
    {
        SceneManager.LoadScene(nextLevel);
        break;






           

    }
}




    }
}











    






    /*

if (Input.GetKeyDown(KeyCode.W))
{
transform.position += new Vector3(0, 7, 0);
}


if (Input.GetKeyDown(KeyCode.S))
{
transform.position += new Vector3(0, -4, 0);
}


if (Input.GetKeyDown(KeyCode.D))
{
transform.position += new Vector3(4, 0, 0);
}


if (Input.GetKeyDown(KeyCode.A))S
{
transform.position += new Vector3(-4, 0, 0);
}

}

*/



    /*


    if (Input.GetKeyDown(KeyCode.A))
    {
        rb.velocity = new Vector2(-2, rb.velocity.y); ;
    }
    if (Input.GetKeyDown(KeyCode.D))
    {
        rb.velocity = new Vector2(2, rb.velocity.y); ;
    }


    */









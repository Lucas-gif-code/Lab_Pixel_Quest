using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoContoller : MonoBehaviour {
    // Start is called before the first frame update
    private Rigidbody2D rb2d;
    void Start() {
        rb2d = GetComponent<Rigidbody2D>(); 
        //Debug.Log(Var2 + "World");
        //Var2 = "Goodbye";
        //Debug.Log(Var2 + "World");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.A)) {
            rb2d.velocity = new Vector2(-1, rb2d.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            rb2d.velocity = new Vector2(1, rb2d.velocity.y);
        }
    }

}

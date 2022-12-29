using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Bird Component Access Via Script
    public Rigidbody2D myRigidbody;
    //Bird Variables
    public float flapStrength;
    public bool birdIsAlive = true;
    //Access the logic script manually
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        //Access the logic script variable manually
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) 
            && birdIsAlive == true) { 
        myRigidbody.velocity = Vector2.up * flapStrength; 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;

    }
}

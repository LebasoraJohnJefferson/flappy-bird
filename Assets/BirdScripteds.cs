using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScripteds : MonoBehaviour
{   
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool IsBirdAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();
        gameObject.name = "Lebs Bird";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsBirdAlive){
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        logic.GameOver();
        IsBirdAlive = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float moveScale;
    public float jumpScale;
    bool grounded;
    // Use this for initialization
    void Start () {
        grounded = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A)) { transform.Translate(Vector2.left * moveScale); transform.localScale = new Vector3(-1, 1, 1); }
        else if (Input.GetKey(KeyCode.D)) { transform.Translate(Vector2.right * moveScale); ; transform.localScale = new Vector3(1, 1, 1);
    }
        if (Input.GetKeyDown(KeyCode.W) && grounded) GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpScale, ForceMode2D.Impulse);
        RaycastHit2D rayToGround = Physics2D.Raycast(transform.position, Vector2.down);
        if (rayToGround.collider != null)
        {
            if (rayToGround.distance < 0.53) grounded = true; else grounded = false; 
        }
        Debug.Log(Mathf.Abs(rayToGround.distance) + ";" + grounded);
    }
}

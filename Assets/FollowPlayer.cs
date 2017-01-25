using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;
    public Vector3 min;
    public Vector3 max;
    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
        min = transform.position;
        max = new Vector3(18, 0, -10);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + offset;
        if (transform.position.x < min.x) transform.position = min;
        if (transform.position.x > max.x) transform.position = max;
        transform.position -= new Vector3(0, transform.position.y, 0);
    }
}

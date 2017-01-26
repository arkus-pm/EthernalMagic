using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public GameObject player;
    public GameObject maxPosition;
    private Vector3 offset;
    public Vector3 min;
    public Vector3 max;
    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
        min = transform.position;
        max = maxPosition.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + offset;
        if (transform.position.x < min.x) transform.position = min;
        if (transform.position.x > max.x) transform.position = max;
        transform.position -= new Vector3(0, transform.position.y, 0);
    }
}

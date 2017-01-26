using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D o) {
        if (o.gameObject.name == "Player") transform.GetChild(0).gameObject.SetActive(true);
        Debug.Log(o.gameObject.name);
       
    }
    void OnTriggerExit2D(Collider2D o) {
        if (o.gameObject.name == "Player") transform.GetChild(0).gameObject.SetActive(false);
    }
}

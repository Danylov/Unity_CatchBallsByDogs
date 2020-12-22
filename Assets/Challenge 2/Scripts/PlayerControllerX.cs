using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float lTimePress = 0.0f; 
    public float dTime = 10.0f; // seconds 

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (dTime < (Time.time - lTimePress)))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lTimePress = Time.time;
        }
    }
}

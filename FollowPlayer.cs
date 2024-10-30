using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
   
    private GameObject player; // Odniesienie do obiektu gracza
    private float moveSpeed = 2.5f; // Prędkość poruszania się wroga
    
    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.Find("Player");
   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 kierunek = (player.transform.position - transform.position).normalized;
        transform.Translate(kierunek * moveSpeed * Time.deltaTime);
    }
}

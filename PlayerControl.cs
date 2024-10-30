using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 5.0f;
    private float fireballSpeed = 15.0f;
    public GameObject kulaOgnia;
    private Vector3 lastMoveDirection;
    void Start()
    {
        lastMoveDirection =Vector3.down;
    }

    // Update is called once per frame
    void Update()
    {
        
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * speed * vertical);

        float horizontal = Input.GetAxis("Horizontal");
         transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal);

        Vector3 moveDirection = new Vector3(horizontal, vertical, 0).normalized;
        if (moveDirection != Vector3.zero)
        {
            lastMoveDirection = moveDirection;
        }
        if(Input.GetKeyDown(KeyCode.Space))
            {
                GameObject fireball = Instantiate(kulaOgnia, transform.position, Quaternion.identity);
                KulaOgnia fireballMovement = fireball.GetComponent<KulaOgnia>();

              if (fireballMovement != null)
            {
                fireballMovement.speed = fireballSpeed;
                fireballMovement.SetDirection(lastMoveDirection); // Ustawiamy kierunek kuli ognia
            }
            
            
            
            }

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KulaOgnia : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
     private Vector3 direction;
    void Start()
    {
        
    }
   

    public void SetDirection(Vector3 dir)
    {
        direction = dir.normalized; // Normalizujemy, aby kierunek miał długość 1
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(direction * Time.deltaTime * speed); 

       if(transform.position.x>9 || transform.position.x<-9 || transform.position.y<-9 || transform.position.y>9)
       {
        Destroy(gameObject);
       }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour {


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        if ((((transform.position.x > 17) || (transform.position.x < -17)) || ((transform.position.y > 9) || (transform.position.y < -9))) && (transform.position.x!=100) && (transform.position.y!=100))
        {
            Destroy(gameObject);
        }
    }
}

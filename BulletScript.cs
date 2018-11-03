using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if ((((transform.position.x > 17) || (transform.position.x < -17)) || ((transform.position.y > 9) || (transform.position.y < -9))) && (transform.position.x != -100) && (transform.position.y != -100))
        {
            Destroy(gameObject);
        }
    }
}

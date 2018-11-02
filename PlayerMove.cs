
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    private Rigidbody2D rb;
    public float speed = 20f;
    public float speedr = 2f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.rotation = Quaternion.Euler(0, 0, transform.eulerAngles.z + speedr);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.rotation = Quaternion.Euler(0, 0, transform.eulerAngles.z - speedr);
            
        }
        //print(transform.eulerAngles.z);
        rb.velocity = new Vector2(Mathf.Sin(Mathf.Deg2Rad * transform.eulerAngles.z) * -speed, Mathf.Cos(Mathf.Deg2Rad * transform.eulerAngles.z) * speed);
	}
}


using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb;
    public float speed = 20f;
    public float speedr = 2f;
    public GameObject bullet;
    private Rigidbody2D rb_bullet;
    public float speed_bullet = 10f;

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
         GameObject bullet_n=Instantiate(bullet, new Vector3(transform.position.x + -Mathf.Sin(Mathf.Deg2Rad * transform.eulerAngles.z), transform.position.y + Mathf.Cos(Mathf.Deg2Rad * transform.eulerAngles.z), 0), Quaternion.Euler(0,0, transform.eulerAngles.z+90f));
         rb_bullet = bullet_n.GetComponent<Rigidbody2D>();
         rb_bullet.velocity = new Vector2(Mathf.Sin(Mathf.Deg2Rad * transform.eulerAngles.z) * -speed_bullet, Mathf.Cos(Mathf.Deg2Rad * transform.eulerAngles.z) * speed_bullet);
        }
	}
}

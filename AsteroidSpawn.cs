using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour {

    public GameObject aster;
    public float x;
    public float y;
    public int p;
    private Rigidbody2D bullet_rb;

	void Start () {
        StartCoroutine(spawn());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator spawn()
    {
        while (true)
        {
            p = Random.Range(1, 4);
            switch (p)
            {
                case 1:
                    y = 8.9F;
                    x = Random.Range(-16.9F, 16.9F);
                    break;
                case 2:
                    y = -8.9F;
                    x = Random.Range(-16.9F, 16.9F);
                    break;
                case 3:
                    x = 16.9F;
                    y = Random.Range(-8.9F, 8.9F);
                    break;
                case 4:
                    x = -16.9F;
                    y = Random.Range(-8.9F, 8.9F);
                    break;
            }
            
            GameObject bullet = Instantiate(aster, new Vector2(x, y), Quaternion.Euler(0,0,Random.Range(0,360)));
            bullet_rb = bullet.GetComponent<Rigidbody2D>();
            switch (p)
            {
                case 1:
                    bullet_rb.velocity = new Vector2(Random.Range(0F, 1F), -Random.Range(0.2F, 1F));
                    break;
                case 2:
                    bullet_rb.velocity = new Vector2(Random.Range(0F, 1F), Random.Range(0.2F, 1F));
                    break;
                case 3:
                    bullet_rb.velocity = new Vector2(-Random.Range(0.2F, 1F), Random.Range(0F, 1F));
                    break;
                case 4:
                    bullet_rb.velocity = new Vector2(Random.Range(0.2F, 1F), Random.Range(0F, 1F));
                    break;
            }
            yield return new WaitForSeconds(3);
        }
    }

}

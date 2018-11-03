using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour {

    public GameObject aster;

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
            Instantiate(aster, new Vector2(Random.Range(-16, 16), Random.Range(-8, 8)), Quaternion.Euler(0,0,Random.Range(0,360)));
            yield return new WaitForSeconds(3);
        }
    }

}

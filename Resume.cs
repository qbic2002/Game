using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour {

    public PlayerController pl;
    public GameObject resume;
    public GameObject pause;

    private void OnMouseDown()
    {
        Time.timeScale = 1;
        pl.pause = false;
        pause.SetActive(true);
        resume.SetActive(false);
    }
    // Use this for initialization
    void Start () {
        resume.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using UnityEngine;

public class Pause : MonoBehaviour {

    public PlayerController pl;
    public GameObject resume;
    public GameObject pause;

    private void OnMouseDown()
    {
        Time.timeScale = 0;
        pl.pause = true;
        resume.SetActive(true);
        pause.SetActive(false);
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

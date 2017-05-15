using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	public Sprite[] hitSprites;

	private int timesHit;
	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
		timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D collision){
		timesHit++;
		if (timesHit >= maxHits) {
			Destroy (gameObject);
		}
	}
	// TODO Remove this method once we can actually win!

	void SimulateWin ()
	{
		levelManager.LoadNextLevel ();
	}
}

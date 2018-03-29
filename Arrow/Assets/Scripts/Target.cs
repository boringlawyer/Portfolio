using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Caleb Katzenstein
// Arrow
// The object being hit by the player
public class Target : MonoBehaviour 
{
	// where will this come from?
	enum LaunchSide {Top, Bottom, Left, Right};
	LaunchSide launch;
	Rigidbody2D rb;
	[SerializeField] float speed;
	// Use this for initialization
	void Start () 
	{
		// initialize launch to a random entry
		launch = (LaunchSide)Random.Range(0, 4);
		rb = GetComponent<Rigidbody2D>();
		float xTrajectory = 0;
		float yTrajectory = 0;
		float xPos = 0;
		float yPos = 0;
		// determines launch trajectory based on launch
		switch (launch)
		{
			case LaunchSide.Top:
				xTrajectory = Random.Range(-1f, 2f);
				yTrajectory = -1;
				xPos = Random.Range(4f, 8f);
				yPos = 5;
				break;
			case LaunchSide.Bottom:
				xTrajectory = Random.Range(-1f, 2f);
				yTrajectory = 1;
				xPos = Random.Range(4f, 8f);
				yPos = -5;
				break;
			case LaunchSide.Left:
				xTrajectory = 1;
				yTrajectory = Random.Range(-1f, 2f);
				xPos = -13;
				yPos = Random.Range(5/3, 10/3);
				break;
			case LaunchSide.Right:
				xTrajectory = -1;
				yTrajectory = Random.Range(-1f, 2f);
				xPos = 13;
				yPos = Random.Range(5/3, 10/3);
				break;	
		}
		transform.position = new Vector3(xPos, yPos, 0);
		rb.velocity = new Vector2(xTrajectory, yTrajectory).normalized * 5;
	}
	// this gets destroyed if arrow hits this, but not if the arrow has not launched yet
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Arrow") && other.GetComponent<Rigidbody2D>().velocity != Vector2.zero)
		{
			Destroy(gameObject);
		}
	}
}

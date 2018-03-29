using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour
{
    float currentAngle;
    Rigidbody2D rb;
    public float speed = 10f;
    // Use this for initialization
    void Start ()
    {
        Input.gyro.enabled = true;
        currentAngle = 0f;
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Rotate the world based on input
	void Update ()
    {
        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer)
        {
            if (Input.GetKey(KeyCode.A))
            {
                currentAngle += speed * Time.deltaTime;
                transform.rotation = Quaternion.AngleAxis(currentAngle, Vector3.forward);
            }
            if (Input.GetKey(KeyCode.D))
            {
                currentAngle -= speed * Time.deltaTime;
                transform.rotation = Quaternion.AngleAxis(currentAngle, Vector3.forward);
            }
        }
        print(Input.gyro.attitude.eulerAngles.z);
        transform.rotation = Quaternion.Euler(0, 0, (Input.gyro.attitude.eulerAngles.z + 90) * 1f);
    }
}

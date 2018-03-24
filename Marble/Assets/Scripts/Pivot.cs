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
	
	// Update is called once per frame
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
        //if (Application.platform == RuntimePlatform.Android)
        //{
            /*float rotAngle = Input.gyro.attitude.eulerAngles.z;
            Quaternion rotQuat = new Quaternion();
            rotQuat.eulerAngles = new Vector3(0, 0, rotAngle);
            transform.rotation = rotQuat;
            print(rotAngle);*/
            //transform.rotation = Input.gyro.attitude;
        //}
        print(Input.gyro.attitude.eulerAngles.z);
        transform.rotation = Quaternion.Euler(0, 0, (Input.gyro.attitude.eulerAngles.z + 90) * 1f);
        //rb.AddTorque(60, ForceMode2D.Impulse);
    }
}

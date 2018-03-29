using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marble : MonoBehaviour
{
    bool isFrozen = true;
    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (isFrozen)
                {
                    isFrozen = false;
                }
                else if (!isFrozen)
                {
                    isFrozen = true;
                }
            }
        }
        else if (Application.platform == RuntimePlatform.Android)
        {
            Input.gyro.enabled = true;
            if (Input.touchCount > 0)
            {
                while (Input.touchCount > 0)
                {
                    // hold in loop until touch is released
                }
                if (isFrozen)
                {
                    isFrozen = false;
                }
                else if (!isFrozen)
                {
                    isFrozen = true;
                }
            }
        }
        if (isFrozen)
        {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
        else
        {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
    // if this touches a wall, unfreeze it
    public void OnCollisionEnter2D(Collision2D collision)
    {
        isFrozen = false;
    }
}

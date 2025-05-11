using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public float speed = 5f;
    public float leftLimit = -3f;
    public float rightLimit = 3f;

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float newX = Mathf.Clamp(transform.position.x + move, leftLimit, rightLimit);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}

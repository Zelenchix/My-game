using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneMovement : MonoBehaviour
{
    private float moveSpeed = 5f;
    private float moveHorizontal = 3f;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"OnTrigerEnter {other.gameObject.tag}");
        if (other.gameObject.CompareTag("Left Block"))
        {
            moveHorizontal = Math.Abs(moveHorizontal);
        }
        else if (other.gameObject.CompareTag("Right Block"))
        {
            moveHorizontal = -Math.Abs(moveHorizontal);
        }
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveHorizontal, 0f, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
        Debug.Log($"FixedUpdate {movement}");
    }
}
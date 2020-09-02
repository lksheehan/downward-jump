using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    public float speed;

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("moving!");
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}

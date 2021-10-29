using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StainClean : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            transform.position = collision.transform.position;
            transform.SetParent(collision.transform);
            Destroy(this.transform.gameObject,1.5f);
        }
    }
}

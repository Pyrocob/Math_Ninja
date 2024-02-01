using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy")&& Input.GetKey(KeyCode.Mouse0))
        {
            Destroy(other.gameObject);
        }
    }
}

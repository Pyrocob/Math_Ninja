using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    [SerializeField] GameObject BackstabUI;
    private Collider other;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy")&& Input.GetKey(KeyCode.Mouse0))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("enemy"))
        {
            BackstabUI.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] GameObject SpottedUI;
    private Collider other;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SpottedUI.SetActive(true);
        }
    }
}

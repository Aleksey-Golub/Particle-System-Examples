using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Fireable>())
        {
            other.GetComponent<Fireable>().OnEnter();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Fireable>())
        {
            other.GetComponent<Fireable>().OnExit();
        }
    }
}

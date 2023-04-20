using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyObject : MonoBehaviour
{
    [Header("Events")]
    public GameEvent onObjectAcquired;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            onObjectAcquired.Raise(this, null);
            Destroy(gameObject);
        }
    }
}

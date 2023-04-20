using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class LockedDoorTrigger : MonoBehaviour
{
    [Header("Events")]
    public GameEvent onDoorUnlocked;

    public Collider thisCollider;

    void Start()
    {
        thisCollider.enabled = false;
    }

    public void ActivateTrigger()
    {
        thisCollider.enabled = !thisCollider.enabled;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            onDoorUnlocked.Raise(this, null);
        }
    }
}

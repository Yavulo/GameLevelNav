using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    public GameObject objectToMove;

    public bool flowerKeyLock;
    public bool windmillKeyLock;
    public bool docksKeyLock;
    public bool anomalyKeyLock;

    public GameObject flowerKey;
    public GameObject windmillKey;
    public GameObject docksKey;
    public GameObject anomalyKey;

    public AudioSource doorSFX;

    void tryOpen()
    {
        if (flowerKeyLock && windmillKeyLock && docksKeyLock && anomalyKeyLock)
        {
            objectToMove.GetComponent<Animator>().SetTrigger("openTheDoor");
            flowerKey.GetComponent<Animator>().SetTrigger("spin");
            windmillKey.GetComponent<Animator>().SetTrigger("spin");
            docksKey.GetComponent<Animator>().SetTrigger("spin");
            anomalyKey.GetComponent<Animator>().SetTrigger("spin");
            doorSFX.Play ();
        }
    }
}

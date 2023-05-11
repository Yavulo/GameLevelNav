using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class lockAndKey : MonoBehaviour
{
    public GameObject staticKey;
    public GameObject door;
    public GameObject moveyKey;
    public GameObject player;

    [Header("Audio")]
    public AudioClip itemPickup;
    public GameObject keyLocation;

    [Header("Key Type")]
    public bool flowerKey;
    public bool windmillKey;
    public bool docksKey;
    public bool anomalyKey;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("collision detected lmao");
        if (collider.gameObject == moveyKey)
        {
            Debug.Log("AYO THAT'S A KEY DAWG");
            moveyKey.gameObject.SendMessage("despawn");
            player.gameObject.SendMessage("DropObject");
            staticKey.GetComponent<MeshRenderer>().enabled = true;
            AudioSource.PlayClipAtPoint(itemPickup, keyLocation.transform.position, 1.0f);
            if (flowerKey)
            {
                door.GetComponent<openDoor>().flowerKeyLock = true;
                door.gameObject.SendMessage("tryOpen");
            }
            else if (windmillKey)
            {
                door.GetComponent<openDoor>().windmillKeyLock = true;
                door.gameObject.SendMessage("tryOpen");
            }
            else if (docksKey)
            {
                door.GetComponent<openDoor>().docksKeyLock = true;
                door.gameObject.SendMessage("tryOpen");
            }
            else if (anomalyKey)
            {
                door.GetComponent<openDoor>().anomalyKeyLock = true;
                door.gameObject.SendMessage("tryOpen");
            }
        }
    }
}

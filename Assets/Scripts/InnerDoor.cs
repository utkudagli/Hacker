using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerDoor : MonoBehaviour
{
    public GameObject Door;

    public void RemoveDoor()
    {
        Door.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDoor : MonoBehaviour
{
    public GameObject Door;

    public void RemoveDoor()
    {
        Door.SetActive(false);
    }
}

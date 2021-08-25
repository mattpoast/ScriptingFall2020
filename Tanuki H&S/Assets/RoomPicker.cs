using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomPicker : MonoBehaviour
{
    public GameObject[] roomsToPickFrom;

    // Start is called before the first frame update
    void Start()
    {
        Pick();
    }

    void Pick()
    {
        int randomIndex = Random.Range(0, roomsToPickFrom.Length);
        GameObject clone = Instantiate(roomsToPickFrom[randomIndex], transform.position, transform.rotation);
    }
}

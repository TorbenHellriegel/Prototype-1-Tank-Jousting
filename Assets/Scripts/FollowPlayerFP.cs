using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerFP : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, 0);

    // Update is called once per frame
    void LateUpdate()
    {
        // Position camera slightly above the car for a first person perspective
        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation;
    }
}

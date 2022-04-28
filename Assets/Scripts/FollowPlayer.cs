using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offsetPlayer1 = new Vector3(0, 7, -10);
    private Vector3 offsetPlayer2 = new Vector3(0, 7, 10);

    // Update is called once per frame
    void LateUpdate()
    {
        // Position camera behind the car using the correct offset
        if(player.name == "Player_Car")
        {
            transform.position = player.transform.position + offsetPlayer1;
        }
        else if(player.name == "Player_Car_2")
        {
            transform.position = player.transform.position + offsetPlayer2;
        }
    }
}

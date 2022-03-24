using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Name:Evan Egan : Script:FollowPlayer
    //Description : Camera Follows the Player (a car)

    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -10);

    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}

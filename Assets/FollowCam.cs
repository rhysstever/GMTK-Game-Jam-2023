using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [SerializeField]
    public Transform player;

    [SerializeField]
    public Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, transform.position.y, offset.z); // Camera follows the player with specified offset position
    }
}

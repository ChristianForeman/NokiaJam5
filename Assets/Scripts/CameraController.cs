using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player_transform;
    public float camera_y_offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,
                                         player_transform.position.y + camera_y_offset,
                                         transform.position.z);
    }
}

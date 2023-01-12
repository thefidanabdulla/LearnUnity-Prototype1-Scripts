using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    // main vehicles player
    public GameObject player;

    // offsets of camera positions
    private Vector3 offset = new Vector3(0, 5, -7);
    private Vector3 offset2 = new Vector3(0, 2, 1);

    // camera switch position value
    private bool switchPosition = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            switchPosition = !switchPosition;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (switchPosition)
        {
            transform.position = player.transform.position + offset2;
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}

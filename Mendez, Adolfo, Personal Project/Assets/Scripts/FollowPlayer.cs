using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPLayer : MonoBehaviour
{
    public GameObject player;

    public Vector3 offset = new Vector3(1, 4, -6);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        //add vector to create camera offset
        transform.position = player.transform.position + offset;
    }
}

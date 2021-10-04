using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target;
    [SerializeField]
    private Vector3 offsetPosistion;

    // Start is called before the first frame update
    void Awake()
    {

        target = GameObject.FindGameObjectWithTag(Tags.PLAYER_TAG).transform;
    }

    void LateUpdate()
    {
        FollowPlayer();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        
    }
    void FollowPlayer()
    {
        transform.position = target.TransformPoint(offsetPosistion);

        transform.rotation = target.rotation;
    }
}

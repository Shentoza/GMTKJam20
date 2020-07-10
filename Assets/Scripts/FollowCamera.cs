using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject FollowingGameObject;

    private Rigidbody2D FollowRigid;

    private Vector2 Velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        Velocity = Vector2.zero;
        if (FollowingGameObject)
        {
            FollowRigid = FollowingGameObject.GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y) +
                             (FollowRigid.velocity * Time.deltaTime);
    }
}

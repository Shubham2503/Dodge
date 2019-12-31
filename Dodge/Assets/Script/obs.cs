using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obs : MonoBehaviour {

    public Rigidbody rb;
    public GameObject Effect;
    public GameObject Effect2;
    private object collisionInfo;

    public int health;

    void Start()
    {

    }


    void FixedUpdate()
    {
 

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            Instantiate(Effect2, transform.position, Quaternion.identity);
            FindObjectOfType<AudioManager>().Play("PHit");
            Destroy(gameObject);

        }
        if (collisionInfo.collider.tag == "Ground")
        {
            Instantiate(Effect, transform.position, Quaternion.identity);
            FindObjectOfType<AudioManager>().Play("GHit");
            Destroy(gameObject);
        }
    }
}

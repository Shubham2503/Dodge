using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMov : MonoBehaviour
{
    private Vector3 offset;

    public GameObject player;
    public GameObject center;


    public GameObject left;
    public GameObject right;

    public int step = 9;
    public float speed = 0.01f;
    bool input = true;

    private int health = 3;



    private object collisionInfo;

    void Start ()
    {
		
	}
	
	
	void Update ()
    {
		if(input == true)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                StartCoroutine("moveLeft");
                input = false;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                StartCoroutine("moveRight");
                input = false;
            }
        }

        PlayerPrefs.SetInt("Health", health);


    }

    IEnumerator moveLeft()
    {
        for (int i = 0; i < (int)(90 / step); i++)
        {
            player.transform.RotateAround(left.transform.position, Vector3.forward,step);
            yield return new WaitForSeconds(speed);
        }
        center.transform.position = player.transform.position;
        input = true;
    }
    IEnumerator moveRight()
    {
        for (int i = 0; i < (100 / step); i++)
        {
            player.transform.RotateAround(right.transform.position, Vector3.back, step);
            yield return new WaitForSeconds(speed);
        }
        center.transform.position = player.transform.position;
        input = true;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obs")
        {
            health--;
        }
        if (collisionInfo.collider.tag == "Bound")
        {
            
        }
    }


}

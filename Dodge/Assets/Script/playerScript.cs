using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {

    public playerMov movement;
   

    void Update()
    {
        if(PlayerPrefs.GetInt("Health") == 0)
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

	
}

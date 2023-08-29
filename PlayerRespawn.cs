using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    public DeathScreen deathScreen;
    public float threshold;
    public bool PlayerIsDead = false; 
    void FixedUpdate()
    {
        if (transform.position.y < threshold) 
        {
            SceneManager.LoadScene(2);
            PlayerIsDead = true;
            transform.position =new Vector2(-3.09f,10.99f);
        }
    }
}

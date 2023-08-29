using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public bool PlayerIsDead = false; 
    void Update()
    {
      if (PlayerIsDead)
      {
            SceneManager.LoadScene(2);
      }     
    }
  public void restart()
  {
      SceneManager.LoadScene(1);
      PlayerIsDead = false;
  }
  public void main_menu()
  {
    SceneManager.LoadScene(0);
    PlayerIsDead = false;
  }
}

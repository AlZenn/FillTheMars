using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public Rigidbody2D RP_Ball;
    public Sprite ballblue;

    public GameObject effectmor, effectblue, effectplayer, panelgameover, effectdeath;
    public GameObject[] health;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (other.gameObject.GetComponent<SpriteRenderer>().sprite.name == "stgpics_basic_236")
            {
                other.gameObject.GetComponent<SpriteRenderer>().sprite = ballblue;
                Instantiate(effectmor, other.contacts[0].point, Quaternion.identity);
            }
            else
            {
                Destroy(other.gameObject);
                Instantiate(effectblue, other.contacts[0].point, Quaternion.identity);
            }
            
            
        }

        if (other.gameObject.name == "Player")
        {
            Instantiate(effectplayer, other.contacts[0].point, Quaternion.identity);
        }


        if (other.gameObject.tag == "Finish")
        {
            for (int i = 0; i < health.Length; i++)
            {
                if (health[i].activeInHierarchy == true)
                {
                    health[i].SetActive(false);
                    break;
                }
                
            }

            if (health[0].activeInHierarchy == false && health[1].activeInHierarchy == false && health[2].activeInHierarchy == false )
            {
                panelgameover.SetActive(true);
                Time.timeScale = 0f;
            }
            this.gameObject.transform.position = Vector3.zero;
            this.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Instantiate(effectdeath, other.contacts[0].point, Quaternion.identity);

        }
    }

    public void gameRestart()
    {

        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerdamage : MonoBehaviour
{
    public Slider playerHealth ;
    public GameObject Dead_panel ;
    float health = 10;

    void Start()
    {
        Dead_panel.gameObject.SetActive(false);
    }
    void Update()
    {
        playerHealth.value = health;
        if (health <= 0)
        {
         health = 0;
            Dead_panel.gameObject.SetActive(true);
         Destroy(gameObject);
        }
        }
     private void OnCollisionEnter(Collision co)
    {
        if (co.gameObject.tag == "COP")
        {
            health -= 5;
        }
    }
}

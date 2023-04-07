using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    int timesHit=0;
    bool hit = false;
    float time = .05f;
    int MaxnumOfEnemies = 10;
    int currNumOfEnemies = 0;
    float xForce;
    float yForce;
    Color color;
    GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        color = GetComponent<Renderer>().material.color;
        
    }

    // Update is called once per frame
    void Update()
    {  
   
        if (hit)
        {
            time-= Time.deltaTime;
            GetComponent<Renderer>().material.color = Color.red;
            
        }
        if (time <= 0)
        {
            time = .05f;
            hit = false;
            GetComponent<Renderer>().material.color = color;
        }

        
        if (timesHit==3)
        {
            Die();
        }

    }
    private void FixedUpdate()
    {
        xForce = (int)Random.Range(-500, 500);
        yForce = (int)Random.Range(-500, 500);
        gameObject.GetComponent<Rigidbody>().AddForce(Random.value, 0f, Random.value);
    }

    private void Die()
    {
        gameController.AddScore(1);//1 per enemy subatomic particle
        Destroy(this.gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Projectile"))
        {
            hit = true;
            ++timesHit;
        }
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float life = 3;
    // Start is called before the first frame update
   void Awake()
    {
        Destroy(gameObject, life);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
     Destroy(gameObject);
    }
    */
}

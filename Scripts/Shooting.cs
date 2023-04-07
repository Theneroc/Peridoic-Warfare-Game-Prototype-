using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shooting : MonoBehaviour
{
    
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public AudioSource source;
    

    // Start is called before the first frame update
    void Start()
    {
        source.volume = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            source.volume = .5f;
            source.Play();
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position,Quaternion.identity);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
        
       
    }
 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    float speed = 5.0f;
    float rotationspeed = 80.0f;
    public Rigidbody playerRb;

    public GameObject bulletPrefab;
    public GameObject bulletSpawn;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;

            // transform.Translate(Vector3.forward * Time.deltaTime * speed);
            //transform.rotation = Quaternion.Euler(0, 0, 0);
            //transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, Time.deltaTime * -speed);

            // transform.Translate(Vector3.forward * Time.deltaTime * speed);
            //transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * -rotationspeed, 0));

            //transform.Translate(Vector3.forward * Time.deltaTime * speed);
             //transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector3.forward * Time.deltaTime * speed);
            //transform.rotation = Quaternion.Euler(0, 90, 0);
            transform.Rotate(new Vector3(0, Time.deltaTime * rotationspeed, 0));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, bulletSpawn.transform.position, transform.rotation);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // hack =X //
        if (rb.IsSleeping())
            rb.WakeUp();
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "Bullet")
       {
            Destroy(gameObject);
            Destroy(collision.gameObject);
       }
    }
}

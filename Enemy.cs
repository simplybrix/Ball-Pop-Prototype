using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform player;
    private float dist;
    public float moveSpeed;
    public float lookRadius = 300f;
    private Collision col;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        dist = Vector3.Distance(player.position, transform.position);


        // If inside the radius
        if (dist <= lookRadius)
        {
            // Move towards the player
            GetComponent<Rigidbody>().AddForce(transform.forward * moveSpeed);
           // Attack
            FaceTarget();
            OnCollisionEnter(col);
        }
    }

    // Point towards the player
    void FaceTarget()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.player == "Player")
        {
            Debug.Log("Player has died.");
            Destroy(player);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}

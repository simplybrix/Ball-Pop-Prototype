using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScore : MonoBehaviour
{
    [SerializeField] int pointValue;
    [SerializeField] ScoreManager scoreManager;
    

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("Score Manager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           scoreManager.score = scoreManager.score + pointValue;
           gameObject.SetActive(false);
           Destroy(gameObject);
        }
    }

   /* void OnCollisonEnter(Collision collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("This is working");
        }
    } */
}

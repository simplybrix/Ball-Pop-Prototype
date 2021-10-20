using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    ObjectPooler objectPooler;

    //
    void FixedUpdate()
    {
 
        ObjectPooler.Instance.SpawnFromPool("Sphere", transform.position, Quaternion.identity);
    }
}

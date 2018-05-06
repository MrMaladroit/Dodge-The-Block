using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private float blockGravityIncreaseRate = 20f;

    private void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / blockGravityIncreaseRate;
    }

    private void Update()
    {
        if(transform.position.y < -2f)
        {
            Destroy(this.gameObject);
        }
    }
}
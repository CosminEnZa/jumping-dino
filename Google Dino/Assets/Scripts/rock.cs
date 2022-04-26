using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    public float rock_speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            transform.position -= new Vector3(rock_speed * Time.deltaTime, 0, 0);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Rock" || collision.gameObject.tag == "Destroy")
        {
            Destroy(gameObject);
            
        }
    }
    }

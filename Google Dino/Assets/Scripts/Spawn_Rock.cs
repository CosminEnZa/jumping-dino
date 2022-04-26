using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Rock : MonoBehaviour
{
    public GameObject Spawn;
    public GameObject Rock;
    public GameObject RockMini;
    public GameObject Bush;
    public GameObject Fly;
    public float rockmini_spawn_time;
    public float rock_spawn_time;
    public float bush_spawn_time;
    public float fly_spawn_time;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("rockmini", 1, rockmini_spawn_time);
        InvokeRepeating("rock", 1, rock_spawn_time);
        InvokeRepeating("bush", 1, bush_spawn_time);
        
    }
    
    void rockmini()
    {
        Spawn = Instantiate(RockMini, transform.position, Quaternion.identity) as GameObject;
    }

    void rock()
    {
        Spawn = Instantiate(Rock, transform.position, Quaternion.identity) as GameObject;
    }

    void bush()
    {
        Spawn = Instantiate(Bush, transform.position, Quaternion.identity) as GameObject;
    }
}

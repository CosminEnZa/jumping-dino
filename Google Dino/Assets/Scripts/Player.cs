using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Animator anim;
    public GameObject destroy_first;
    public bool ground_touch;
    public static bool Start_Game;
    public GameObject Start_But;

    public GameObject ReloadButton;

    public Rigidbody2D rigid;

    public GameObject upArrow;
    

    bool pressed;
    // Start is called before the first frame update
    void Start()
    {
        Start_Game = false;
        ground_touch = true;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if ((pressed || Input.GetKey(KeyCode.UpArrow)) && ground_touch == true && Start_Game == true)
            {
                rigid.velocity = new Vector3(0, 10, 0);
                ground_touch = false;
                anim.SetBool("Jump", true);
            }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            ground_touch = true;
            anim.SetBool("Jump", false);

        }

        if(collision.gameObject.tag == "Rock")
        {
            Score.Over = true;
            ReloadButton.SetActive(true);
            upArrow.SetActive(false);
           
            Time.timeScale = 0;
        }
    }

    public void Start_Button()
    {
        Score.Over = false;
        upArrow.SetActive(true);
       
        Start_Game = true;
        Start_But.SetActive(false);
        Destroy(destroy_first);
    }

    public void PressJump()
    {
        pressed = true;
    }

    public void ReleaseJump()
    { 
        pressed = false;
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Player control system
public class ArrowControl : MonoBehaviour
{
    private float scrollSpeed;

    public Sprite normal_Sprite;
    public Sprite pressed_Sprite;
    public KeyCode key_perm; //Permanent key. Cannot be rebinded
    public KeyCode key_default; //Checks for input on this key first. Can be rebinded

    //Awake is only called once
    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    /*TODO:
     * Make keys change sprite once pressed
    */
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key_default))
        {
            //do stuff
        } else if (Input.GetKeyDown(key_perm))
        {
            //do stuff
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("no");
        if (Input.GetKeyDown(key_default))
        {
            Debug.Log("got?");
            if (collision.gameObject.CompareTag("note"))
            {
                Destroy(collision.gameObject);
                Debug.Log("Note HIT");
            }
        } else if (Input.GetKeyDown(key_perm))
        {
            Debug.Log("got?");
            if (collision.gameObject.CompareTag("note"))
            {
                Destroy(collision.gameObject);
                Debug.Log("Note HIT");
            }
        }
    }
}

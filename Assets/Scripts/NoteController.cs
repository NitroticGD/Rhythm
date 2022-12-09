using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Controls notes individually.
public class NoteController : MonoBehaviour
{
    public ChartSys chartsystem;
    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y >= 6)
        {
            Destroy(gameObject);
            Debug.Log("GONE");
        } else
        {
            transform.position += new Vector3(0f, chartsystem.scrollSpeed * Time.deltaTime, 0f);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Charting system. Controls when notes appear and for which note they appear for.
public class ChartSys : MonoBehaviour
{
    // Start is called before the first frame update
    public Conductor conductor;
    public float scrollSpeed;
    void Awake()
    {
        if (scrollSpeed == 0) {
            scrollSpeed = conductor.songBPM / 60f;
        }
        

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

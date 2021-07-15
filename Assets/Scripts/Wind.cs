using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public GameObject pan;
    public GameObject btn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Tpanel()
    {
        pan.SetActive(true);
        btn.SetActive(false);
        
    }
    
    
       
}
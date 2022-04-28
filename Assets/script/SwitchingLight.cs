using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingLight : MonoBehaviour
{
    public Light light1;
    public Light light2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            light1.enabled = !light1.isActiveAndEnabled;
            light2.enabled =  !light2.isActiveAndEnabled;
            
            
        }
    }
}

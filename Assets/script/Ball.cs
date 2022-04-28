using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    public float s;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
     if(Input.GetKey(KeyCode.B)){
         SceneManager.LoadScene(0);
     }




        if(Input.GetKey(KeyCode.RightArrow)){
             rb.AddForce(new Vector3(1,0,0)*s);
          
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
             rb.AddForce(new Vector3(-1,0,0)*s);
           
                
        }
        if(Input.GetKey(KeyCode.UpArrow)){
             rb.AddForce(new Vector3(0,0,1)*s);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            rb.AddForce(new Vector3(0,0,-1)*s);
        }
       
        
    }
}

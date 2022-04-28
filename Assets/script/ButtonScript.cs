using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene(0);
        }
        
    }

    public void toLighting()
    {
        SceneManager.LoadScene(2);
    }

     public void toProBuilder()
    {
        SceneManager.LoadScene(3);
    }
     public void toCharacterMove()
    {
        SceneManager.LoadScene(1);
    }
    public void toMain(){
        SceneManager.LoadScene(0);
    }
     public void toTerrainDesign(){
        SceneManager.LoadScene(4);
    }

}

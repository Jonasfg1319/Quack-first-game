using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class menu : MonoBehaviour
{
    public Image[] img = new Image[2];
    int selector = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)){
            selector = 1;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            selector = 2;
           
               
            
        }

        select();

        
    }

    void select()
    {


        if (selector == 1)
        {
            img[0].gameObject.SetActive(true);
            img[1].gameObject.SetActive(false);

            if (Input.GetButtonDown("Jump"))
            {
                SceneManager.LoadScene("Level");
            }



        }
        else if (selector == 2)
        {
            img[0].gameObject.SetActive(false);
            img[1].gameObject.SetActive(true);
            if (Input.GetButtonDown("Jump"))
            {
                Application.Quit();
            }
        }
    }
}

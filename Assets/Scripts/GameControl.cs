using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControl : MonoBehaviour
{
    public static int vidas = 3;
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = vidas.ToString();

        if(Player.salvou == true)
        {
            StartCoroutine(ending());
        }
    }


    IEnumerator ending() {

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("End");

    }
}

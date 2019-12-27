using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public GameObject inst;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.morreu == true && GameControl.vidas > 0)
        {
            Instantiate(inst, transform.position, transform.rotation);
            Player.morreu = false;
        }

        if(GameControl.vidas < 1)
        {
            StartCoroutine(rotina());
        }
    }
    IEnumerator rotina()
    {


        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Game Over");

    }

}

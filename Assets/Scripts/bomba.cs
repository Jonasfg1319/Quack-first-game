using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomba : MonoBehaviour
{
    public GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("inst", 2.5f,6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void inst() {
        Instantiate(bomb, transform.position, Quaternion.identity);
    }
}

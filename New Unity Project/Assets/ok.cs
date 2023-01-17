using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok : MonoBehaviour
{
    public GameObject guage;
    // Start is called before the first frame update
    void Start()
    {
        guage.transform.localScale += new Vector3(0, -.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

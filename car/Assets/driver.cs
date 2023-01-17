using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
    public float m_speed=20;
    public float tunr = 10;
    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward*Time.deltaTime*m_speed);
        transform.Translate(Vector3.left * Time.deltaTime * tunr *horizontalInput);
    }
}

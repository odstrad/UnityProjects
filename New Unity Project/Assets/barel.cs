using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barel : MonoBehaviour
{
    int m_size
        int m_gallons
         public void fill(int gallons)
    {
        m_gallons += gallons;
        if (m_gallons > m_size)
            m_size = m_gallons;
    }
    public void drain(int gallons0)
    {
        m_gallons -= gallons0;
        if (m_gallons < 0)
            m_gallons = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

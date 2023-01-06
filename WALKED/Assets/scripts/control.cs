using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class control : MonoBehaviour
{
    private Rigidbody rb;
    public TextMeshProUGUI countText;
    private float movementx;
    private float movementy;
    public int count;   
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setnum();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMove(InputValue movementvalue)
    {
        Vector2 movementvector = movementvalue.Get<Vector2>();
        movementx=movementvector.x;
        movementy=movementvector.y;
    }
    void setnum()
    {
        countText.text = "count; " + count.ToString();
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementx, 0.0f, movementy);
        rb.AddForce(movement * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pichnkm,"))
        {
            other.gameObject.SetActive(false);
            count=count+1;
            setnum();
        }
    }
}

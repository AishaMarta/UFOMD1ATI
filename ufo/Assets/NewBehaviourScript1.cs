using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    float horizontal;
    float vertical;
    public float speed = 5.0f;
    [SerializeField] private Rigidbody2D rb;
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
       vertical = Input.GetAxis("Vertical");


    void FixedUpdate()
    {
            rb.velocity = new Vector2(horizontal * speed, vertical * speed);
        
    }

}

    }

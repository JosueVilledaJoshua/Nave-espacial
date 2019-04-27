using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public GameObject laserPrefab;

  
    public GameObject gameOver;
   

    public float life = 5f;
    public SpriteRenderer spr;

    [SerializeField]
    public float speed = 5.0f;


   
    void Start()
    {
        transform.position = new Vector3(-7, 0, 0);
    }




    void Update()
    {




        Movement();

        //laser movement
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPrefab, transform.position + new Vector3(0.60f, 0, 0), Quaternion.identity);

        }


    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.down * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.right * speed * verticalInput * Time.deltaTime);
    }


    void OnTriggerEnter2D()
    {
        life--;
        ChangeColor();
    }

    void ChangeColor()
    {
        spr = GetComponent<SpriteRenderer>();
        spr.color = Color.red;
        spr.color = Color.white;
    }


}

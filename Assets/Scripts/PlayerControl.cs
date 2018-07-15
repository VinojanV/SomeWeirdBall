using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{

    private Rigidbody PlayerRb; 
    public Text Score, VictoryText, FailureText;
    public float Speed;
    private int count = 0;


    void SetScore ()
    {
        Score.text = "Score: " + count.ToString();

        if (count == 12)
        {
            VictoryText.text = "VICTORY";
            this.gameObject.SetActive(false);
        }
    }

    //initialize component
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        SetScore();
    }

    void Update()
    {
       /** if (transform.position.y != 0.5)
        {
            FailureText.text = "FAILURE";
            this.gameObject.SetActive(false);-
        } */    
    }

    //creating movement
    void FixedUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(Horizontal, 0, Vertical);

        PlayerRb.AddForce(movement * Speed);
    }

    //contact with pickup objects
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Capsule"))
        {
            Destroy(other);
            other.gameObject.SetActive(false);
            count += 1;
            SetScore();
        }
    }
}
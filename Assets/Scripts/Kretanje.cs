using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kretanje : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public Text countText;
    private int count;
    public Text winText;
    public Text againText;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
        againText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Rezultat: " + count.ToString();
        if (count >= 16)
        {
            winText.text = "Pobjedio si!";
            againText.text = "Pokušaj ponovo";
        }
    }
}

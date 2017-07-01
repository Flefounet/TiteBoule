using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;

    //score variable; made as class variable to modify score display via a setter
    private int count;
    //Score UI element
    public Text countText;
    //Win text UI element
    public Text winText;


    private GameObject[] collectibleArrayList;

    //init creation of rigidbody
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    //update at each physic interaction
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }


    // Deactivate collectible that enters the trigger
    //Update score variable in the mean time

    void OnTriggerEnter(Collider other)
    {
        //check on tag "Collectible"
        if (other.gameObject.CompareTag("Collectible"))
        {
            //Deactivation.
            other.gameObject.SetActive(false);
            //Score update
            count++;
            SetCountText();

            
        }
            
    }

    //Score Setter and display of win text
    void SetCountText()
    {
        //Modifies the 
        countText.text = "Score: " + count.ToString();


        //Display of win text
        // First we need to count the number of "Collectible" tag active in the scene. The SetCountText funciton is called at each time a collectible is picked up.
        collectibleArrayList = GameObject.FindGameObjectsWithTag("Collectible");
        //When the number of active "Collectible" tag reach 0 it means we collect all of them. Player wins. 
        if (collectibleArrayList.Length == 0)
        {
            //And then, the win text is modified to show the string defined below.
            winText.text = "Bravo Didou";

        }
    }

}


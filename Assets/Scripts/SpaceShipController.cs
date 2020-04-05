using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceShipController : MonoBehaviour
{
    public float velocity = 1; //public variable to set speed relative to frame time

    Rigidbody2D rbTDim; //private variable to represent the rigidbody 2D within the program

    Vector2 physForce; //stores vector for force 

    public Text fuelTank; //text which displays the Fuel remaining 

    double fuelValue = 5.0;

    // private float thrustUp = 5.0f;

    // private float thrustRight = 2.0f;

    //private float thrustLeft = 2.0f;

    // private float fuelValue = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SpaceShip Controller Has Been Initiated");
        rbTDim = GetComponent<Rigidbody2D>(); // when script starts up, finds attached component and stores reference to it here
        //velocity = Random.Range(-5, -2);
        //rbTDim.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        physForce = Vector2.zero;

       // float estimatedFuel = (float)System.Math.Round(fuelValue, 2); //sets the value of fuel as a float and rounds to 2 decimal places
       // fuelTank.text = "Fuel Tank : " + estimatedFuel;

       /* if (fuelValue <= 0.0)
        {
            fuelValue = 0.0f;
            return;
        }*/
       
       if (Input.GetKey(KeyCode.A))
       {
            //transform.Translate(velocity * Time.deltaTime, 0, 0);  //Push Spaceship Right when A is pressed
            //rbTDim.AddForce(transform.right * thrustLeft * -1, ForceMode2D.Force);
            physForce.x = 2; 
            fuelValue -= (2 * Time.deltaTime);
            float estimatedFuel = (float)System.Math.Round(fuelValue, 1);
            fuelTank.text = estimatedFuel.ToString();
            

        }
       else if (Input.GetKey(KeyCode.D))
       {
            //transform.Translate(-velocity * Time.deltaTime, 0, 0); //Push Spaceship Left when D is pressed
            // rbTDim.AddForce(transform.right * thrustRight, ForceMode2D.Force);
            physForce.x = -2;
            fuelValue -= (2 * Time.deltaTime);
            float estimatedFuel = (float)System.Math.Round(fuelValue, 1);
            fuelTank.text = estimatedFuel.ToString();
            
        }
       if (Input.GetKey(KeyCode.S))
       {
             //transform.Translate(0, velocity * Time.deltaTime, 0); //Push Spaceship Up when S is pressed
            //rbTDim.AddForce(transform.up * thrustUp, ForceMode2D.Force);
            physForce.y = 1;
            fuelValue -= (2 * Time.deltaTime);
            float estimatedFuel = (float)System.Math.Round(fuelValue, 1);
            fuelTank.text = estimatedFuel.ToString();

        }

       if (fuelValue <= 0.0)
        {
            fuelValue = 0.0;
            fuelTank.text = fuelValue.ToString();
            System.Math.Round(fuelValue, 2);
            physForce.x = 0;
            physForce.y = 0;
        }
    }

    private void FixedUpdate()
    {
        //Physics and force calculations done here
        rbTDim.AddForce(physForce);
        rbTDim.velocity = new Vector2(Mathf.Clamp(rbTDim.velocity.x, -2, 2), rbTDim.velocity.y);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class testing : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject tester;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.A))
        {
           PlayerInput P1 = PlayerInput.Instantiate(tester);
           PlayerInput P2 = PlayerInput.Instantiate(tester);


            //USE CONTROL SCHEMAS
            P1.SwitchCurrentControlScheme(Gamepad.all[0]);
            P2.SwitchCurrentControlScheme(Gamepad.all[1]);




        }

     
    }
}

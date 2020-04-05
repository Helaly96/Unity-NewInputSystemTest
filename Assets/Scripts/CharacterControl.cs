using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class CharacterControl : MonoBehaviour
{
    private Vector2 Gun_Left_Readings;
    private Vector2 Gun_Right_Readings;

    public float MoveSpeed = 80;

    private PlayerControls controls;
    private Rigidbody2D rb;
    public float fallMultiplier = 8f;

    public MoveCrossHair LeftGun_object = null;
    public MoveCrossHair RightGun_object = null;

    bool left_move = false;
    bool right_move = false;

    public GameObject left_hand;
    public GameObject Right_hand;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BlueGun") || collision.gameObject.CompareTag("OrangeGun"))
        {
            Debug.Log("GUN!");
            if (!(collision.gameObject.GetComponent<MoveCrossHair>().is_equipped))
            {
                Equip_Gun(collision.gameObject);
            }
        }
    }

    void Equip_Gun(GameObject Gun)
    {
        if (RightGun_object == null)
        {
            RightGun_object = Gun.GetComponent<MoveCrossHair>();
            Gun.transform.parent = Right_hand.transform;
            RightGun_object.is_equipped = true;
            Gun.transform.localPosition = new Vector2(0, 0);

        }

        else if (LeftGun_object == null)
        {
            LeftGun_object = Gun.GetComponent<MoveCrossHair>();
            Gun.transform.parent = left_hand.transform;
            LeftGun_object.is_equipped = true;
            Gun.transform.localPosition = new Vector2(0, 0);



        }


    }

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();

        controls = new PlayerControls();


        //Left Stick
        controls.Gameplay.GunLeft.performed += ctx => Gun_Left_Readings = ctx.ReadValue<Vector2>();
        controls.Gameplay.GunLeft.canceled += ctx => Gun_Left_Readings = Vector2.zero;


        //Right Stick
        controls.Gameplay.GunRight.performed += ctx => Gun_Right_Readings = ctx.ReadValue<Vector2>();
        controls.Gameplay.GunRight.canceled += ctx => Gun_Right_Readings = Vector2.zero;


        //Moving Left
        controls.Gameplay.MoveLeft.performed += ctx => left_move = true;
        controls.Gameplay.MoveLeft.canceled += ctx => left_move = false;


        //Moving Right
        controls.Gameplay.MoveRight.performed += ctx => right_move = true; ;
        controls.Gameplay.MoveRight.canceled += ctx => right_move = false; ;


        //Guns Logic
        controls.Gameplay.ShootRight.performed += ctx => FireRight();
        controls.Gameplay.ShootLeft.performed += ctx => FireLeft();


        //Jumping
        controls.Gameplay.Jump.performed += ctx => Jumping(); ;

        //Throw Gun
        controls.Gameplay.ThrowWeaponLeft.performed += ctx => ThrowLeft();
        controls.Gameplay.ThrowWeaponRight.performed += ctx => ThrowRight();

    }



    void ThrowLeft()
    {
        if (LeftGun_object != null)
        {
            if (this.gameObject.CompareTag("TopPlayer"))
            {
                LeftGun_object.pass_the_gun(1);
                LeftGun_object = null;
            }
            else
            {
                LeftGun_object.pass_the_gun(0);
                LeftGun_object = null;
            }

        }
    }

    void ThrowRight()
    {
        if (RightGun_object != null)
        {
            if (this.gameObject.CompareTag("TopPlayer"))
            {
                RightGun_object.pass_the_gun(1);
                RightGun_object = null;
            }
            else
            {
                RightGun_object.pass_the_gun(0);
                RightGun_object = null;
            }
        }
    }


    void FireRight()
    {
        if (RightGun_object != null)
        {
            RightGun_object.Fire();
        }
    }

    void FireLeft()
    {
        if (LeftGun_object != null)
        {
            LeftGun_object.Fire();
        }
    }

    void Jumping()
    {

        if (rb.velocity.y < 3)
        {
            rb.velocity += Vector2.up * 3;
        }

    }

    public void Update()
    {

        if (LeftGun_object != null)
        {
            LeftGun_object.moveCrossHair(Gun_Left_Readings);
        }

        if (RightGun_object != null)
        {
            RightGun_object.moveCrossHair(Gun_Right_Readings);
        }

        if (right_move)
        {
            Vector3 m = new Vector3(8, 0, 0);
            this.transform.position += m * Time.deltaTime;
        }

        else if (left_move)
        {
            Vector3 m = new Vector3(-8, 0, 0);
            this.transform.position += m * Time.deltaTime;
        }


        //To make jumping realistic
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }

    }

    public void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    public void OnDisable()
    {
        controls.Gameplay.Disable();

    }

}

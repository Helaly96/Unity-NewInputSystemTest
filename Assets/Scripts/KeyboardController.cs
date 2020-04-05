using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float fallMultiplier = 8f;
    KeyBoardControl controls;
    bool left_move = false;
    bool right_move = false;

    public GameObject Hand;
    public MoveCrossHair Gun_Equipped;

    private void Awake()
    {
        controls = new KeyBoardControl();
        rb = this.GetComponent<Rigidbody2D>();

        //Moving Left
        controls.Test.D.performed += ctx => right_move = true;
        controls.Test.D.canceled += ctx => right_move = false;


        //Moving Right
        controls.Test.A.performed += ctx => left_move = true; ;
        controls.Test.A.canceled += ctx => left_move = false; ;

    }

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
        if (Gun_Equipped == null)
        {
            Gun_Equipped = Gun.GetComponent<MoveCrossHair>();
            Gun.transform.parent = Hand.transform;
            Gun_Equipped.is_equipped = true;
            Gun.transform.localPosition = new Vector2(0, 0);

        }


    }


    void OnSpace()
    {
        if (rb.velocity.y < 2)
        {
            rb.velocity += Vector2.up * 3;
        }
    }

    void OnFire()
    {
        Fire();
    }

    void Update()
    {


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

        if(Gun_Equipped!=null)
        {
            this.Gun_Equipped.moveCrossHairAngle();
        }

    }

    void Fire()
    {
       if(Gun_Equipped!=null)
        {
            Gun_Equipped.Fire();
        }
    }

    public void OnEnable()
    {
        controls.Test.Enable();
    }

    public void OnDisable()
    {
        controls.Test.Disable();

    }

}

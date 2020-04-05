using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCrossHair : MonoBehaviour
{
    public Transform CrossHair;

    public GameObject Orange_Bullet;
    public GameObject Blue_Bullet;

    public bool is_equipped = false;

    float angle;

    public void moveCrossHair(Vector2 controls)
    {

        angle = Mathf.Atan2(controls.y, controls.x);
        angle = angle * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(0, 0, angle), 1 * Time.time);
    }

    public void moveCrossHairAngle()
    {
        Vector3 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 lookAt = mouseScreenPosition;

        float AngleRad = Mathf.Atan2(lookAt.y - this.transform.position.y, lookAt.x - this.transform.position.x);

        float AngleDeg = (180 / Mathf.PI) * AngleRad;

        this.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);
    }

    public void Fire()
    {
        if(this.gameObject.CompareTag("OrangeGun"))
        {
            GameObject bullet = Instantiate(Orange_Bullet,this.transform.position,this.transform.rotation);
            Vector2 dir = CrossHair.transform.position - this.transform.position;
            bullet.GetComponent<Rigidbody2D>().AddForce(dir * 700); ;
            Destroy(bullet, 0.3f);
        }
        else
        {
            GameObject bullet = Instantiate(Blue_Bullet, this.transform.position, this.transform.rotation);
            Vector2 dir = CrossHair.transform.position - this.transform.position;
            bullet.GetComponent<Rigidbody2D>().AddForce(dir * 700); ;
            Destroy(bullet, 0.3f);

        }

    }

   public void pass_the_gun(int player)
    {
        
        this.transform.parent = null;
        this.transform.gameObject.AddComponent<Rigidbody2D>();
        this.transform.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;

        if (player==0)
        {
            
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 60);
            Destroy(this.GetComponent<Rigidbody2D>(),1f);
            Invoke("Remove", 1);

        }

        else
        {
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.up * -60);
            Destroy(this.GetComponent<Rigidbody2D>(), 1f);
            Invoke("Remove", 1);
        }

    }

    void Remove()
    {
        is_equipped = false;

        // Code to execute after the delay
    }

}

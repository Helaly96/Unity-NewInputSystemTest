using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SimpleTest : MonoBehaviour
{
    Vector2 i_move;
    


    private void Awake()
    {
       // PIM = FindObjectOfType<PlayerInputManager>();
        
    }
    // Start is called before the first frame update
    private void Update()
    {
        Move(); 
    }

    void Move()
    {
        Vector2 Movement = new Vector2(i_move.x, i_move.y);
        this.transform.Translate(Movement * 3 * Time.deltaTime);
    }

    void OnGunLeft(InputValue i)
    {
        i_move = i.Get<Vector2>();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed;
    public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        //float moveHori = Input.GetAxisRaw("Horizontal");
        //float moveVerti = Input.GetAxisRaw("Vertical");
        //Vector3 movement = new Vector3(moveHori, 0.0f, moveVerti);

        //if (canMove = true && moveHori + moveVerti != 0 || moveHori != 0 || moveVerti != 0)
        //{
        //    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15F);
        //}

        transform.position = transform.position + Camera.main.transform.forward * 3 * Time.deltaTime;
    }
    //transform.rotation = Camera.main.transform.rotation;

}

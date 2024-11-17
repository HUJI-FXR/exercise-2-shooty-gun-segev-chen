using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    [SerializeField] private MovementScript movementScript;

    // Start is called before the first frame update
    void Start()
    {
        movementScript = GetComponent<MovementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            movementScript.Move(-1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movementScript.Move(1);
        }
        else
        {
            movementScript.Move(0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            movementScript.Jump();
        }
    }

}

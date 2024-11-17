using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAimScript : MonoBehaviour
{
    [SerializeField] private float flipAngle = 180f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + flipAngle;
        transform.rotation = Quaternion.Euler(0, 0, angle);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCtrl : MonoBehaviour
{
    [SerializeField]
    private float W;
    [SerializeField]
    public float D;
    [SerializeField]
    public float S;
    [SerializeField]
    public float A;

    void Start()
    {
    }

    void Update()
    {
        AllInput();
    }
    private void AllInput()
    {
        Vector3 dir = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            dir = Vector3.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            dir = (dir + Vector3.right).normalized;
        }
        if (Input.GetKey(KeyCode.S))
        {
            dir = (dir + Vector3.down).normalized;
        }
        if (Input.GetKey(KeyCode.A))
        {
            dir = (dir + Vector3.left).normalized;
        }

        if (dir != Vector3.zero)
        {
            dir.y = 0;
            dir.Normalize();
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * 2.0f);
        }
        //transform.position += transform.forward * 3.0f * Time.deltaTime;
    }
}

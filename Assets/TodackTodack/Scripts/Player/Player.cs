using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance = null;

    public Structs.Status status;

    [Space(10f)]
    [Header("Components")]
    [SerializeField]
    private Rigidbody rigid;
    [SerializeField]
    private CapsuleCollider collider;
    [SerializeField]
    private Animator aniCtrl;

    private void PlayerInitialize()
    {
        if (instance == null) { Debug.LogError("PlayerInitailize Error"); return; }
        status.unitName = Enums.UnitNameTable.Player;
        status.maxHp = 100;
        status.curHp = 100;
        rigid = GetComponentInChildren<Rigidbody>();
        collider = GetComponentInChildren<CapsuleCollider>();
        aniCtrl = GetComponentInChildren<Animator>();
        if(rigid == null || collider == null || aniCtrl == null) { Debug.LogError("GetComponent Error"); return; }
    }

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(this);
    }

    private void Start()
    {
        PlayerInitialize();
    }

    private void Update()
    {
        AllInput();
    }
    private void FixedUpdate()
    {

    }

    private void AllInput()
    {

        Vector3 dir = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            //aniCtrl.SetFloat("blend",Input.GetAxisRaw("Horizontal"));
            //  if (Input.GetKey(KeyCode.D))
            dir = Vector3.forward;
                
            //lse
            //
            //   Debug.Log(Input.GetAxisRaw("Vertical"));
            //
        }

        if (Input.GetKey(KeyCode.D))
        {
            dir = (dir + Vector3.right).normalized;
        }

        if (Input.GetKey(KeyCode.A))
        {
            dir = (dir + Vector3.left).normalized;
        }
        if (Input.GetKey(KeyCode.S))
        {
            dir = (dir + Vector3.down).normalized;
        }

        if (dir != Vector3.zero)
        {
            dir.y = 0;
            dir.Normalize();
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * 2.0f);
        }
        transform.position += transform.forward * 3.0f * Time.deltaTime;
    }


}

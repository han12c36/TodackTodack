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

    }
    private void FixedUpdate()
    {

    }
}

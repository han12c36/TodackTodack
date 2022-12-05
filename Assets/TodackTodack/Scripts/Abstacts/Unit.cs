using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    public Structs.Status status;

    [Space(10f)]
    [Header("Components")]
    [SerializeField]
    private Rigidbody rigid;
    [SerializeField]
    private CapsuleCollider collider;
    [SerializeField]
    private Animator aniCtrl;

    protected abstract void Initialize();

    protected virtual void Awake()
    {
        Initialize();
        rigid = GetComponent<Rigidbody>();
        collider = GetComponent<CapsuleCollider>();
        aniCtrl = GetComponent<Animator>();
        if (rigid == null || collider == null || aniCtrl == null) { Debug.LogError("GetComponent Error"); return; }
    }

    protected virtual void Start() { }
    protected virtual void Update() { }
    protected virtual void FixedUpdate() { }
}

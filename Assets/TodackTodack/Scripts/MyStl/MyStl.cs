using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enums
{
    public enum UnitNameTable
    {
        None,
        Player,
        End
    }

    public enum UnitState
    {

    }

}

namespace Structs
{
    [System.Serializable]
    public struct Status
    {
        public Enums.UnitNameTable unitName;
        public int maxHp;
        public int curHp;

        public float moveSpeed;
        public float runSpeed;

        public Status(Enums.UnitNameTable unitName,int maxHp,int curHp,float moveSpeed,float runSpeed)
        {
            this.unitName = unitName;
            this.maxHp = maxHp;
            this.curHp = curHp;
            this.moveSpeed = moveSpeed;
            this.runSpeed = runSpeed;
        }
    }
}




public class MyStl : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

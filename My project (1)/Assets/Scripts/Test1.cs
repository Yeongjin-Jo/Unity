using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    /* 
    "RigidBody : 물리법칙을 제어할 수 있는 도구"
    */
    private Rigidbody myRigid;
    private Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            /*
            1. 속도를 제어하는 방법
            myRigid.velocity = Vector3.forward;
            */

            /*
            2. 회전속도를 제어하는 방법
            myRigid.angularVelocity = -Vector3.right;
            */
            
            /*
            3. 대표적인 속성
            myRigid.drag = 2f;
            myRigid.mass = 2f;
            myRigid.angularVelocity = 2f;
            기본 maxAngularVelocity는 7
            myRigid.maxAngularVelocity = 100;
            myRigid.angularVelocity = Vector3.right * 100;
            myRigid.useGravity = true;
            */
            
            /*
            4. w를 누르는 동안 객체를 회전시킬 수 있는 MoveRotation
            * 질량과 관성(저항)의 영향을 받지 않음 
            rotation += new Vector3(90,0,0) * Time.deltaTime;
            myRigid.MoveRotation(Quaternion.EulerAngles(rotation));
            */

            /*
            5. 4와 똑같은데 질량과 관성에 영향을 받는 AddForce
            myRigid.AddForce(transform.forward);
            */

           /*
           6. 관성에 영향을 받도록 회전시키는 AddTorque
            myRigid.AddTorque(transform.up);       
           */ 

            /*
            7. 폭발시키는 AddExplosionForce
            myRigid.AddExplosionForce(10, this.transform.right, 10);
            */
            
            /*
            8. 메서드 중 add가 붙은 것들은 물리효과가 적용되는 것이고 
            move가 붙은 것들은 물리효과를 무시하는 것이다. 
            */
           
            
        }
    }
}

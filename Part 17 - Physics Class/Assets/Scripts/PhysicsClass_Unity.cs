using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsClass_Unity : MonoBehaviour
{
    private float createTime = 1f;
    private float currentCreateTime = 0f;

    [SerializeField] private GameObject go_BulletPrefab;
    
    void Update()
    {
        Collider[] col = Physics.OverlapSphere(transform.position, 5f);

        if(col.Length >0)
        {
            for (int i = 0; i < col.Length; i++)
            {
                Transform tf_Target = col[i].transform;

                if(tf_Target.tag == "Player")
                {
                    Quaternion rotation = Quaternion.LookRotation(tf_Target.position - this.transform.position); 
                    transform.rotation = rotation;

                        currentCreateTime += Time.deltaTime;
                        if(currentCreateTime >= createTime)
                        {
                            GameObject _temp = Instantiate(go_BulletPrefab, transform.position, rotation);
                            Physics.IgnoreCollision(_temp.GetComponent<Collider>(), tf_Target.GetComponent<Collider>());
                            currentCreateTime = 0f;
                        }

                }
            }
        }

    }
}

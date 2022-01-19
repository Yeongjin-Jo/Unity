using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{   Vector3 rotation;
    [SerializeField]
    private GameObject go_camera;
    // Start is called before the first frame update
    void Start()
    {
        rotation = this.transform.eulerAngles;
        
    }
    
    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(go_camera.transform.position, this.transform.up, 100 * Time.deltaTime);
        if(Input.GetKey(KeyCode.W))
        {
            /*
             1. transform position을 직접 수정해서 이동시키는 방법
             this.transform.position = this.transform.position + new Vector3(0,0,1) * Time.deltaTime; // 60분의 1
            */
            
            /*
             2. translate 메서드를 이용해 방향과 이동할 크기로 이동시키는 방법 
            this.transform.Translate(new Vector3(0,0,1) * Time.deltaTime);
            */

            /*
             3. eulerangles로 회전 시키기 
            rotation = rotation + new Vector3(90,0,0) * Time.deltaTime;
            this.transform.eulerAngles = rotation;
            Debug.Log(transform.eulerAngles);
            */

            /*
             4. rotate 메서드로 회전 시키기
            this.transform.Rotate(new Vector3(90,0,0) * Time.deltaTime);
            */

            /*
             5. Quanternion을 메서드를 활용해 회전 시키기 (Quanternion은 4차원으로 움직이기 때문에 직접 값을 대입 못하고 quanternion.eular로 3차원 벡터를 받을 수 있게 끔 해야함)
             왜 Quanternion을 쓰는가 ? 짐볼락 현상이 일어나기 때문 (짐폴락 : 한 축이 90도가 되면 다른 축의 회전이 이상해지는 현상, 오일러각도에서만 존재)
            rotation = rotation + new Vector3(90,0,0) * Time.deltaTime;
            this.transform.rotation = Quaternion.Euler(rotation);
            */ 

            /*
             6. localscale로 크기 조절하기 
            this.transform.localScale = this.transform.localScale + new Vector3(2,2,2) * Time.deltaTime; 
            this.transform.localScale = this.transform.localScale - new Vector3(2,2,2) * Time.deltaTime; 
            */

            /*
             7. 그 외 대표적인 속성
            movespeed * this.transform.forward * Time.deltaTime// 정규화 벡터(방향만을 알려주는 녀석) new Vector3(0,0,1)
            movespeed * this.transform.up * Time.deltaTime// 정규화 벡터(방향만을 알려주는 녀석) new Vector3(0,1,0)
            movespeed * this.transform.right * Time.deltaTime// 정규화 벡터(방향만을 알려주는 녀석) new Vector3(1,0,0)
            */

            /* 
             8. 그 외 대표적인 transform 메서드
            this.transform.LookAt(go_camera.transform.position);
            this.transform.RotateAround(go_camera.transform.position, this.transform.up, 100 * Time.deltaTime);
        
            */
            

            
            
            



        }
    }
}

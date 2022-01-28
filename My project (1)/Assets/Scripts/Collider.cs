using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour

{
    // Start is called before the first frame update
    private BoxCollider col;
    void Start()
    {
        col = GetComponent<BoxCollider>();
    }
    /*
    3. Is trigger 3가지 내장함수 (is trigger 체크박스 체크해야함)
    - OnTriggerEnter
    - OnTriggerExit
    - OnTriggerStay
    private void OnTriggerEnter(Collider other) 
    {
        
    }
    private void OnTriggerExit(Collider ohter)
    {

    }
    - 3-1) 다른 콜라이더랑 겹쳐지면 다른 콜라이더의 위치를 x축 방향으로 0.1만큼 이동
    private void OnTriggerStay(Collider other)
    {
        other.transform.position += new Vector3(0, 0, 0.1f);
    }
    - 3-2) 다른 콜라이더랑 겹쳤던게 풀리면 새로운 0,2,0 좌표로 이동
    private void OnTriggerExit(Collider other)
    {
        other.transform.position = new Vector3(0, 2, 0);
    }
    */

    // Update is called once per frame  
    void Update()
    {
        // keycode는 꾹 눌러도 되는데 keydown은 꾹 눌러도 한 번만.

        /*
        1. BoxCollider 속성
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("col.bounds" + col.bounds); // col.bounds는 position center + collider center
            Debug.Log("col.bounds.extents" + col.bounds.extents);
            Debug.Log("col.bounds.extents.x" + col.bounds.extents.x);
            Debug.Log("col.size" + col.size);
            Debug.Log("col.center" + col.center);

            col.size = new Vector3(3,3,3);
        }
        */
        
        /* 
        2. Raycast 활용
        * 레이저를 쏴서 collider에 맞으면 true, 안맞으면 false
        if(Input.GetMouseButtonDown(0)) // 마우스 좌클릭하면 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 메인카메라 화면에서 마우스 위치값에서 레이저를 쏜다
            RaycastHit hitinfo; // 맞으면
            if(col.Raycast(ray, out hitinfo, 1000)) // 맞았으면 true
            {
                this.transform.position = hitinfo.point;
            }
            
        }
        */

        // 여기까지 유니티 입문 강좌 part 4 - 컬라이더 18:20초
        // 유튜버 케이디
    }
}

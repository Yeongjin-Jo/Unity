using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    [SerializeField] // Inspector 창에서 직접 컨트롤 가능한 객체로 만들기
    private Material red_Mat; // red_material 변수 선언
    [SerializeField]
    private Material green_Mat; // green_material 변수 선언
    private MeshRenderer mesh; // mesh 변수 선언
    // Start is called before the first frame update
    void Start() // 시작하면,
    {
        mesh = GetComponent<MeshRenderer>(); // 메쉬 렌더러 컴포넌트를 받아와서 mesh에 할당
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)) // 마우스 왼쪽 클릭을 하면
        {
            mesh.material = green_Mat; // mesh의 material을 green_Mat으로 할당하고
        }
        else // 그렇지 않으면,
        {
            mesh.material = red_Mat; // mesh의 material을 red_Mat으로 할당해라.
        }
    }
}

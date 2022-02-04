using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Unity : MonoBehaviour
{
    private Camera theCam; // 카메라 오브젝트 변수 할당(카메라 속성을 알아보기 위해)

    [SerializeField] // Inspector 창에서 컨트롤할 수 있도록 SerializedField 설정
    private GameObject go_Target; // 카메라가 바라볼 Target Object
    [SerializeField]
    private float speed; // 얼마만큼의 보간을 할지 결정 

    

    private Vector3 difValue; // 카메라와 타겟 사이의 일정 거리를 두기 위한 변수
    // Start is called before the first frame update
    void Start() // 시작할 때 실행
    {
        difValue = transform.position - go_Target.transform.position; // 카메라 위치 - 타겟 위치
        difValue = new Vector3(Mathf.Abs(transform.position.x),Mathf.Abs(transform.position.y),Mathf.Abs(transform.position.z)); // 음수를 제거하기 위해 vecotr(x,y,z)를 모두 절댓값 

        /*
        카메라 속성 (번외) (안됨)
        theCam.fieldOfView = 50;
        theCam.clearFlags
        theCam.cullingMask
        theCam.nearClipPlane
        */
        

    }

    // Update is called once per frame
    void Update() // 움직임이 생길 때 (어떤 이벤트가 발생했을 떄)
    {
        this.transform.position = Vector3.Lerp(this.transform.position, go_Target.transform.position + difValue, speed); // Lerp는 보간해주는 것 (0,5,0.5)면 0,2.5,5 으로 카메라 포지션을 이동 speed가 1이면 0,5로 바로 이동 (부드러운 움직임을 주기 위해)
    }
}

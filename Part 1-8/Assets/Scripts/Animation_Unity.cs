using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Unity : MonoBehaviour
{
    private Animation anim;
    // Start is called before the first frame update
    private AnimationClip clip;
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
            anim.Blend("Cube_2"); // Cube_1과 Cube_2를 동시에 실행
            /*
            anim.Play("Cube_2"); // Cube_2 animation을 실행
            anim.PlayQueued("Cube_2"); // Cube_1 끝난 후 Cube_2 실행
            anim.Blend("Cube_2"); // Cube_1과 Cube_2를 동시에 실행
            anim.CrossFade("Cube_2"); // Cube_1이 끝나고 서서히 사라지고 Cube 2 실행
            if (!anim.IsPlaying("Cube_2")) // Cube_2가 실행되지 않 고 있다면 실행
                anim.Play("Cube_2");
            anim.Stop(); // 애니매이션 중지
            anim.wrapMode = WrapMode.Once; // wrapmode 변경
            anim.clip = clip; // clip이란 기본으로 적용되는 애니메이션 (위의 AnimationClip 객체를 선언해주어야 한다.)
            anim.animatePhysics = false; // animationPhysics 효과 끄기
            anim.playAutomatically = false; // playautomatically 효과 끄기
            */
            
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem_Unity : MonoBehaviour
{
    ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ps.Play(); // particle 뿌리기 시작
        ps.Stop(); // Particle 중지
        ps.Pause(); // particle 일시정지
        ps.Emit(100); // particle 입자 수 조정

    }
}

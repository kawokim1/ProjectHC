using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;        // 플레이어의 Transform을 저장할 변수
    public float speed = 10.0f;     // 이동 속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;   // 플레이어를 향해 이동하는 방향 벡터 계산
               
        direction.Normalize();      // 항상 같은 속도로 추적하게 함
            
        transform.Translate(direction * speed * Time.deltaTime);    // 적을 플레이어 방향으로 이동
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 플레이어 태그를 사용하여 충돌 여부 확인
        {
            Destroy(gameObject);        // 적 오브젝트 삭제
        }
    }
}

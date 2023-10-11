using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;        // �÷��̾��� Transform�� ������ ����
    public float speed = 10.0f;     // �̵� �ӵ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;   // �÷��̾ ���� �̵��ϴ� ���� ���� ���
               
        direction.Normalize();      // �׻� ���� �ӵ��� �����ϰ� ��
            
        transform.Translate(direction * speed * Time.deltaTime);    // ���� �÷��̾� �������� �̵�
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // �÷��̾� �±׸� ����Ͽ� �浹 ���� Ȯ��
        {
            Destroy(gameObject);        // �� ������Ʈ ����
        }
    }
}

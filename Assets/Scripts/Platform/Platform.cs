using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public GameObject[] platforms; //�÷��� ������

    //�÷��� ��ü�� ��� �θ� ������Ʈ
    GameObject newPlatform;

    //Player�� �������� ������ ������ �÷���
    GameObject oldPlatform;

    //newPlatform�� ���� ������Ʈ
    GameObject childPlatform;

    //�÷��� ���� ���� ����
    GameObject platform;


    // Start is called before the first frame update
    void Start()
    {
        newPlatform = GameObject.Find("StartPlatform");
        oldPlatform = GameObject.Find("OldPlatform");
        childPlatform = newPlatform; //�ڽ��� ��ġ�� �θ�� ��ġ��Ŵ

        MakePlatform(); // �÷��� �����
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�÷��� �����ϴ� �Լ�
    void MakePlatform()
    {
        DeleteOldPlatform(); //�÷��̾ ������ �÷���
        MakeNewPlatform();
        

        
    }

    //�÷��̾ ������ �÷��� ����, ���ο� �÷��� ������ �����.
    void DeleteOldPlatform()
    {
        Destroy(oldPlatform); //���� �÷��� ����
        oldPlatform = newPlatform; //���� �÷��� ����

        //�÷��� ������ �����
        newPlatform = new GameObject("StartPlatform"); //���������� �ִ� StartPlatform�� ���θ���� newPlatform�� ����


    }

    //���ο� �÷��� �����
    //�÷����� �ѹ��� 3���� ����

    void MakeNewPlatform()
    {
        for(int i=0;i<3;i++)
        {
            platform = platforms[0]; //�⺻ �÷���

            SelectPlatform(i);

            Vector3 pos = Vector3.zero; //�÷����� ������

            Vector3 localPos = childPlatform.transform.localPosition; //�÷����� ���������� (�� ���������� ������� �÷����� �������������� ����ġ�� �������� ���ο� �÷��� ����)

            pos = new Vector3(localPos.x, 0, localPos.z + 30);

            //���ο� �÷��� ����� �θ� ����
            childPlatform = Instantiate(platform, pos,transform.rotation) as GameObject;
        }
    }


    //�÷��� ���� �����ϱ�
    void SelectPlatform(int n)
    {
        switch(n)
        {
            case 0:
            case 1:
            case 2:
                platform = platforms[Random.Range(0, platforms.Length)];
                break;
        }
    }
}

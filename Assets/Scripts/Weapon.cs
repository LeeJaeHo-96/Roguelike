using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    enum weapons { Laser1, Laser2, Missile1, Missile2, Beam1, Beam2 }

    List <Weapon> haveWeapons;
    
    void Start()
    {
        haveWeapons = new List <Weapon> (2);
    }

    
    void Update()
    {
        // ���� �������� ��, ���� 1 2 ������� ��Ͽ� ���� ��
        // ���� ���������� �ش� ���� Ȱ��ȭ
        // 
    }

    void Fire()
    {

    }

    
}

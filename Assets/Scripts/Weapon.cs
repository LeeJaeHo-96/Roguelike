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
        // 무기 구매했을 때, 무기 1 2 순서대로 목록에 장착 됨
        // 무기 장착했으면 해당 무기 활성화
        // 
    }

    void Fire()
    {

    }

    
}

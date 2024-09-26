using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] GameObject room;

    private void Start()
    {
        room = this.gameObject;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Crew"))
        {
            if (room == GameObject.Find("EngineRoom"))
            {
                Engine();
            }
            if (room == GameObject.Find("WeaponRoom"))
            {
                Weapon();
            }
            if (room == GameObject.Find("HealRoom"))
            {
                Heal();
            }
            if (room == GameObject.Find("ShieldRoom"))
            {
                Shield();
            }
            if (room == GameObject.Find("ControllerRoom"))
            {
                Controll();
            }
            

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Crew"))
        {
            if (room == GameObject.Find("EngineRoom"))
            {
                EngineOut();
            }
            if (room == GameObject.Find("WeaponRoom"))
            {
                WeaponOut();
            }
            if (room == GameObject.Find("HealRoom"))
            {
                HealOut();
            }
            if (room == GameObject.Find("ShieldRoom"))
            {
                ShieldOut();
            }
            if (room == GameObject.Find("ControllerRoom"))
            {
                ControllOut();
            }


        }
    }
    private void Engine()
    {
        Debug.Log("엔진 활성화");
    }

    private void Weapon()
    {
        Debug.Log("무기 활성화");
    }

    private void Heal()
    {
        Debug.Log("회복 활성화");
    }

    private void Shield()
    {
        Debug.Log("쉴드 활성화");
    }

    private void Controll()
    {
        Debug.Log("조타석 활성화");
    }

    private void EngineOut()
    {
        Debug.Log("엔진 비활성화");
    }

    private void WeaponOut()
    {
        Debug.Log("무기 비활성화");
    }

    private void HealOut()
    {
        Debug.Log("회복 비활성화");
    }

    private void ShieldOut()
    {
        Debug.Log("쉴드 비활성화");
    }

    private void ControllOut()
    {
        Debug.Log("조타석 비활성화");
    }




}


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
        Debug.Log("���� Ȱ��ȭ");
    }

    private void Weapon()
    {
        Debug.Log("���� Ȱ��ȭ");
    }

    private void Heal()
    {
        Debug.Log("ȸ�� Ȱ��ȭ");
    }

    private void Shield()
    {
        Debug.Log("���� Ȱ��ȭ");
    }

    private void Controll()
    {
        Debug.Log("��Ÿ�� Ȱ��ȭ");
    }

    private void EngineOut()
    {
        Debug.Log("���� ��Ȱ��ȭ");
    }

    private void WeaponOut()
    {
        Debug.Log("���� ��Ȱ��ȭ");
    }

    private void HealOut()
    {
        Debug.Log("ȸ�� ��Ȱ��ȭ");
    }

    private void ShieldOut()
    {
        Debug.Log("���� ��Ȱ��ȭ");
    }

    private void ControllOut()
    {
        Debug.Log("��Ÿ�� ��Ȱ��ȭ");
    }




}


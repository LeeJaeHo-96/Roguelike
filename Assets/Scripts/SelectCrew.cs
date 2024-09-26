using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class SelectCrew : MonoBehaviour
{
    Vector2 m_vecMouseDownPos;
    [SerializeField] GameObject selectedCrew;


    private void Start()
    {


    }
    void Update()
    {
        Select();


    }

    private void Select()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_vecMouseDownPos = Input.mousePosition;

            // ���콺 Ŭ�� ��ġ�� ī�޶� ��ũ�� ��������Ʈ�� �����մϴ�.
            Vector2 pos = Camera.main.ScreenToWorldPoint(m_vecMouseDownPos);

            // Raycast�Լ��� ���� �ε�ġ�� collider�� hit�� ���Ϲ޽��ϴ�.
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null)
            {
                // � ������Ʈ���� �α׸� ����ϴ�.
                Debug.Log(hit.collider.name);

                // ������Ʈ ���� �ڵ带 �ۼ��� �� �ֽ��ϴ�.
                if (hit.collider.name == "Square")
                    Debug.Log("Square Hit");
                else if (hit.collider.name == "Circle")
                    Debug.Log("Circle Hit");
                else if (hit.collider.name == "Crew")
                {
                    selectedCrew = hit.collider.gameObject;

                    selectedCrew.GetComponent<Crew>().isSelected = true;
                }
            }

        }
    }
}
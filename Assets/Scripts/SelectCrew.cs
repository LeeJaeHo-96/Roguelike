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

            // 마우스 클릭 위치를 카메라 스크린 월드포인트로 변경합니다.
            Vector2 pos = Camera.main.ScreenToWorldPoint(m_vecMouseDownPos);

            // Raycast함수를 통해 부딪치는 collider를 hit에 리턴받습니다.
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null)
            {
                // 어떤 오브젝트인지 로그를 찍습니다.
                Debug.Log(hit.collider.name);

                // 오브젝트 별로 코드를 작성할 수 있습니다.
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_player : MonoBehaviour
{
    // Start is called before the first frame update
    int count = 0; // 성공 여부 판단용 변수
    public GameObject success_text;
    public AudioClip fire_disposalSound; // 효과음 AudioClip을 Inspector에서 설정
    public AudioClip fireSound; // 효과음 AudioClip을 Inspector에서 설정
    private bool hasCollided = false; // 충돌 여부를 추적하기 위한 변수
    private string collisionMessage = "";
    private float messageDisplayTime = 1f; // 메시지를 표시할 시간(1초)

    private float displayTimer = 0f; // 메시지 표시 타이머

    [SerializeField] private float decreaseAmount = 1f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("fire_disposal"))
        {
            count += 1;
            AudioSource.PlayClipAtPoint(fire_disposalSound, transform.position);
        }
        if (!hasCollided && collision.gameObject.CompareTag("Fire"))
        {
            // 충돌한 객체가 "Fire" 태그를 가지고 있고 아직 충돌하지 않았을 경우에만 메시지를 설정
            hasCollided = true;
            collisionMessage = "화상을 입었습니다! 속도가 느려집니다.";
            displayTimer = Time.time + messageDisplayTime; // 타이머 시작

            // 충돌한 오브젝트가 "Fire" 태그를 가진 경우에만 속도를 감소시킵니다.
            SimpleSampleCharacterControl playerController = GetComponent<SimpleSampleCharacterControl>();

            AudioSource.PlayClipAtPoint(fireSound, transform.position);

            if (playerController != null)
            {
               
                playerController.m_moveSpeed -= decreaseAmount;
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (count == 10)
        {
            GameObject FireBall = GameObject.Find("FireBall");
            GameObject FlameThrower = GameObject.Find("FlameThrower");
            GameObject MediumFlames = GameObject.Find("MediumFlames");
            GameObject MediumFlames1 = GameObject.Find("MediumFlames (1)");
            GameObject MediumFlames2 = GameObject.Find("MediumFlames (2)");
            GameObject MediumFlames3 = GameObject.Find("MediumFlames (3)");
            GameObject Timer = GameObject.Find("Timer");
            GameObject fire함정 = GameObject.Find("fire 함정");
            Destroy(FireBall);
            Destroy(FlameThrower);
            Destroy(MediumFlames);
            Destroy(MediumFlames1);
            Destroy(MediumFlames2);
            Destroy(MediumFlames3);
            Destroy(Timer);
            Destroy(fire함정);
            Vector3 successPrefabPosition = new Vector3(-10f, 0f, 32.8f);
            Quaternion successPrefabRotation = Quaternion.Euler(0f, 0f, 0f); // Y 회전을 180도로 설정
            Instantiate(success_text, successPrefabPosition, successPrefabRotation);
        }
    }
    private void OnGUI()
    {
        if (hasCollided)
        {
            // 타이머가 현재 시간을 초과하면 메시지를 숨깁니다.
            if (Time.time > displayTimer)
            {
                hasCollided = false;
                collisionMessage = "";
            }
            else
            {
                // 화면 중앙에 메시지를 표시하는 예시
                GUIStyle style = new GUIStyle();
                style.fontSize = 24;
                style.normal.textColor = Color.white;
                Vector2 screenSize = new Vector2(Screen.width, Screen.height);
                Vector2 messageSize = style.CalcSize(new GUIContent(collisionMessage));

                // 메시지를 화면 중앙에 표시
                GUI.Label(new Rect((screenSize.x - messageSize.x) / 2, (screenSize.y - messageSize.y) / 2, messageSize.x, messageSize.y), collisionMessage, style);
            }
        }
    }
}


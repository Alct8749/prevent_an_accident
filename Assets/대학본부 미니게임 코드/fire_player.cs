using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_player : MonoBehaviour
{
    // Start is called before the first frame update
    int count = 0; // ���� ���� �Ǵܿ� ����
    public GameObject success_text;
    public AudioClip fire_disposalSound; // ȿ���� AudioClip�� Inspector���� ����
    public AudioClip fireSound; // ȿ���� AudioClip�� Inspector���� ����
    private bool hasCollided = false; // �浹 ���θ� �����ϱ� ���� ����
    private string collisionMessage = "";
    private float messageDisplayTime = 1f; // �޽����� ǥ���� �ð�(1��)

    private float displayTimer = 0f; // �޽��� ǥ�� Ÿ�̸�

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
            // �浹�� ��ü�� "Fire" �±׸� ������ �ְ� ���� �浹���� �ʾ��� ��쿡�� �޽����� ����
            hasCollided = true;
            collisionMessage = "ȭ���� �Ծ����ϴ�! �ӵ��� �������ϴ�.";
            displayTimer = Time.time + messageDisplayTime; // Ÿ�̸� ����

            // �浹�� ������Ʈ�� "Fire" �±׸� ���� ��쿡�� �ӵ��� ���ҽ�ŵ�ϴ�.
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
            GameObject fire���� = GameObject.Find("fire ����");
            Destroy(FireBall);
            Destroy(FlameThrower);
            Destroy(MediumFlames);
            Destroy(MediumFlames1);
            Destroy(MediumFlames2);
            Destroy(MediumFlames3);
            Destroy(Timer);
            Destroy(fire����);
            Vector3 successPrefabPosition = new Vector3(-10f, 0f, 32.8f);
            Quaternion successPrefabRotation = Quaternion.Euler(0f, 0f, 0f); // Y ȸ���� 180���� ����
            Instantiate(success_text, successPrefabPosition, successPrefabRotation);
        }
    }
    private void OnGUI()
    {
        if (hasCollided)
        {
            // Ÿ�̸Ӱ� ���� �ð��� �ʰ��ϸ� �޽����� ����ϴ�.
            if (Time.time > displayTimer)
            {
                hasCollided = false;
                collisionMessage = "";
            }
            else
            {
                // ȭ�� �߾ӿ� �޽����� ǥ���ϴ� ����
                GUIStyle style = new GUIStyle();
                style.fontSize = 24;
                style.normal.textColor = Color.white;
                Vector2 screenSize = new Vector2(Screen.width, Screen.height);
                Vector2 messageSize = style.CalcSize(new GUIContent(collisionMessage));

                // �޽����� ȭ�� �߾ӿ� ǥ��
                GUI.Label(new Rect((screenSize.x - messageSize.x) / 2, (screenSize.y - messageSize.y) / 2, messageSize.x, messageSize.y), collisionMessage, style);
            }
        }
    }
}


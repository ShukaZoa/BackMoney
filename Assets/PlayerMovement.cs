using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//�÷��̾� �������� ���
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float lerpTime = 1.0f;
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float runSpeed = 1.5f;


    private bool run;

    private void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");

        Vector2 targetPos = new Vector2(transform.position.x + inputX, transform.position.y);

        transform.position = Vector2.MoveTowards(transform.position, Vector2.Lerp(transform.position, targetPos, lerpTime)
                                                , 3.0f * (run ? runSpeed : speed) * Time.deltaTime);
    }

    public void Run()
    {
        //playerinput���� �ٴ� Ű �Է� �̺�Ʈ
        run = !run;
    }
}

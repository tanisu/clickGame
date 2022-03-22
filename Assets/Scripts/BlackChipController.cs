using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackChipController : MonoBehaviour
{

    Vector3 targetPos;
    int moveSpeed = 1;
    public bool isMoving;
    
    public void Move(Vector3 _targetPos)
    {
        targetPos = _targetPos;
        StartCoroutine(_move());
    }

    IEnumerator _move()
    {
        isMoving = true;
        while((transform.position - targetPos).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        isMoving = false;
    }



    
}

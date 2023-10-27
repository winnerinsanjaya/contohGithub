using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    [SerializeField]
    private float speed;
    void Update()
    {
        Down();
    }

    private void Down()
    {
        transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
    }
}

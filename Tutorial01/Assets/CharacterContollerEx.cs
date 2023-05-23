using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterContollerEx : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        transform.position += 
            new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime,
            0, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
    }
}

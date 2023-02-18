using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    float leftLimit;
    [SerializeField]
    float rightLimit;
    [SerializeField]
    float bottomLimit;
    [SerializeField]
    float upperLimit;
    public GameObject player;
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10f);
        transform.position = new Vector3
        (
        Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
        Mathf.Clamp(transform.position.y, bottomLimit, upperLimit),
        transform.position.z
        );
    }
}
using UnityEngine;
using System;
using System.Collections;

public class AllCharactersController : MonoBehaviour
{
    private GameObject SplineMoveObject;
    [SerializeField] private float defaultRotationYOfCharacter;

    private void Awake()
    {
        SplineMoveObject = GameObject.FindGameObjectWithTag("SplineMoveObject");
    }
    void Update()
    {
        transform.position = SplineMoveObject.transform.position;
        transform.rotation = Quaternion.Euler(SplineMoveObject.transform.rotation.x, SplineMoveObject.transform.rotation.y+ defaultRotationYOfCharacter, SplineMoveObject.transform.rotation.z);
    }
}

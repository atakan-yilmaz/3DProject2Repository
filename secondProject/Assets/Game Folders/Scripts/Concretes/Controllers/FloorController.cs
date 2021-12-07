using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace secondProject.Controllers
{
    public class FloorController : MonoBehaviour
    {
        [Range(0.5f,2f)]
        [SerializeField] float _moveSpeed = 0.7f;
        Material _material;

        private void Awake()
        {
            _material = GetComponentInChildren<MeshRenderer>().material;
        }

        private void Update()
        {
            _material.mainTextureOffset += Vector2.down * Time.deltaTime * _moveSpeed;
        }
    } 
}


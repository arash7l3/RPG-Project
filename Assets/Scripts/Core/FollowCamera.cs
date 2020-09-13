using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Control;

namespace RPG.Core
{
    public class FollowCamera : MonoBehaviour
    {
        // [SerializeField] Transform target;

        Transform target;
        private void Awake()
        {
            target = GameObject.FindWithTag("Player").transform;
        }

        private void LateUpdate()
        {
            transform.position = target.position;
        }
    }
}

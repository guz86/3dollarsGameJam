﻿using System;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class EnterCollisionComponent : MonoBehaviour
    {
        [SerializeField] private string _tag;
        [SerializeField] private EnterEvent _action;

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag(_tag))
            {
                _action?.Invoke(other.gameObject);
            }
        }
    }

    [Serializable]
    public class EnterEvent : UnityEvent<GameObject>
    {
        
    }
}
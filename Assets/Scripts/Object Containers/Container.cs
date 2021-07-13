using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Containers
{
    public abstract class Container<T> : MonoBehaviour
        where T : Component
    {
        [Header("Use this when you need to add only one object")]
        [SerializeField] private Transform _singleObject;

        [Header("Use this when you need to add many objects")]
        [SerializeField] private Transform[] _objects;

        private List<T> _components;
        private T _component;

        
        private void Awake()
        {
            Init();

        }

        public T GetItemByIndex(int index)
        {
            return _components[index];
        }

        public T GetItem()
        {
            return _component;
        }

        protected void Init()
        {
            if (_singleObject == null)
            {
                foreach (Transform i in _objects)
                {
                    T tObject = i.GetComponent<T>();
                    _components.Add(tObject);
                }
            }
            else
            {
                _component = _singleObject.GetComponent<T>();
            }
        }
    }
}

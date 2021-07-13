using System.Collections.Generic;
using System.Linq;
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

        private List<T> _components = new List<T>();
        private T _component;

        public int Count
        {
            get
            {
                if (_component == null)
                {
                    return _components.Count;
                } else
                {
                    return 1;
                }
            }
        }

        
        private void Awake()
        {
            Init();

        }

        public T GetItemByIndex(int index)
        {
            if (_components.Count > 0)
            {
                return _components[index];
            } else
            {
                return null;
            }
            
        }

        public T GetItem()
        {
            return _component;
        }

        public T[] GetItemsList()
        {
            if (_components.Count > 0)
            {
                return _components.ToArray();
            } else
            {
                return null;
            }
            
        }

        public void AddItem(T item)
        {
            _components.Add(item);
        }

        public void AddItem(Transform item)
        {
            T tObject = item.GetComponent<T>();
            _components.Add(tObject);
        }

        protected void Init()
        {
            if (_singleObject == null)
            {
                if (_objects.Length > 0)
                {
                    foreach (Transform i in _objects)
                    {
                        T tObject = i.GetComponent<T>();
                        _components.Add(tObject);
                    }
                }
                
            }
            else
            {
                _component = _singleObject.GetComponent<T>();
            }
        }
    }
}

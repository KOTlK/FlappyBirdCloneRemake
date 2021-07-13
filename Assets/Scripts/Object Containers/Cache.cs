using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Entities;

namespace Containers
{
    public class Cache : MonoBehaviour
    {
        [SerializeField] private int _pipesCount;
        private GameObject _pipePrefab;

        private PipeContainer Pipes => PipeContainer.Instance;
        public void Start()
        {
            _pipePrefab = Resources.Load<GameObject>("Prefabs/Pipe");
            for (int i = 0; i < _pipesCount; i++)
            {
                var obj = Instantiate(_pipePrefab, this.transform.position, Quaternion.identity, this.transform);
                obj.SetActive(false);
                Pipes.AddItem(obj.GetComponent<Pipe>());
            }
        }
    }
}

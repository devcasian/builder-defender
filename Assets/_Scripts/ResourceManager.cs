using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Scripts
{
    public class ResourceManager : MonoBehaviour
    {
        private Dictionary<ResourceTypeSO, int> _resourceAmountDictionary;

        private void Awake()
        {
            _resourceAmountDictionary = new Dictionary<ResourceTypeSO, int>();

            var resourceTypeList = Resources.Load<ResourceTypeListSO>(nameof(ResourceTypeListSO));

            foreach (var resourceType in resourceTypeList.list)
            {
                _resourceAmountDictionary[resourceType] = 0;
            }

            TestLogResourceAmountDictionary();
        }

        private void Update()
        {
            TestAddResource();
        }

        private void TestLogResourceAmountDictionary()
        {
            foreach (var resourceType in _resourceAmountDictionary.Keys)
            {
                Debug.Log($"{resourceType.nameString}: {_resourceAmountDictionary[resourceType]}");
            }
        }

        private void TestAddResource()
        {
            if (!Input.GetKeyDown(KeyCode.Z)) return;

            var resourceTypeList = Resources.Load<ResourceTypeListSO>(nameof(ResourceTypeListSO));
            AddResource(resourceTypeList.list[0], 2);
            TestLogResourceAmountDictionary();
        }

        public void AddResource(ResourceTypeSO resourceType, int amount)
        {
            _resourceAmountDictionary[resourceType] += amount;
        }
    }
}
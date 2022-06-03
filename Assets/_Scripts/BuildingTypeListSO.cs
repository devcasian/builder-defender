using System.Collections.Generic;
using UnityEngine;

namespace _Scripts
{
    [CreateAssetMenu(menuName = "ScriptableObjects/BuildingTypeList")]
    public class BuildingTypeListSO : ScriptableObject
    {
        public List<BuildingTypeSO> list;
    }
}
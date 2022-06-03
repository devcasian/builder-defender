using UnityEngine;

namespace _Scripts
{
    public class BuildingManager : MonoBehaviour
    {
        private Camera _mainCamera;
        private BuildingTypeListSO _buildingTypeList;
        private BuildingTypeSO _buildingType;

        private void Awake()
        {
            _buildingTypeList = Resources.Load<BuildingTypeListSO>(nameof(BuildingTypeListSO));
            _buildingType = _buildingTypeList.list[0];
        }

        private void Start()
        {
            _mainCamera = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(_buildingType.prefab, GetWorldMousePosition(), Quaternion.identity);
            }

            if (Input.GetKeyDown(KeyCode.T))
            {
                _buildingType = _buildingTypeList.list[0];
            }

            if (Input.GetKeyDown(KeyCode.Y))
            {
                _buildingType = _buildingTypeList.list[1];
            }
        }

        private Vector3 GetWorldMousePosition()
        {
            var mouseWorldPosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPosition.z = 0f;

            return mouseWorldPosition;
        }
    }
}
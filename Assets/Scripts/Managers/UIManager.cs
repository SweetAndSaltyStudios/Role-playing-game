using UnityEngine;

namespace Sweet_And_Salty_Studios
{
    public class UIManager : Singelton<UIManager>
    {
        [Header("UI Element References")]
        public Canvas HudCanvas;
        public RectTransform SelectionBox;
        
        private Vector3 startPosition;
        private Vector3 endPosition;
        private Vector3 centreposition;

        public bool IsSelectionBoxActive
        {
            get;
            private set;
        }
        public bool InsideSelectionBox(Vector3 position)
        {
            var screenPoint = Camera.main.WorldToScreenPoint(position);
            if (RectTransformUtility.RectangleContainsScreenPoint(SelectionBox, screenPoint))
            {
                return true;
            }

            return false;
        }

        private void Start()
        {
            Debug.LogError("Inventory in Unity -> 6:32");
        }

        private void OnValidate()
        {
    
        }

        public void ShowSelectionBox()
        {
            if(IsSelectionBoxActive == false)
            {
                startPosition = InputManager.Instance.MousePosition;
                IsSelectionBoxActive = true;
            }     
        }

        public void UpdateSelectionBox()
        {
            endPosition = InputManager.Instance.MousePosition;

            centreposition = (startPosition + endPosition) / 2f;
            SelectionBox.position = centreposition;

            var sizeX = Mathf.Abs(startPosition.x - endPosition.x);
            var sizeY = Mathf.Abs(startPosition.y - endPosition.y);

            SelectionBox.sizeDelta = new Vector2(sizeX, sizeY);

            if (!SelectionBox.gameObject.activeSelf)
            {
                SelectionBox.gameObject.SetActive(true);
            }
        }

        public void HideSelectionBox()
        {
            if (IsSelectionBoxActive == true)
            {
                SelectionBox.gameObject.SetActive(false);
                IsSelectionBoxActive = false;
            }
        }

        public void ShowMouseCursor()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        public void HideMouseCursor()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}

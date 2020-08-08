using UnityEngine;
using UnityEngine.EventSystems;
namespace Sweet_And_Salty_Studios
{
    public abstract class UI_Element : MonoBehaviour,
    IPointerClickHandler,
    IPointerDownHandler,
    IPointerEnterHandler,
    IPointerExitHandler,
    IPointerUpHandler,
    IBeginDragHandler,
    IDragHandler,
    IEndDragHandler,
    IDropHandler,
    IDeselectHandler,
    ICancelHandler
    {
        #region DRAG

        public virtual void OnBeginDrag(PointerEventData eventData)
        {
            Debug.Log("OnBeginDrag", gameObject);
        }

        public virtual void OnDrag(PointerEventData eventData)
        {
            Debug.Log("OnDrag", gameObject);
        }

        public virtual void OnEndDrag(PointerEventData eventData)
        {
            Debug.Log("OnEndDrag", gameObject);
        }

        public virtual void OnDrop(PointerEventData eventData)
        {
            Debug.Log("OnDrop", gameObject);
        }

        #endregion DRAG

        #region ON_POINTER

        public virtual void OnPointerEnter(PointerEventData eventData)
        {
            Debug.Log("OnPointerEnter", gameObject);
        }

        public virtual void OnPointerDown(PointerEventData eventData)
        {
            Debug.Log("OnPointerDown", gameObject);
        }

        public virtual void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("OnPointerClick", gameObject);
        }

        public virtual void OnPointerExit(PointerEventData eventData)
        {
            Debug.Log("OnPointerExit", gameObject);
        }

        public virtual void OnPointerUp(PointerEventData eventData)
        {
            Debug.Log("OnPointerUp", gameObject);
        }

        #endregion ON_POINTER

        #region OTHERS

        public virtual void OnDeselect(BaseEventData eventData)
        {
            Debug.Log("OnDeselect", gameObject);
        }

        public virtual void OnCancel(BaseEventData eventData)
        {
            Debug.Log("OnCancel", gameObject);
        }

        #endregion OTHERS
    }
}
using UnityEngine;
using UnityEngine.EventSystems;

namespace Sweet_And_Salty_Studios
{
    public class UI_Panel : UI_Element
    {
        private Vector2 offset;

        public override void OnBeginDrag(PointerEventData eventData)
        {
            base.OnBeginDrag(eventData);

            offset = (Vector2)transform.position - eventData.position;
        }

        public override void OnDrag(PointerEventData eventData)
        {
            //base.OnDrag(eventData);

            transform.position = eventData.position + offset;
        }

        public override void OnEndDrag(PointerEventData eventData)
        {
            base.OnEndDrag(eventData);

            offset = Vector2.zero;
        }
    }
}

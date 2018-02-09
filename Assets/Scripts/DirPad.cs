using UnityEngine;
using UnityEngine.EventSystems;


public class DirPad : EventTrigger
{
    private Vector2 startposition;
    public bool dragging { get; private set; }
    private Vector2 currentPosition;
    public Vector2 dir { get { return currentPosition - startposition; } }

    public override void OnBeginDrag(PointerEventData eventData) //드레깅이 시작되면 이 함수가 호출
    {
        base.OnBeginDrag(eventData);
        startposition = eventData.position;
        dragging = true;
    }

    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
        currentPosition = eventData.position;
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        base.OnEndDrag(eventData);
        dragging = false;
    }
}
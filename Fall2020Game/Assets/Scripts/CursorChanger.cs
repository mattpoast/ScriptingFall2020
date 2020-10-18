using UnityEngine;
public class CursorChanger : MonoBehaviour
{
    public Texture2D mouseOverMouse;
    public Texture2D defaultMouse;
    public Vector2 hotSpot = Vector2.zero;
    public CursorMode curMode = CursorMode.Auto;

    void Start()
    {
        Cursor.SetCursor(defaultMouse, hotSpot, curMode);
    }

    private void OnMouseOver()
    {
        Cursor.SetCursor(mouseOverMouse, hotSpot, curMode);

    }
}

using UnityEngine;
public class ObjectMouse : MonoBehaviour
{
    public Texture2D objectMouse;
     public Texture2D defaultMouse;
     public Vector2 hotSpot = Vector2.zero;
     public CursorMode curMode = CursorMode.Auto;
     private void OnMouseEnter()
      {
       if (gameObject.tag == "objectCursor")
       {
        Cursor.SetCursor(objectMouse, hotSpot, curMode);
       }
      }
      private void OnMouseExit()
      {
       Cursor.SetCursor(defaultMouse, hotSpot, curMode);
      }
     }

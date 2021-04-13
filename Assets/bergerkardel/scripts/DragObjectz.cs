using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace bergerkardel
{
    public class DragObjectz : MonoBehaviour
    {
        void OnMouseDrag()
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 6.33f);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            objPosition.x = transform.position.x;
            objPosition.y = transform.position.y;
            transform.position = objPosition;
        }
    }
}
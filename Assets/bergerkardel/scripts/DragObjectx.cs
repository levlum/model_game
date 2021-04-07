using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace bergerkardel
{
    public class DragObjectx : MonoBehaviour
    {
        void OnMouseDrag()
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 6.33f);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            objPosition.y = transform.position.y;
            objPosition.z = transform.position.z;
            transform.position = objPosition;
        }
    }
}
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Duck : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //we arent clicking on a UI element
        if (EventSystem.current.IsPointerOverGameObject() == false) //this could be combined with the next if statement with &&, or just like this
        {
            //was there a click this frame?
            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
                transform.position = mousePos;
            }
        }
        //Y: set the position to be the mouse position in world space


    }
}

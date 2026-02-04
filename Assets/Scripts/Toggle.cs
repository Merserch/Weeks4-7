using UnityEngine;

public class Toggle : MonoBehaviour
{
    

    public void ToggleActive()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);

        //if(gameObject.activeInHierarchy)
        //{
        //    gameObject.SetActive(false);
        //}
        //else if(gameObject.activeInHierarchy == false)
        //{
        //    gameObject.SetActive(true);
        //}
    }
}

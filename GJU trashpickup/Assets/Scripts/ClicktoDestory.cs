using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicktoDestory : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}

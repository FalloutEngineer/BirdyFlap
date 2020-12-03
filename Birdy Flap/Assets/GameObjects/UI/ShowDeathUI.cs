using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDeathUI : MonoBehaviour
{
    public void onDeath()
    {
        this.gameObject.SetActive(true);
    }
}

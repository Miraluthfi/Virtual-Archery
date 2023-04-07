using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    [SerializeField]
    private float duration;

    public void LookAt(Transform target)
    {
        transform.DOLookAt(target.position, duration);
    }
}

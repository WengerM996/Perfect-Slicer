using System;
using BzKovSoft.ObjectSlicerSamples;
using DG.Tweening;
using UnityEngine;

public class Slicer : MonoBehaviour
{
    [SerializeField] private GameObject _blade;
    [SerializeField] private float _duration;
    [SerializeField] private float _offsetY;

    private BzKnife _knife;

    private void Start()
    {
        _knife = _blade.GetComponentInChildren<BzKnife>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _knife.BeginNewSlice();

            _blade.transform.DOMoveY(_blade.transform.position.y - _offsetY, _duration).SetLoops(2, LoopType.Yoyo);
        }
    }
}

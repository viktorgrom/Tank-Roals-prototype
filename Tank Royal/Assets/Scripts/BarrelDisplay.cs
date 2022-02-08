using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarrelDisplay : MonoBehaviour
{
    [SerializeField] private Barrel _barrel;
    [SerializeField] private Text _title;
    [SerializeField] private Text _description;
    [SerializeField] private Text _radius;
    [SerializeField] private Image _image;

    private void Start()
    {
        _title.text = _barrel.title;
        _description.text = _barrel.description;
        _radius.text = _barrel.radius.ToString();
        _image.sprite = _barrel.sprite;
    }

}

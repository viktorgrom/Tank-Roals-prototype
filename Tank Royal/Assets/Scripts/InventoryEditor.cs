using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(Inventory))]
public class InventoryEditor : Editor
{
    private Inventory _inventory;

    private void OnEnable()
    {
        _inventory = (Inventory)target;
    }

    public override void OnInspectorGUI()
    {
        if(_inventory.Items.Count > 0)
        {
            foreach(Inventory.Item item in _inventory.Items)
            {
                item.Id = EditorGUILayout.IntField("Id", item.Id);
            }
        }
        else
        {
            EditorGUILayout.LabelField("Empty");
        }
        if (GUILayout.Button("Edit button", GUILayout.Height(20)))
            _inventory.Items.Add(new Inventory.Item());
    }
}

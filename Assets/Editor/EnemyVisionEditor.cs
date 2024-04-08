using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(EnemyVision))]
public class EnemyVisionEditor : Editor
{
    private void OnSceneGUI()
    {
        EnemyVision enemyVision = (EnemyVision)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(enemyVision.transform.position, Vector3.up, Vector3.forward, 360, enemyVision.radius);
    }
}

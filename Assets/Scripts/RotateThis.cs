using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class RotateThis : MonoBehaviour
{
    //TODO this functionality into TowerWave.cs if we only ever use it there and all these methods are being made public anyways.
    public Vector3 AxisToRotate;
    public float rotationSpeed;
    private bool shouldRotate;
        // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(AxisToRotate * rotationSpeed * Time.deltaTime);
    }
}

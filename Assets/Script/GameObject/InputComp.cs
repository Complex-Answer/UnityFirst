using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputComp : MonoBehaviour
{
    float _horInput;
    float _verInput;

    public float HorInput => _horInput;
    public float VerInput => _verInput;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        _horInput = Input.GetAxis("Horizontal");
        _verInput = Input.GetAxis("Vertical");

        Debug.Log($"HorInput = {_horInput}");
        Debug.Log($"VerInput = {_verInput}");
    }
}

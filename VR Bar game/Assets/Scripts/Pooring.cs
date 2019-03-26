using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooring : MonoBehaviour
{
    [SerializeField]
    private GameObject _water;

    [SerializeField]
    private Transform _pooringPosition;

    [SerializeField]
    private int _capacity;

    void Update()
    {
        if (_capacity == 0)
        {
            return;
        }

        if (transform.eulerAngles.x > 80 && transform.eulerAngles.x < 280 || transform.eulerAngles.z > 80 && transform.eulerAngles.z < 280)
        {
            Debug.Log("klunk");
            _capacity--;
            Instantiate(_water, _pooringPosition.position, transform.rotation);

        }
    }
}

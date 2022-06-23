using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public GameObject player;
    private int _yPos;
    public float droptimer;

    void Update()
    {
        player.transform.position = new Vector3(transform.position.x, _yPos + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -_yPos, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cube" && other.gameObject.GetComponent<Cubes>().IsCollected() == false)
        {
            _yPos += 1;
            other.gameObject.GetComponent<Cubes>().OnCollected();
            other.gameObject.GetComponent<Cubes>().NewPosition(_yPos);
            other.gameObject.transform.parent = player.transform;
        }
    }

    public void OnObstacle()
    {
        _yPos--;
    }

    public void InvokeTimer()
    {
        Invoke("OnObstacle", droptimer);
    }
}

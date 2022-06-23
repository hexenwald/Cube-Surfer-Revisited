using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    public Collector collector;

    private bool _isCollected = false;
    private int i;

    void Update()
    {
        if (_isCollected == true)
        {
            if (transform.parent !=null)
            {
                transform.localPosition = new Vector3(0, -i, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            collector.InvokeTimer();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public bool IsCollected()
    {
        return _isCollected;
    }

    public void OnCollected()
    {
        _isCollected = true;
    }

    public void NewPosition(int i)
    {
        this.i = i;
    }
}

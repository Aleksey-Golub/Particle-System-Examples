using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireable : MonoBehaviour
{
    [SerializeField] private GameObject _fireEffect;

    private Coroutine _previousTask;

    public void OnEnter()
    {
        _fireEffect.SetActive(true);
    }

    public void OnExit()
    {
        if (_previousTask != null)
            StopCoroutine(_previousTask);

        _previousTask = StartCoroutine(StopEffect(7));
    }

    private IEnumerator StopEffect(float delay)
    {
        var waitAnySeconds = new WaitForSeconds(delay);
        yield return waitAnySeconds;
        _fireEffect.SetActive(false);
    }
}

using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CubeSpawner : MonoBehaviour
{
    [Header("InputField")]
    public TMP_InputField inputSpeed;
    public TMP_InputField inputDistance;
    public TMP_InputField inputSpawnTime;
    [Header("Prefab")]
    public GameObject _cubePrefab;
    [Header("Parameters")]
    private float _spawnTime;
    private float _speed;
    private float _distance;
    private float _timer;
    
    private void Awake()
    {
        StartParameters();
    }
    private void Start()
    {
        _timer = _spawnTime;
    }

    private void Update()
    {
        Spawn();
    }

    // === SET Parameters ===
    public void SetSpeed()
    {
        float speed = float.Parse(inputSpeed.text);
        _speed = speed;
    }
    public void SetDistance()
    {
        float distance = float.Parse(inputDistance.text);
        _distance = distance;
    }
    public void SetSpawnTime()
    {
        float spawnTime = float.Parse(inputSpawnTime.text);
        _spawnTime = spawnTime;
    }
    private void StartParameters()
    {
        inputSpeed.text = "5";
        _speed = 5f;
        inputDistance.text = "50";
        _distance = 50f;
        inputSpawnTime.text = "2";
        _spawnTime = 2f;
    }
    
    // === SPAWN ===

    private void Spawn()
    {
        _timer -= Time.deltaTime;
        if (_timer <= 0)
        {
            GameObject cube = Instantiate(_cubePrefab, transform.position, Quaternion.identity);
            Cube cubeScript = cube.GetComponent<Cube>();
            cubeScript._speed = _speed;
            cubeScript._distance = _distance;
            _timer = _spawnTime;
        }
    }
}

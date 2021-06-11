using System;
using UnityEngine;
using Utils;
using Random = UnityEngine.Random;

namespace SeaForceRudder
{
    public class ShipWheel : MonoBehaviour
    {
        [Header("Force Properties")]
        [SerializeField] private float baseForce = 0.5f;
        [SerializeField] private float minForce;
        [SerializeField] private float maxForce;
        
        [Header("Time Properties")]
        [SerializeField] private AnimationCurve timeCurve;
        [SerializeField] private float minTime;
        [SerializeField] private float maxTime;

        private float _time;
        private float _timer;
        private float _currentForce;
        private Direction _direction;

        private void Start()
        {
            _direction = Direction.Left;
            SetTimer();
        }

        private void FixedUpdate()
        {
            SetTimer();

            transform.Rotate(0, 0, GetForce());
        }

        private float GetRandomTime()
        {
            return Random.Range(minTime, maxTime + 1);
        }

        private void SetTimer()
        {
            _timer += Time.fixedDeltaTime;

            if (_timer < _time) return;
            
            _direction = InvertDirection(_direction);
            _time = GetRandomTime();
            _timer = 0;
            _currentForce = GetRandomForce();
        }

        private float GetRandomForce()
        {
            return Random.Range(minForce, maxForce + 1);
        }

        private Direction InvertDirection(Direction direction)
        {
            return direction switch
            {
                Direction.Left => Direction.Right,
                Direction.Right => Direction.Left,
                _ => throw new ArgumentOutOfRangeException(nameof(direction), direction, null)
            };
        }

        private float GetTimeForce()
        {
            return timeCurve.Evaluate(MathUtils.Remap(_timer, 0f, _time, 0f, 1f));
        }

        private float GetForce()
        {
            return GetTimeForce() * baseForce * _currentForce * (int)_direction;
        }
    }
}
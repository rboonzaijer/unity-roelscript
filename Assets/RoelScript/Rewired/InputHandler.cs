using Rewired;
using UnityEngine;
using UnityEngine.Events;

namespace RoelScript
{
    public class InputHandler : MonoBehaviour
    {
        // Rewired Action Ids
        public const int ActionIdMoveVertical = 0;
        public const int ActionIdMoveHorizontal = 1;
        public const int ActionIdLookVertical = 2;
        public const int ActionIdLookHorizontal = 3;
        public const int ActionIdZoom = 4;
        public const int ActionIdCancel = 5;
        public const int ActionIdUse = 6;
        public const int ActionIdFire = 7;
        public const int ActionIdJump = 8;
        public const int ActionIdSpeed = 9;

        // Rewired Player
        private readonly int _playerId = 0;
        private Player _player;

        // Events
        public UnityEvent<Vector2, bool> onMove = new UnityEvent<Vector2, bool>();
        public UnityEvent<Vector2> onLook = new UnityEvent<Vector2>();
        public UnityEvent<float> onZoom = new UnityEvent<float>();
        public UnityEvent onCancel = new UnityEvent();
        public UnityEvent onCancelHold = new UnityEvent();
        public UnityEvent onCancelRelease = new UnityEvent();
        public UnityEvent onUse = new UnityEvent();
        public UnityEvent onUseHold = new UnityEvent();
        public UnityEvent onUseRelease = new UnityEvent();
        public UnityEvent onFire = new UnityEvent();
        public UnityEvent onFireHold = new UnityEvent();
        public UnityEvent onFireRelease = new UnityEvent();
        public UnityEvent onJump = new UnityEvent();

        // Data
        private Vector2 _moveValue;
        private Vector2 _lookValue;
        private bool _speedModifierHold = false;

        void Awake()
        {
            _player = ReInput.players.GetPlayer(_playerId);
        }

        void Update()
        {
            _speedModifierHold = _player.GetButton(ActionIdSpeed);

            GetInputMove();
            GetInputLook();
            GetInputZoom();
            GetInputCancel();
            GetInputUse();
            GetInputFire();
            GetInputJump();
        }

        private void GetInputMove()
        {
            _moveValue.x = _player.GetAxis(ActionIdMoveHorizontal);
            _moveValue.y = _player.GetAxis(ActionIdMoveVertical);

            onMove?.Invoke(_moveValue, _speedModifierHold);
        }

        private void GetInputLook()
        {
            _lookValue.x = _player.GetAxis(ActionIdLookHorizontal);
            _lookValue.y = _player.GetAxis(ActionIdLookVertical);

            onLook?.Invoke(_lookValue);
        }

        private void GetInputZoom()
        {
            onZoom?.Invoke(_player.GetAxis(ActionIdZoom));
        }
        
        private void GetInputCancel()
        {
            if (_player.GetButton(ActionIdCancel))
                onCancel?.Invoke();

            if (_player.GetButton(ActionIdCancel))
                onCancelHold?.Invoke();

            if (_player.GetButtonUp(ActionIdCancel))
                onCancelRelease?.Invoke();
        }

        private void GetInputUse()
        {
            if (_player.GetButtonDown(ActionIdUse))
                onUse?.Invoke();

            if (_player.GetButton(ActionIdUse))
                onUseHold?.Invoke();

            if (_player.GetButtonUp(ActionIdUse))
                onUseRelease?.Invoke();
        }

        private void GetInputFire()
        {
            if (_player.GetButtonDown(ActionIdFire))
                onFire?.Invoke();

            if (_player.GetButton(ActionIdFire))
                onFireHold?.Invoke();

            if (_player.GetButtonUp(ActionIdFire))
                onFireRelease?.Invoke();
        }
        
        private void GetInputJump()
        {
            if (_player.GetButtonDown(ActionIdJump))
                onJump?.Invoke();
        }
    }
}

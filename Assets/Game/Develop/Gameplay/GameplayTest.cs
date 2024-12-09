using Assets.Game.Develop.DI;
using UnityEngine;

namespace Assets.Game.Develop.Gameplay
{
    public class GameplayTest : MonoBehaviour
    {
        const string Numbers = "123";
        const string Letters = "qwe";

        private DIContainer _container;
        private string _answer, _playerInput;

        public void StartProcess(DIContainer container, int variant)
        {
            _container = container;
        }

        private void Update()
        {
           if (_container == null)
                return;

           if (Input.anyKeyDown)
           {
                _playerInput += Input.inputString;
                Debug.Log(_playerInput);
           }
        }
    }
}

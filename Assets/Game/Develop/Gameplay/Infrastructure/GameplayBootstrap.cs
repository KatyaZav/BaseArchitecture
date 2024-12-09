using Assets.Game.Develop.CommonServices.SceneManagment;
using Assets.Game.Develop.DI;
using System.Collections;
using UnityEngine;

namespace Assets.Game.Develop.Gameplay.Infrastructure
{
    public class GameplayBootstrap : MonoBehaviour
    {
        private DIContainer _container;

        [SerializeField] private GameplayTest _gameplayTest; //на время тестов, потом удалим

        public IEnumerator Run(DIContainer container, GameplayInputArgs gameplayInputArgs)
        {
            _container = container;

            ProcessRegistrations();

            Debug.Log($"Подгружаем ресурсы для уровня {gameplayInputArgs.GameVariant}");
            Debug.Log("Создаем персонажа");
            Debug.Log("Сцена готова можно начинать игру");

            _gameplayTest.StartProcess(_container, gameplayInputArgs.GameVariant);

            yield return new WaitForSeconds(1f);
        }

        private void ProcessRegistrations()
        {
            //Делаем регистрации для сцены геймплея

            _container.Initialize();
        }
    }
}
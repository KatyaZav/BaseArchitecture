using Assets.Game.Develop.CommonServices.SceneManagment;
using Assets.Game.Develop.DI;
using System.Collections;
using UnityEngine;

namespace Assets.Game.Develop.Gameplay.Infrastructure
{
    public class GameplayBootstrap : MonoBehaviour
    {
        private DIContainer _container;

        [SerializeField] private GameplayTest _gameplayTest; //�� ����� ������, ����� ������

        public IEnumerator Run(DIContainer container, GameplayInputArgs gameplayInputArgs)
        {
            _container = container;

            ProcessRegistrations();

            Debug.Log($"���������� ������� ��� ������ {gameplayInputArgs.GameVariant}");
            Debug.Log("������� ���������");
            Debug.Log("����� ������ ����� �������� ����");

            _gameplayTest.StartProcess(_container, gameplayInputArgs.GameVariant);

            yield return new WaitForSeconds(1f);
        }

        private void ProcessRegistrations()
        {
            //������ ����������� ��� ����� ��������

            _container.Initialize();
        }
    }
}
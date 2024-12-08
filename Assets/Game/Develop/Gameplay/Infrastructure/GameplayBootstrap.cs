using Assets.Game.Develop.CommonServices.SceneManagment;
using Assets.Game.Develop.DI;
using Assets.Game.Develop.Gameplay.Entities;
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

            Debug.Log($"���������� ������� ��� ������ {gameplayInputArgs.LevelNumber}");
            Debug.Log("������� ���������");
            Debug.Log("����� ������ ����� �������� ����");

            _gameplayTest.StartProcess(_container);

            yield return new WaitForSeconds(1f);
        }

        private void ProcessRegistrations()
        {
            //������ ����������� ��� ����� ��������
            _container.RegisterAsSingle(c => new EntityFactory(c));

            _container.Initialize();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _container.Resolve<SceneSwitcher>().ProcessSwitchSceneFor(new OutputGameplayArgs(new MainMenuInputArgs()));
            }
        }
    }
}
using Assets.Game.Develop.CommonServices.SceneManagment;
using Assets.Game.Develop.DI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChosing : MonoBehaviour
{
    private DIContainer _container;

    public void Init(DIContainer container)
    {
        _container = container;
    }

    public bool WasInit => _container != null;

    private void Update()
    {
        if (WasInit == false)
            return;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Запуск режим 1");
            _container.Resolve<SceneSwitcher>().ProcessSwitchSceneFor(new OutputMainMenuArgs(new GameplayInputArgs(1)));
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Запуск режим 2");
            _container.Resolve<SceneSwitcher>().ProcessSwitchSceneFor(new OutputMainMenuArgs(new GameplayInputArgs(2)));
        }
    }
}

using Assets.Game.Develop.CommonServices.AssetsManagment;
using Assets.Game.Develop.CommonServices.DataManagment.DataProviders;
using Assets.Game.Develop.CommonServices.SceneManagment;
using Assets.Game.Develop.CommonServices.Wallet;
using Assets.Game.Develop.CommonUI.Wallet;
using Assets.Game.Develop.DI;
using Assets.Game.Develop.MainMenu.LevelsMenuFeature.LevelsMenuPopup;
using Assets.Game.Develop.MainMenu.UI;
using System.Collections;
using UnityEngine;

public class MainMenuBootstrap : MonoBehaviour
{
    private DIContainer _container;

    public IEnumerator Run(DIContainer container, MainMenuInputArgs mainMenuInputArgs)
    {
        _container = container;

        ProcessRegistrations();

        yield return new WaitForSeconds(1f);
    }

    private void ProcessRegistrations()
    {
        //Делаем регистрации для сцены геймплея
        InitSceneSwitcher();

        _container.Initialize();
    }

    private void InitSceneSwitcher()
    {
        LevelChosing levelChosing = Instantiate(_container.Resolve<ResourcesAssetLoader>()
            .LoadResource<LevelChosing>("MainMenu/SceneSwitcher"));

        levelChosing.Init(_container);
    }
}

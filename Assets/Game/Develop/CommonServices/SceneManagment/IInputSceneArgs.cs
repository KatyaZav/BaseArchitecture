namespace Assets.Game.Develop.CommonServices.SceneManagment
{
    public interface IInputSceneArgs
    {
    }

    public class GameplayInputArgs : IInputSceneArgs
    {
        public GameplayInputArgs(int variant)
        {
            GameVariant = variant;
        }

        public int GameVariant { get; }
    }

    public class MainMenuInputArgs : IInputSceneArgs
    {
    }
}

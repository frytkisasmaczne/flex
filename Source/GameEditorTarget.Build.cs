using Flax.Build;

public class GameEditorTarget : GameProjectEditorTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for editor
        Modules.Add("majonez");
        Modules.Add("majonez");
        Modules.Add("Game");
    }
}

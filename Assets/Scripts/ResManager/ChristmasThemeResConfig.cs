
using UnityEngine;

public class ChristmasThemeResConfig : IThemeRes
{
    public string GetBingoSpinePrefabPath()
    {
        return "ChristmasThemes/Effects/Bingo/EffectPanel";
    }

    public string GetHomeSpinePrefabPath()
    {
        return "ChristmasThemes/Effects/Home/EffectPanel";
    }

    public string GetRotateBgSpinePrefabPath()
    {
        return "ChristmasThemes/Effects/Rotate/EffectPanel";
    }

    public string GetNumberCellBgDefaultTexturePath()
    {
        return "ChristmasThemes/CellBg/Panel_Blue";
    }

    public string GetNumberCellBgHighlightTexturePath()
    {
        return "ChristmasThemes/CellBg/Panel_Green";
    }

    public string GetNumberTexturePath()
    {
        return "ChristmasThemes/Numbers/Atari_No{0}";
    }

    public string GetBingoDefaultNumberTexturePath()
    {
        return "ChristmasThemes/Numbers/Bingo_default_No{0}";
    }

    public string GetBingoSelectedNumberTexturePath()
    {
        return "ChristmasThemes/Numbers/Bingo_selected_No{0}";
    }

    public string GetThemeBgTexturePath()
    {
        return "ChristmasThemes/bg";
    }

    public string GetThemeBgDecorateTexturePath()
    {
        return "DefaultTheme/none";
    }

    public string GetThemeGameViewTopDecorateTexturePaht()
    {
        return "DefaultTheme/none";
    }


    public string GetNormalBgmPath()
    {
        return "ChristmasThemes/Audio/bgm";
    }

    public string GetWillReachBgmPath()
    {
        return "ChristmasThemes/Audio/will_reach_sample";
    }

    public string GetBingoAudioPath()
    {
        return "ChristmasThemes/Audio/bingo_sample";
    }

    public string GetReachAudioPath()
    {
        return "ChristmasThemes/Audio/Reach_click_sample";
    }

    public string GetNumberCheckDownAudioPath()
    {
        return "ChristmasThemes/Audio/Number_check_sample";
    }

    public string GetNumberRotateAudioPath()
    {
        return "ChristmasThemes/Audio/Number_rotate_sample";
    }
}
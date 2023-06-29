// AppConfig singleton

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppConfig
{
    public static string __REOPEN_DATA__ = "__REOPEN_GAME_DATA__";
    private static AppConfig _instance;
    public static AppConfig Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new AppConfig();
            }
            return _instance;
        }
    }

    private int _cellCount = 0;

    public int MaxCellCount {
        set
        {
            _cellCount = value;
            PreferencesStorage.SaveInt("__MAX_CELL_COUNT__", _cellCount);
        }
        get 
        {
            if (_cellCount == 0) {
                _cellCount = PreferencesStorage.ReadInt("__MAX_CELL_COUNT__", 75);
            }
            return _cellCount;
        }
    }

    private int _bgmVolume = -100;

    public int BGMVolume {
        set
        {
            _bgmVolume = value;
            PreferencesStorage.SaveInt("__BGM_VOLUME__", value);
        }
        get
        {
            if (_bgmVolume == -100) {
                _bgmVolume = PreferencesStorage.ReadInt("__BGM_VOLUME__", 5);
            }
            return _bgmVolume;
        }
    }

    private int _effectVolume = -100;
    public int EffectVolume {
        set
        {
            _effectVolume = value;
            PreferencesStorage.SaveInt("__BGM_VOLUME__", value);
        }
        get
        {
            if (_effectVolume == -100) {
                _effectVolume = PreferencesStorage.ReadInt("__BGM_VOLUME__", 5);
            }
            return _effectVolume;
        }
    }

    private GameDataHandler _gameData;

    public GameDataHandler GameData {
        set
        {
            _gameData = value;
            PreferencesStorage.SaveString(__REOPEN_DATA__, JsonSerializablity.Serialize(value));
        }
        get
        {
            if (_gameData == null) {
                var gameDataStr = PreferencesStorage.ReadString(__REOPEN_DATA__, null);
                if (gameDataStr != null && gameDataStr.Length > 0)
                    _gameData = JsonSerializablity.Deserialize<GameDataHandler>(gameDataStr);
            }
            return _gameData;
        }
    }
}
using System;

[Serializable]
public enum SoundType
{
    None,

    #region UI
    SFX_UI_Next_Text,
    SFX_UI_Text_Off,

    SFX_UI_Btn_On,
    SFX_UI_Btn_Out,
    SFX_UI_Btn_Click,

    SFX_UI_CountinewClick,
    SFX_UI_GameExit,

    SFX_UI_GameStartButtonClick,
    SFX_UI_GameStartButtonOn,
    SFX_UI_GameStartButtonOut,

    SFX_UI_RestartClick,
    SFX_UI_Peuse,
    SFX_UI_Scroll,
    SFX_UI_OptionReset,
    SFX_UI_BackClick,

    #endregion

    #region BGM
    BGM_Title,
    BGM_Stage_00,
    BGM_Stage_01,
    BGM_Stage_02,

    AMB_Stage_00,
    AMB_Stage_01,
    AMB_Stage_02,

    #endregion

    #region GameProcess
    GP_GameOver,
    #endregion

    #region Weapon

    SFX_Weapon_Sword_0,
    SFX_Weapon_Sword_1,
    SFX_Weapon_Boomerang_Active,
    SFX_Weapon_Boomerang_Projectile,
    SFX_Weapon_Bow_Active,
    SFX_Weapon_Bow_Shoot,
    SFX_Weapon_Bow_Hit,
    SFX_Weapon_Katana,
    SFX_Weapon_Shuriken,
    SFX_Weapon_Shuriken_Hit,
    SFX_Weapon_Dagger,

    SFX_Ultimate_Sword,
    SFX_Ultimate_Bow,
    SFX_Ultimate_Dagger,
    SFX_Ultimate_Dagger_Last,

    #endregion

    #region Player

    SFX_Player_Footstep,
    SFX_Player_Jump,
    SFX_Player_Hit,
    SFX_Get_Piece,
    SFX_Create_Weapon,
    SFX_Slide,
    SFX_Player_Dash,
    #endregion

    #region Enemy MS
    SFX_MS_101_Attack,
    //SFX_MS_101_Spawn,
    SFX_MS_101_Crash,
    SFX_MS_101_Hit,

    SFX_MS_201_Attack,
    SFX_MS_201_Crash,
    SFX_MS_201_Spawn,

    SFX_MS_104_Attack,
    SFX_MS_104_Dead,
    SFX_MS_104_Expend,
    SFX_MS_104_Spawn,

    SFX_MS_105_Attack,
    SFX_MS_105_Spawn,
    SFX_MS_105_Dead,

    SFX_MS_301_Attack,
    SFX_MS_301_Dead,
    SFX_MS_301_IdleMove,
    SFX_MS_301_Expend,

    SFX_MS_202_Attack,
    SFX_MS_202_Drop,
    #endregion

    #region Enemy ES
    SFX_ES_101_Hit,
    SFX_ES_101_Spawn,
    SFX_ES_101_Rush,
    SFX_ES_101_Dead,
    SFX_ES_101_WallBuff,

    SFX_ES_102_Hit,
    SFX_ES_102_Ms_Spawn,
    SFX_ES_102_Star_Dead,
    SFX_ES_102_Spawn,
    SFX_ES_102_Dead,

    SFX_ES_101_Ms_101_Spawn,

    SFX_ES_201_Ms104Spawn,
    SFX_ES_201_Ms202Spawn,
    SFX_ES_201_Inhale,
    SFX_ES_201_Inhale_Shot,
    SFX_ES_201_Spawn,
    SFX_ES_201_Hit,
    SFX_ES_201_Dead,

    SFX_ES_202_Clone_Fail,
    SFX_ES_202_Clone_Groggy,
    SFX_ES_202_Clone_Self,
    SFX_ES_202_Ms104Spawn,
    SFX_ES_202_Ms202Spawn,
    SFX_ES_202_Spawn,
    SFX_ES_202_Hit,
    SFX_ES_202_Dead,

    #endregion

    #region Enemy Boss
    SFX_BS_01_Spawn,
    SFX_BS_01_Dead,
    SFX_BS_01_Spawn_Rush,
    SFX_BS_01_Spawn_Moon,
    SFX_BS_01_Spawn_Star,
    SFX_BS_01_KeyInput_Intro,
    SFX_BS_01_keyInput_Clear,
    SFX_BS_01_keyInput_Fail,
    SFX_BS_01_KeyInput_Ok,
    SFX_BS_01_KeyInput_Wrong,
    SFX_BS_01_BodyThump,

    SFX_BS_02_Special_Cast,
    SFX_BS_02_Special_Fail,
    SFX_BS_02_Special_OK,
    SFX_BS_02_Clone_Self,
    SFX_BS_02_Copy,
    SFX_BS_02_Dead,
    SFX_BS_02_Faint,
    SFX_BS_02_Hit,
    SFX_BS_02_Idle,
    SFX_BS_02_Inhale,
    SFX_BS_02_Inhale_Shot,
    SFX_BS_02_Ms104_Spawn,
    SFX_BS_02_Ms105_Spawn,
    SFX_BS_02_Ms201_Spawn,
    SFX_BS_02_Ms202_Spawn,
    SFX_BS_02_MS301_Spawn,
    SFX_BS_02_Spawn,
    SFX_BS_02_Spawn_Ver2,

    #endregion

    #region Temp
    SFX_Mob_Hit,
    #endregion

    #region SnapShot
    SS_GamePause,
    SS_Reverb,
    #endregion

    #region Object
    SFX_Stage0_BoxHit,
    SFX_Stage0_BoxDestroy,

    SFX_Bs_02_Object_Inhale_Sword,
    SFX_Bs_02_Object_Inhale_Bow,
    SFX_Bs_02_Object_Inhale_Dagger,

    SFX_Object_InhaleBowBoxDestroy,
    SFX_Object_InhaleDaggerBoxDestroy,
    SFX_Object_InhaleSwordBoxDestroy,
    SFX_Object_BoxHit,
    SFX_Object_Shoot,
    #endregion
}

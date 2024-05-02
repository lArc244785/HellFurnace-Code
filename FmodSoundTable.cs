using System.Collections.Generic;

public static class FmodSoundTable
{
    private static Dictionary<SoundType, FmodEvent> mSoundTable = new()
    {
        {SoundType.BGM_Title, new FmodEvent("event:/BGM/Stage_Title") },
        {SoundType.BGM_Stage_00, new FmodEvent("event:/BGM/Stage_00")},
        {SoundType.BGM_Stage_01, new FmodEvent("event:/BGM/Stage_01")},
        {SoundType.BGM_Stage_02, new FmodEvent("event:/BGM/Stage_02")},

        {SoundType.AMB_Stage_00, new FmodEvent("event:/AMB/Stage_Master/Stage00")},
        {SoundType.AMB_Stage_01, new FmodEvent("event:/AMB/Stage_Master/Stage01")},
        {SoundType.AMB_Stage_02, new FmodEvent("event:/AMB/Stage_Master/Stage02")},

        {SoundType.SFX_Weapon_Sword_0, new FmodEvent("event:/Player/Weapon_Master/011") },
        {SoundType.SFX_Weapon_Sword_1, new FmodEvent("event:/Player/Weapon_Master/011_type2") },

        {SoundType.SFX_Weapon_Boomerang_Active, new FmodEvent("event:/Player/Weapon_Master/012_active") },
        {SoundType.SFX_Weapon_Boomerang_Projectile, new FmodEvent("event:/Player/Weapon_Master/012") },

        {SoundType.SFX_Weapon_Katana, new FmodEvent("event:/Player/Weapon_Master/013") },

        {SoundType.SFX_Weapon_Bow_Active, new FmodEvent("event:/Player/Weapon_Master/022_active") },
        {SoundType.SFX_Weapon_Bow_Shoot, new FmodEvent("event:/Player/Weapon_Master/022_hit") },
        {SoundType.SFX_Weapon_Bow_Hit, new FmodEvent("event:/Player/Weapon_Master/022_shoot") },

        {SoundType.SFX_Weapon_Shuriken, new FmodEvent("event:/Player/Weapon_Master/023") },
        {SoundType.SFX_Weapon_Shuriken_Hit, new FmodEvent("event:/Player/Weapon_Master/023_Destroy") },

        {SoundType.SFX_Weapon_Dagger, new FmodEvent("event:/Player/Weapon_Master/033") },

        { SoundType.SFX_Ultimate_Sword, new FmodEvent("event:/Player/Weapon_Master/Ultimate_Sword")},
        { SoundType.SFX_Ultimate_Bow, new FmodEvent("event:/Player/Weapon_Master/Ultimate_Bow")},
        { SoundType.SFX_Ultimate_Dagger, new FmodEvent("event:/Player/Weapon_Master/Ultimate_Dagger")},
        { SoundType.SFX_Ultimate_Dagger_Last, new FmodEvent("event:/Player/Weapon_Master/Ultimate_Dagger_Last")},


        {SoundType.SFX_Player_Footstep, new FmodEvent("event:/Player/Move_Master/FootStep")},
        {SoundType.SFX_Player_Jump, new FmodEvent("event:/Player/Move_Master/Jump") },
        {SoundType.SFX_Player_Hit, new FmodEvent("event:/Player/Hit") },
        {SoundType.SFX_Get_Piece, new FmodEvent("event:/Player/Wepon_Master/Wepon_Pickup") },
        {SoundType.SFX_Create_Weapon, new FmodEvent("event:/Player/Wepon_Master/Wepon_Mix") },
        {SoundType.SFX_Slide, new FmodEvent("event:/Player/Move_Master/Slide")},
        {SoundType.SFX_Player_Dash, new FmodEvent("event:/Player/Move_Master/Dash") },


        {SoundType.SFX_MS_101_Attack, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_101/Ms_101_Attack") },
        {SoundType.SFX_MS_101_Crash, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_101/Ms_101_Crash") },
        {SoundType.SFX_MS_101_Hit, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_101/Ms_101_Hit") },
		//{SoundType.SFX_MS_101_Spawn, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_101/Ms_101_Spawn") },

		{SoundType.SFX_MS_104_Attack, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_104/Ms_104_Attack") },
        {SoundType.SFX_MS_104_Dead, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_104/Ms_104_Dead") },
        {SoundType.SFX_MS_104_Expend, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_104/Ms_104_Expend") },
        {SoundType.SFX_MS_104_Spawn, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_104/Ms_104_Spawn") },

        {SoundType.SFX_MS_105_Attack, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_105/Ms_105_Attack") },
        {SoundType.SFX_MS_105_Spawn, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_105/Ms_105_Spawn") },
        {SoundType.SFX_MS_105_Dead, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_105/Ms_105_Dead") },

        {SoundType.SFX_MS_301_Attack, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_301/Ms_301_Attack") },
        {SoundType.SFX_MS_301_Dead, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_301/Ms_301_Dead") },
        {SoundType.SFX_MS_301_IdleMove, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_301/Ms_301_IdleMove") },
        {SoundType.SFX_MS_301_Expend, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_301/Ms_301_Spawn") },

        {SoundType.SFX_MS_202_Attack, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_202/Ms_202_Attack") },
        {SoundType.SFX_MS_202_Drop, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_202/Ms_202_Drop") },

        {SoundType.SFX_MS_201_Attack, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_201/Ms_201_Attack") },
        {SoundType.SFX_MS_201_Spawn, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_201/Ms_201_Spawn") },
        {SoundType.SFX_MS_201_Crash, new FmodEvent("event:/SFX/Mob/Ms_Master/Ms_201/Ms_201_Crash") },

        {SoundType.SFX_ES_101_Hit, new FmodEvent("event:/SFX/Mob/Es_Master/Es_101/Es_101_Hit")},
        {SoundType.SFX_ES_101_Spawn, new FmodEvent("event:/SFX/Mob/Es_Master/Es_101/Es_101_Spawn")},
        {SoundType.SFX_ES_101_Rush, new FmodEvent("event:/SFX/Mob/Es_Master/Es_101/Es_101_Rush")},
        {SoundType.SFX_ES_101_Dead, new FmodEvent("event:/SFX/Mob/Es_Master/Es_101/Es_101_Dead")},
        {SoundType.SFX_ES_101_WallBuff, new FmodEvent("event:/SFX/Mob/Es_Master/Es_101/Es_101_WallBuff") },

        {SoundType.SFX_ES_101_Ms_101_Spawn, new FmodEvent("event:/SFX/Mob/Es_Master/Es_101/Es_101Ms_101Spawn") },


        {SoundType.SFX_BS_01_Spawn, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_01/Bs_01_Spawn")},
        {SoundType.SFX_BS_01_Dead, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_01/Bs_01_Dead")},

        {SoundType.SFX_BS_01_Spawn_Rush, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_01/Bs_01_Spawn_Rush")},
        {SoundType.SFX_BS_01_Spawn_Moon, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_01/Bs_01_Spawn_Es102")},
        {SoundType.SFX_BS_01_Spawn_Star, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_01/Bs_01_Spawn_Es102")},

        {SoundType.SFX_BS_01_KeyInput_Intro, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_01/Keyinput/Bs_01_Keyinput_intro")},
        {SoundType.SFX_BS_01_keyInput_Clear, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_01/Keyinput/Bs_01_Keyinput_Clear")},
        {SoundType.SFX_BS_01_keyInput_Fail, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_01/Keyinput/Bs_01_Keyinput_Fail")},
        {SoundType.SFX_BS_01_KeyInput_Ok, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_01/Keyinput/Bs_01_Keyinput_Ok")},
        {SoundType.SFX_BS_01_KeyInput_Wrong, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_01/Keyinput/Bs_01_Keyinput_Wrong")},
        {SoundType.SFX_BS_01_BodyThump, new FmodEvent("event:/Player/Move_Master/Body_thump") },

        {SoundType.SFX_ES_102_Hit, new FmodEvent("event:/SFX/Mob/Es_Master/Es_02/Es_02_Hit")},
        {SoundType.SFX_ES_102_Star_Dead, new FmodEvent("event:/SFX/Mob/Es_Master/Es_02/Es_02_Star_Dead")},
        {SoundType.SFX_ES_102_Ms_Spawn, new FmodEvent("event:/SFX/Mob/Es_Master/Es_02/Es_02_Ms_Spawn")},
        {SoundType.SFX_ES_102_Spawn, new FmodEvent("event:/SFX/Mob/Es_Master/Es_02/Es_02_Spawn")},
        {SoundType.SFX_ES_102_Dead, new FmodEvent("event:/SFX/Mob/Es_Master/Es_02/Es_02_Dead")},

        {SoundType.SFX_Mob_Hit, new FmodEvent("event:/SFX/Mob/Mob_Hit_Type_Living")},

        {SoundType.SFX_UI_Next_Text, new FmodEvent("event:/UI/Script_Master/Next_Text")},
        {SoundType.SFX_UI_Text_Off, new FmodEvent("event:/UI/Script_Master/Text_Off")},

        {SoundType.SS_GamePause,  new FmodEvent("snapshot:/Game_Status/Game_Pause") },
        {SoundType.SS_Reverb, new FmodEvent("snapshot:/Stage00_Reverb")},

        {SoundType.GP_GameOver, new FmodEvent("event:/BGM/Gameover") },

        {SoundType.SFX_UI_Btn_On, new FmodEvent("event:/UI/Button/ButtonOn") },
        {SoundType.SFX_UI_Btn_Out, new FmodEvent("event:/UI/Button/ButtonOut") },
        {SoundType.SFX_UI_Btn_Click, new FmodEvent("event:/UI/Button/ButtonClick") },

        {SoundType.SFX_UI_CountinewClick, new FmodEvent("event:/UI/Button/CountinewClick") },
        {SoundType.SFX_UI_GameExit, new FmodEvent("event:/UI/Button/GameExit") },


        {SoundType.SFX_UI_GameStartButtonClick, new FmodEvent("event:/UI/Button/GameStartButtonClick") },
        {SoundType.SFX_UI_GameStartButtonOn, new FmodEvent("event:/UI/Button/GameStartButtonOn") },
        {SoundType.SFX_UI_GameStartButtonOut, new FmodEvent("event:/UI/Button/GameStartButtonOut") },

        {SoundType.SFX_UI_RestartClick, new FmodEvent("event:/UI/Button/RestartClick") },

        {SoundType.SFX_UI_BackClick, new FmodEvent("event:/UI/Option/BackClick") },
        {SoundType.SFX_UI_OptionReset, new FmodEvent("event:/UI/Option/OptionResetClick") },
        {SoundType.SFX_UI_Peuse, new FmodEvent("event:/UI/Option/Peuse") },
		//{SoundType.SFX_UI_Scroll, new FmodEvent("event:/UI/Option/Scroll") },

        {SoundType.SFX_ES_201_Ms104Spawn, new FmodEvent("event:/SFX/Mob/Es_Master/Es_201/Es_201_Ms104_Spawn") },
        {SoundType.SFX_ES_201_Ms202Spawn, new FmodEvent("event:/SFX/Mob/Es_Master/Es_201/Es_201_Ms202_Spawn") },
        {SoundType.SFX_ES_201_Inhale, new FmodEvent("event:/SFX/Mob/Es_Master/Es_201/Es_201_Inhale") },
        {SoundType.SFX_ES_201_Inhale_Shot, new FmodEvent("event:/SFX/Mob/Es_Master/Es_201/Es_201_Inhale_shot") },
        {SoundType.SFX_ES_201_Dead, new FmodEvent("event:/SFX/Mob/Es_Master/Es_201/Es_201_Dead") },
        {SoundType.SFX_ES_201_Spawn, new FmodEvent("event:/SFX/Mob/Es_Master/Es_201/Es_201_Spawn") },
        {SoundType.SFX_ES_201_Hit, new FmodEvent("event:/SFX/Mob/Es_Master/Es_201/Es_201_Hit") },

        {SoundType.SFX_ES_202_Ms104Spawn, new FmodEvent("event:/SFX/Mob/Es_Master/Es_202/Es_202_Ms104_Spawn") },
        {SoundType.SFX_ES_202_Ms202Spawn, new FmodEvent("event:/SFX/Mob/Es_Master/Es_202/Es_202_Ms202_Spawn") },
        {SoundType.SFX_ES_202_Clone_Fail, new FmodEvent("event:/SFX/Mob/Es_Master/Es_202/Es_202_Clone_Fail") },
        {SoundType.SFX_ES_202_Clone_Groggy, new FmodEvent("event:/SFX/Mob/Es_Master/Es_202/Es_202_Clone_Groggy") },
        {SoundType.SFX_ES_202_Clone_Self, new FmodEvent("event:/SFX/Mob/Es_Master/Es_202/Es_202_Clone_Self") },
        {SoundType.SFX_ES_202_Dead, new FmodEvent("event:/SFX/Mob/Es_Master/Es_202/Es_202_Dead") },
        {SoundType.SFX_ES_202_Spawn, new FmodEvent("event:/SFX/Mob/Es_Master/Es_202/Es_202_Spawn") },
        {SoundType.SFX_ES_202_Hit, new FmodEvent("event:/SFX/Mob/Es_Master/Es_202/Es_202_Hit") },

        {SoundType.SFX_BS_02_Special_Cast, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Special/Bs_02_Special_Cast")},
        {SoundType.SFX_BS_02_Special_Fail, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Special/Bs_02_Special_Fail")},
        {SoundType.SFX_BS_02_Special_OK, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Special/Bs_02_Special_Ok")},
        {SoundType.SFX_BS_02_Clone_Self, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Clone_Self")},
        {SoundType.SFX_BS_02_Copy, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Copy")},
        {SoundType.SFX_BS_02_Dead, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Dead")},
        {SoundType.SFX_BS_02_Faint, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Faint")},
        {SoundType.SFX_BS_02_Hit, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Hit")},
        {SoundType.SFX_BS_02_Idle, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Idle")},
        {SoundType.SFX_BS_02_Inhale, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Inhale")},
        {SoundType.SFX_BS_02_Inhale_Shot, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Inhale_shot")},
        {SoundType.SFX_BS_02_Ms104_Spawn, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Ms104_Spawn")},
        {SoundType.SFX_BS_02_Ms105_Spawn, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Ms105_Spawn")},
        {SoundType.SFX_BS_02_Ms201_Spawn, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Ms201_Spawn")},
        {SoundType.SFX_BS_02_Ms202_Spawn, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Ms202_Spawn")},
        {SoundType.SFX_BS_02_MS301_Spawn, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Ms301_Spawn")},
        {SoundType.SFX_BS_02_Spawn, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Spawn")},
        {SoundType.SFX_BS_02_Spawn_Ver2, new FmodEvent("event:/SFX/Mob/Bs_Master/Bs_02/Bs_02_Spawn_Ver2")},


        {SoundType.SFX_Stage0_BoxHit, new FmodEvent("event:/SFX/Object/Stage00_BoxHit")},
        {SoundType.SFX_Stage0_BoxDestroy, new FmodEvent("event:/SFX/Object/Stage00_BoxDestroy") },

        {SoundType.SFX_Bs_02_Object_Inhale_Sword, new FmodEvent("event:/SFX/Object/Bs02_SpecialWepon/InHaleSwordWepon") },
        {SoundType.SFX_Bs_02_Object_Inhale_Bow, new FmodEvent("event:/SFX/Object/Bs02_SpecialWepon/InHaleBowWepon") },
        {SoundType.SFX_Bs_02_Object_Inhale_Dagger, new FmodEvent("event:/SFX/Object/Bs02_SpecialWepon/InHaleDaggerWepon") },

        {SoundType.SFX_Object_InhaleBowBoxDestroy, new FmodEvent("event:/SFX/Object/Stage02_InhaleBowBoxDestroy")},
        {SoundType.SFX_Object_InhaleDaggerBoxDestroy, new FmodEvent("event:/SFX/Object/Stage02_InhaleDaggerBoxDestroy")},
        {SoundType.SFX_Object_InhaleSwordBoxDestroy, new FmodEvent("event:/SFX/Object/Stage02_InhaleSwordBoxDestroy")},
        {SoundType.SFX_Object_BoxHit, new FmodEvent("event:/SFX/Mob/Es_Master/Box_hit")},
        {SoundType.SFX_Object_Shoot, new FmodEvent("event:/SFX/Mob/Es_Master/Box_Shoot") }



    };

    public static FmodEvent GetFmodEvent(SoundType type)
    {
        return mSoundTable[type];
    }
}

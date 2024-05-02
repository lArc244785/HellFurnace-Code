using FMOD.Studio;
using System.Collections;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class FmodSoundManager : Singleton<FmodSoundManager>
{
	private const string MASTER_PATH = "vca:/Master";
	private const string BGM_PATH = "vca:/Music";
	private const string AMBIENCE_PATH = "vca:/Ambient";
	private const string SFX_PATH = "vca:/SFX";

	private FMOD.Studio.VCA _master;
	private FMOD.Studio.VCA _bgm;
	private FMOD.Studio.VCA _sfx;
	private FMOD.Studio.VCA _ambient;

	private FmodEvent _currentBGM;

	public float MasterVolume
	{
		get
		{
			_master.getVolume(out var volume);
			return volume;
		}
		set
		{
			value = Mathf.Clamp(value, 0.0f, 1.0f);
			_master.setVolume(value);
		}
	}

	public float BgmVolume
	{
		get
		{
			_bgm.getVolume(out var volume);
			return volume;
		}
		set
		{
			value = Mathf.Clamp(value, 0.0f, 1.0f);
			_bgm.setVolume(value);
		}
	}

	public float SfxVolume
	{
		get
		{
			_sfx.getVolume(out var volume);
			return volume;
		}
		set
		{
			value = Mathf.Clamp(value, 0.0f, 1.0f);
			_sfx.setVolume(value);
		}
	}

	public float AmbientVolume
	{
		get
		{
			_ambient.getVolume(out var volume);
			return volume;
		}
		set
		{
			value = Mathf.Clamp(value, 0.0f, 1.0f);
			_ambient.setVolume(value);
		}
	}

	private void Awake()
	{
		Init();
	}

	protected override bool Init()
	{
		var isInit = base.Init();
		if (!isInit)
		{
			return false;
		}

		_master = FMODUnity.RuntimeManager.GetVCA(MASTER_PATH);
		_bgm = FMODUnity.RuntimeManager.GetVCA(BGM_PATH);
		_ambient = FMODUnity.RuntimeManager.GetVCA(AMBIENCE_PATH);
		_sfx = FMODUnity.RuntimeManager.GetVCA(SFX_PATH);

		return true;
	}

	public void Play(SoundType type, params SoundParameter[] parmeters)
	{
		FmodSoundTable.GetFmodEvent(type).Play(parmeters);
	}

	public void Play(SoundType type, Vector2 position, params SoundParameter[] parmeters)
	{
		FmodSoundTable.GetFmodEvent(type).PlayToPosition(position, parmeters);
	}

	public void PlayBGM(SoundType type, params SoundParameter[] parmeters)
	{
		if (_currentBGM != null)
		{
			_currentBGM.Stop(STOP_MODE.IMMEDIATE);
		}

		_currentBGM = FmodSoundTable.GetFmodEvent(type);
		_currentBGM.Play(parmeters);
	}

	public void StopBGM(STOP_MODE mode)
	{
		if (_currentBGM != null)
			_currentBGM.Stop(mode);

		_currentBGM = null;
	}

	public void AllStopSFX()
    {
		FMODUnity.RuntimeManager.GetBus("bus:/SFX").stopAllEvents(STOP_MODE.IMMEDIATE);
    }
	public void SetPauseSFX(bool check)
	{
		FMODUnity.RuntimeManager.GetBus("bus:/SFX").setPaused(check);
	}

	public void SetBGMParameter(string name, float value)
	{
		_currentBGM.SetParmater(name, value);
	}

	/// <summary>
	/// 플레이 중인 사운드에 파라미터를 변경합니다. 새로 플레이를 하게 되면 설정 파라미터가 초기화 됩니다.
	/// </summary>
	public void SetParameter(SoundType type, params SoundParameter[] parmeters)
	{
		foreach (var parameter in parmeters)
		{
#if UNITY_EDITOR
			//Debug.Log($"|FMOD| SetParmater {type} {parameter.Name} {parameter.Value}");
#endif
			FmodSoundTable.GetFmodEvent(type).SetParmater(parameter.Name, parameter.Value);
		}
	}


	/// <summary> 사운드 테이블에 있는 사운드를 별도로 관리할 때 사용합니다. </summary>
	public FmodEvent InstanceSound(SoundType type)
	{
		var fmodEvent = FmodSoundTable.GetFmodEvent(type);
		return new FmodEvent(fmodEvent.Path);
	}

	public void Stop(SoundType type, FMOD.Studio.STOP_MODE mode)
	{
#if UNITY_EDITOR
		//Debug.Log($"|FMOD| Stop {type} {mode}");
#endif
		FmodSoundTable.GetFmodEvent(type).Stop(mode);
	}

	public void Pause(SoundType type)
	{
		FmodSoundTable.GetFmodEvent(type).Pause();
	}

	public void Resume(SoundType type)
	{
		FmodSoundTable.GetFmodEvent(type).Resume();
	}

	public bool IsCurrentlyPlay(SoundType type)
	{
		return FmodSoundTable.GetFmodEvent(type).IsPlaying();
	}

	public void SetShapShot(SoundType type, float intensity)
	{
		//SnapType 아니면 리턴
		if (!(type == SoundType.SS_GamePause ||
			type == SoundType.SS_Reverb))
		{
			Debug.LogError($"SnapShotType이 아닙니다. {type}");
			return;
		}

		intensity = Mathf.Clamp(intensity, 0.0f, 100.0f);
		FmodEvent snapShot = FmodSoundTable.GetFmodEvent(type);

		if (!snapShot.IsPlaying())
		{
			snapShot.Play();
		}

		snapShot.SetParmater("Intensity", intensity);
	}

	public void StopShapShot(SoundType type)
	{
		//SnapType 아니면 리턴
		if (!(type == SoundType.SS_GamePause ||
			type == SoundType.SS_Reverb))
		{
			Debug.LogError($"SnapShotType이 아닙니다. {type}");
			return;
		}

		FmodSoundTable.GetFmodEvent(type).Stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
	}

	/// <summary>
	/// 진행 중인 사운드를 자연스럽게 멈춘 이후 새로운 사운드를 출력합니다.
	/// </summary>
	public void SoundStopAndPlay(SoundType stopSoundType, SoundType playSountType)
	{
		StartCoroutine(SoundStopAndPlayCorutine(stopSoundType, playSountType));
	}


	private IEnumerator SoundStopAndPlayCorutine(SoundType stopSoundType, SoundType playSountType)
	{
		var stopSoundEvnet = FmodSoundTable.GetFmodEvent(stopSoundType);
		var startSoundEvent = FmodSoundTable.GetFmodEvent(playSountType);

		stopSoundEvnet.Stop(STOP_MODE.ALLOWFADEOUT);

		while (stopSoundEvnet.IsPlaying())
			yield return null;

		startSoundEvent.Play();
	}

}
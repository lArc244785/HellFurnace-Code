using FMOD.Studio;
using FMODUnity;
using UnityEngine;

public class FmodEvent
{
	public string Path { private set; get; }

	private EventDescription _description;
	private EventInstance _instance;
	
	private bool _isOneShot;

	public FmodEvent(string path)
	{
		Path = path;
		_description = RuntimeManager.GetEventDescription(path);
		_description.getPath(out var desPath);
		_description.isOneshot(out _isOneShot);
	}

	/// <summary> FMOD�� ������ �Ķ���͸� �����մϴ�.</summary>
	/// <param name="name">FMOD�� ���õǾ��ִ� �Ķ���� �̸�</param>
	public void SetParmater(string name, float value)
	{
		FMOD.RESULT result = _description.getParameterDescriptionByName(name, out var parameDes);
		if (result == FMOD.RESULT.ERR_EVENT_NOTFOUND)
		{
			_description.getPath(out var path);
			Debug.LogError($"The [{path}] Sound is have not parameter : {name}");
			return;
		}

		if (_instance.isValid())
		{
			_instance.setParameterByName(name, value);
		}
	}

	#region Play

	public void Play(params SoundParameter[] parmeters)
	{
		CreateInstance();

		foreach (SoundParameter p in parmeters)
		{
			SetParmater(p.Name, p.Value);
		}

		_instance.start();
	}

	/// <summary>
	/// �ش� ��ġ�� ���带 ����մϴ�.
	/// </summary>
	public void PlayToPosition(Vector2 position, params SoundParameter[] parmeters)
	{
		CreateInstance();

		foreach (SoundParameter p in parmeters)
		{
			SetParmater(p.Name, p.Value);
		}

		_instance.set3DAttributes(RuntimeUtils.To3DAttributes(position));
		_instance.start();
	}

	/// <summary>
	/// �ش� ���ӿ�����Ʈ�� ������ ���ؼ� �� ��ġ�� ���带 ����մϴ�.
	/// </summary>
	/// <param name="isParameterReset">�ش� ���忡 �⺻ �Ķ���� ������ �� ���ΰ�</param>
	public void PlayToTarget(Transform target, Rigidbody2D rig2D = null, params SoundParameter[] parmeters)
	{
		if (!_instance.isValid())
		{
			CreateInstance();
		}

		foreach (SoundParameter p in parmeters)
		{
			SetParmater(p.Name, p.Value);
		}

		RuntimeManager.AttachInstanceToGameObject(_instance, target, rig2D);
		_instance.start();
	}

	/// <summary> ���� ���� ���忡 �ʿ��� �����͸� ������Ʈ �մϴ�.</summary>
	public void Update3DAttribute(Transform targetTransfrom, Rigidbody2D targetRig2D = null)
	{
		if (_instance.isValid())
		{
			_instance.set3DAttributes(RuntimeUtils.To3DAttributes(targetTransfrom, targetRig2D));
		}
	}

	#endregion

	public void Stop(FMOD.Studio.STOP_MODE mode)
	{
		if (_instance.isValid())
		{
			_instance.stop(mode);
		}
	}

	public void Pause()
	{
		if (_instance.isValid())
		{
			_instance.setPaused(true);
		}
	}

	public void Resume()
	{
		if (_instance.isValid())
		{
			_instance.setPaused(false);
		}
	}

	private void CreateInstance()
	{
		if (_instance.isValid())
		{
			_instance.release();
			_instance.clearHandle();
		}

		_description.createInstance(out _instance);
	}

	public void Clear()
	{
		if (_instance.isValid())
		{
			_instance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
			_instance.release();
			_instance.clearHandle();
		}
	}

	public bool IsPlaying()
	{
		if (_instance.isValid())
		{
			PLAYBACK_STATE playbackState;
			_instance.getPlaybackState(out playbackState);
			return (playbackState != PLAYBACK_STATE.STOPPED);
		}
		return false;
	}
}


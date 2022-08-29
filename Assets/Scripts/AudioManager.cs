using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private List<AudioSource> _bgmAudioSource;
    public bool isAudioEnabled = false;
     private static AudioManager _instance;
    private AudioSource _sceneAudio;
    private int _audioIndex;

    public static AudioManager Instance { get { return _instance; } }
    private void Awake() 
    {   
       if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
            _audioIndex = Random.Range(0, _bgmAudioSource.Count);
            DontDestroyOnLoad(this);
        }
    }
    public void PlayBgm()
    {

        _sceneAudio = _bgmAudioSource[_audioIndex];
        _sceneAudio.Play();

    }

    public void UnloadUnused()
    {
        for(int i = 0; i < _bgmAudioSource.Count; i++)
        {
            if(i!=_audioIndex)
            Destroy(_bgmAudioSource[i].gameObject);
        }
    }

    public void UnloadAll()
    {
        foreach(AudioSource audio in _bgmAudioSource)
        {
            Destroy(audio.gameObject);
        }
    }
}

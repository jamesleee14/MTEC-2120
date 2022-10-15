using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Audio;

public class MidiKey : MonoBehaviour
{
     int tone, octave;
     PianoPitcher pitcher;

    GameObject piano;
    AudioClip[] clip;
    AudioMixerGroup group;
    public AudioSource curr;
    float volume = 0.25f;
    float scale = Mathf.Pow(2f, 1.0f / 12f);

    void Start()
    {

        tone = GetComponent<PianoKey>().tone;
        octave = GetComponent<PianoKey>().octave;
        pitcher = GetComponent<PianoKey>().pitcher;

        clip = pitcher.clip;
        group = pitcher.group;
        piano = pitcher.piano;

        InputSystem.onDeviceChange += DeviceChange;

        InputSystem.onDeviceChange += (device, change) =>
        {
            if (change != InputDeviceChange.Added) return;

            var midiDevice = device as Minis.MidiDevice;
            if (midiDevice == null) return;

            midiDevice.onWillNoteOn += PlayNoteDown;
            midiDevice.onWillNoteOff += PlayNoteUp;

            midiDevice.onWillNoteOn += (note, velocity) => {
                // Note that you can't use note.velocity because the state
                // hasn't been updated yet (as this is "will" event). The note
                // object is only useful to specify the target note (note
                // number, channel number, device name, etc.) Use the velocity
                // argument as an input note velocity.
                Debug.Log(string.Format(
                    "Note On #{0} ({1}) vel:{2:0.00} ch:{3} dev:'{4}'",
                    note.noteNumber,
                    note.shortDisplayName,
                    velocity,
                    (note.device as Minis.MidiDevice)?.channel,
                    note.device.description.product
                ));
            };

            midiDevice.onWillNoteOff += (note) => {
                Debug.Log(string.Format(
                    "Note Off #{0} ({1}) ch:{2} dev:'{3}'",
                    note.noteNumber,
                    note.shortDisplayName,
                    (note.device as Minis.MidiDevice)?.channel,
                    note.device.description.product
                ));
            };
        };
    }


    public void DeviceChange(InputDevice device, InputDeviceChange change)
    {
       

    }

    public void PlayNoteDown(Minis.MidiNoteControl midi, float val)
    {
       if((midi.noteNumber - (47+ (octave-1)*12) == tone))
        {
            PlayNote();
            GetComponent<Animator>().SetBool("down", true);

        }

    }


    public void PlayNoteUp(Minis.MidiNoteControl midi)
    {
    
            GetComponent<Animator>().SetBool("down", false);
            if (curr != null)
            {
                StartCoroutine(SoundFade(curr));
            }
        

    }

    void PlayNote() //this part instantiates new audiosources every time the button is pressed
    {
        curr = piano.AddComponent<AudioSource>() as AudioSource;
        curr.loop = true;
        curr.volume = volume;
        curr.outputAudioMixerGroup = group;
        curr.pitch = Mathf.Pow(scale, tone);
        curr.clip = clip[pitcher.octaveOffset + octave - 1];
        curr.Play();
    }
    IEnumerator SoundFade(AudioSource source) //sound fade after the button gets unpressed
    {
        float progress = 0;
        while (progress < 1)
        {
            progress += 0.75f * Time.deltaTime;
            if (source != null)
                source.volume = volume * 1 - progress;
            yield return null;
        }
        Destroy(source);
        yield return null;
    }
}

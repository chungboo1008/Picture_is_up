using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class NewBehaviourScript : MonoBehaviour, ITrackableEventHandler {

    [SerializeField]
    private TrackableBehaviour trackableBehaviour;

    [SerializeField]
    private UnityEvent onDetected;
    [SerializeField]
    private UnityEvent onTracked;
    [SerializeField]
    private UnityEvent onExtentedTracked;
    [SerializeField]
    private UnityEvent onNotFound;
    [SerializeField]
    private UnityEvent isStarting;

	// Use this for initialization
	void Start () {
        if (!this.trackableBehaviour)
            this.trackableBehaviour = GetComponent<TrackableBehaviour>();
        if (this.trackableBehaviour)
            this.trackableBehaviour.RegisterTrackableEventHandler(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //region ITrackableEventHandler implementation
    void ITrackableEventHandler.OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus){
            if (newStatus == TrackableBehaviour.Status.DETECTED)
                this.onDetected.Invoke();
            else if (newStatus == TrackableBehaviour.Status.TRACKED)
                this.onTracked.Invoke();
            else if (newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
                this.onExtentedTracked.Invoke();
            else if (previousStatus == TrackableBehaviour.Status.TRACKED
                && newStatus == TrackableBehaviour.Status.NO_POSE)
                this.onNotFound.Invoke();
            else
                this.isStarting.Invoke();
    }
    //endregion
}

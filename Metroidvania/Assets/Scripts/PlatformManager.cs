using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
	private Platform _leftPlatform;
	private Platform _centerPlatform;
	private Platform _rightPlatform;
	[SerializeField] Transform position;
	public int platforms;

	void Start()
	{
		InitilizePlatforms();
		CreatePlatform(position.position);
	}

	private void InitilizePlatforms()
	{
		_leftPlatform = Resources.Load("Platform0", typeof(Platform)) as Platform;
		_centerPlatform = Resources.Load("Platform1", typeof(Platform)) as Platform;
		_rightPlatform = Resources.Load("Platform2", typeof(Platform)) as Platform;
	}

	public void CreatePlatform(Vector3 pos)
	{
		var leftRenderer = _leftPlatform.GetComponent<SpriteRenderer>();
		var rightRenderer = _rightPlatform.GetComponent<SpriteRenderer>();
		var centerRenderer = _centerPlatform.GetComponent<SpriteRenderer>();

		Vector3 leftPos = new Vector3( -1 * (centerRenderer.bounds.extents.x + leftRenderer.bounds.extents.x),0);
		
		for(int i = 0;i<= platforms;i++){
			
			Vector3 centerPos = Vector3.zero;
			
			Vector3 extension = new Vector3 (centerRenderer.bounds.extents.x*i,0,0);
			centerPos += pos+extension;
			
		
			Instantiate(_centerPlatform, centerPos, Quaternion.identity);
		} 
		
		Vector3 rightPos = new Vector3(centerRenderer.bounds.extents.x*platforms + rightRenderer.bounds.extents.x,0);

		leftPos += pos;
		
		rightPos += pos;

		Instantiate(_leftPlatform, leftPos, Quaternion.identity);
		
		
		Instantiate(_rightPlatform, rightPos, Quaternion.identity);
	}
}

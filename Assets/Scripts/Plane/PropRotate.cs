using UnityEngine;

namespace Plane
{
	public class PropRotate : MonoBehaviour
	{
		[SerializeField] private float _speedRotate;
		[SerializeField] private Transform _propBlured;

		void Update()
		{
			_propBlured.Rotate(_speedRotate * Time.deltaTime, 0, 0);
		}
	}
}

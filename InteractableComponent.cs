using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.PirateCrew.Components
{
	public class InteractableComponent: MonoBehaviour
	{
		[SerializeField] private UnityEvent _action;
		public void Iteract()
		{
			_action?.Invoke();
		}
	}
}

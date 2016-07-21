using System;

namespace Kitware.VTK
{
	public class vtkObjectEventArgs : EventArgs
	{
		private vtkObject m_Caller;

		private uint m_EventId;

		private IntPtr m_CallData;

		public vtkObject Caller
		{
			get
			{
				return this.m_Caller;
			}
		}

		public uint EventId
		{
			get
			{
				return this.m_EventId;
			}
		}

		public IntPtr CallData
		{
			get
			{
				return this.m_CallData;
			}
		}

		public vtkObjectEventArgs(vtkObject caller, uint eventId, IntPtr callData)
		{
			this.m_Caller = caller;
			this.m_EventId = eventId;
			this.m_CallData = callData;
		}
	}
}

using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkObjectEventRelay : WrappedObject
	{
		public delegate void RelayHandler(IntPtr caller, uint eventId, IntPtr callData);

		public new const string MRFullTypeName = "Kitware.VTK.vtkObjectEventRelay";

		public new static readonly string MRClassNameKey;

		private vtkObject Sender;

		private uint EventId;

		private vtkObject.vtkObjectEventHandler EventImpl;

		private uint ObserverId;

		private vtkObjectEventRelay.RelayHandler RelayHandlerDelegate;

		static vtkObjectEventRelay()
		{
			vtkObjectEventRelay.MRClassNameKey = "class vtkObjectEventRelay";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkObjectEventRelay.MRClassNameKey, Type.GetType("Kitware.VTK.vtkObjectEventRelay"));
		}

		public vtkObjectEventRelay(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObjectEventRelay_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkObjectEventRelay(vtkObject sender, uint eventId) : base(IntPtr.Zero, true, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkObjectEventRelay.vtkObjectEventRelay_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
			this.Sender = sender;
			this.EventId = eventId;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObjectEventRelay_Delete(HandleRef pThis);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkObjectEventRelay.vtkObjectEventRelay_Delete(base.GetCppThis());
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkObjectEventRelay_AddObserver(HandleRef pThis, HandleRef sender, uint eventid, vtkObjectEventRelay.RelayHandler handler, float priority);

		private uint AddObserver()
		{
			if (null == this.RelayHandlerDelegate)
			{
				this.RelayHandlerDelegate = new vtkObjectEventRelay.RelayHandler(this.Execute);
			}
			return vtkObjectEventRelay.vtkObjectEventRelay_AddObserver(base.GetCppThis(), (this.Sender == null) ? default(HandleRef) : this.Sender.GetCppThis(), this.EventId, this.RelayHandlerDelegate, 0f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkObjectEventRelay_RemoveObserver(HandleRef pThis, uint observerId);

		private void RemoveObserver(uint observerId)
		{
			vtkObjectEventRelay.vtkObjectEventRelay_RemoveObserver(base.GetCppThis(), observerId);
		}

		private void CallAddObserver()
		{
			if (this.ObserverId == 0u && this.Sender != null && IntPtr.Zero != this.Sender.GetCppThis().Handle)
			{
				this.ObserverId = this.AddObserver();
			}
		}

		private void CallRemoveObserver()
		{
			if (this.ObserverId != 0u && this.Sender != null && IntPtr.Zero != this.Sender.GetCppThis().Handle)
			{
				this.RemoveObserver(this.ObserverId);
				this.ObserverId = 0u;
			}
		}

		public void Execute(IntPtr caller, uint eventId, IntPtr callData)
		{
			if (null != this.EventImpl)
			{
				bool flag;
				vtkObject caller2 = (vtkObject)Methods.CreateWrappedObject(0u, 4294967295u, 4294967208u, caller, true, out flag);
				this.EventImpl(this.Sender, new vtkObjectEventArgs(caller2, eventId, callData));
			}
		}

		public void AddHandler(vtkObject.vtkObjectEventHandler handler)
		{
			if (null == this.EventImpl)
			{
				this.CallAddObserver();
			}
			this.EventImpl = (vtkObject.vtkObjectEventHandler)Delegate.Combine(this.EventImpl, handler);
		}

		public void RemoveHandler(vtkObject.vtkObjectEventHandler handler)
		{
			this.EventImpl = (vtkObject.vtkObjectEventHandler)Delegate.Remove(this.EventImpl, handler);
			if (null == this.EventImpl)
			{
				this.CallRemoveObserver();
			}
		}

		public bool HasHandlers()
		{
			return null != this.EventImpl;
		}

		public void RemoveAllHandlers()
		{
			this.CallRemoveObserver();
			this.EventImpl = null;
			this.Sender = null;
		}
	}
}

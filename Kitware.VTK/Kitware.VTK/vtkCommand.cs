using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkCommand : vtkObjectBase
	{
		public enum EventIds
		{
			AbortCheckEvent = 10,
			ActiveCameraEvent = 29,
			AnimationCueTickEvent = 55,
			AnnotationChangedEvent = 74,
			AnyEvent = 1,
			CharEvent = 22,
			ComputeVisiblePropBoundsEvent = 80,
			ConfigureEvent = 24,
			ConnectionClosedEvent = 67,
			ConnectionCreatedEvent = 66,
			CreateCameraEvent = 30,
			CreateTimerEvent = 46,
			CurrentChangedEvent = 79,
			CursorChangedEvent = 50,
			DeleteEvent = 2,
			DestroyTimerEvent = 47,
			DisableEvent = 45,
			DomainModifiedEvent = 68,
			EnableEvent = 44,
			EndAnimationCueEvent = 56,
			EndEvent = 4,
			EndInteractionEvent = 43,
			EndPickEvent = 9,
			EndWindowLevelEvent = 36,
			EnterEvent = 18,
			ErrorEvent = 39,
			ExecuteInformationEvent = 51,
			ExitEvent = 11,
			ExposeEvent = 23,
			HighlightEvent = 91,
			HoverEvent = 84,
			InteractionEvent = 42,
			KeyPressEvent = 20,
			KeyReleaseEvent,
			LeaveEvent = 19,
			LeftButtonPressEvent = 12,
			LeftButtonReleaseEvent,
			LoadStateEvent = 85,
			MiddleButtonPressEvent = 14,
			MiddleButtonReleaseEvent,
			ModifiedEvent = 33,
			MouseMoveEvent = 26,
			MouseWheelBackwardEvent = 28,
			MouseWheelForwardEvent = 27,
			NoEvent = 0,
			PickEvent = 7,
			PlacePointEvent = 48,
			PlaceWidgetEvent,
			ProgressEvent = 6,
			PropertyModifiedEvent = 69,
			RegisterEvent = 71,
			RenderEvent = 5,
			RenderWindowMessageEvent = 52,
			ResetCameraClippingRangeEvent = 32,
			ResetCameraEvent = 31,
			ResetWindowLevelEvent = 37,
			RightButtonPressEvent = 16,
			RightButtonReleaseEvent,
			SaveStateEvent = 86,
			SelectionChangedEvent = 75,
			SetOutputEvent = 38,
			StartAnimationCueEvent = 54,
			StartEvent = 3,
			StartInteractionEvent = 41,
			StartPickEvent = 8,
			StartWindowLevelEvent = 35,
			StateChangedEvent = 87,
			TDxButtonPressEvent = 82,
			TDxButtonReleaseEvent,
			TDxMotionEvent = 81,
			TimerEvent = 25,
			UnRegisterEvent = 72,
			UpdateDataEvent = 78,
			UpdateEvent = 70,
			UpdateInformationEvent = 73,
			UpdatePropertyEvent = 76,
			UserEvent = 1000,
			ViewProgressEvent = 77,
			VolumeMapperComputeGradientsEndEvent = 60,
			VolumeMapperComputeGradientsProgressEvent,
			VolumeMapperComputeGradientsStartEvent,
			VolumeMapperRenderEndEvent = 57,
			VolumeMapperRenderProgressEvent,
			VolumeMapperRenderStartEvent,
			WarningEvent = 40,
			WidgetActivateEvent = 65,
			WidgetModifiedEvent = 63,
			WidgetValueChangedEvent,
			WindowFrameEvent = 90,
			WindowIsCurrentEvent = 89,
			WindowIsDirectEvent = 93,
			WindowLevelEvent = 34,
			WindowMakeCurrentEvent = 88,
			WindowSupportsOpenGLEvent = 92,
			WrongTagEvent = 53
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkCommand";

		public new static readonly string MRClassNameKey;

		static vtkCommand()
		{
			vtkCommand.MRClassNameKey = "class vtkCommand";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCommand.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCommand"));
		}

		public vtkCommand(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		private static extern IntPtr vtkCommandShadow_CreateShadow(IntPtr primary);

		public vtkCommand() : this(IntPtr.Zero, false, false)
		{
			IntPtr iDispatchForObject = Marshal.GetIDispatchForObject(this);
			base.SetCppThis(vtkCommand.vtkCommandShadow_CreateShadow(iDispatchForObject), true, false);
			Marshal.Release(iDispatchForObject);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCommand_UnRegister_17(HandleRef pThis, HandleRef arg0);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkCommand.vtkCommand_UnRegister_17(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCommand_AbortFlagOff_01(HandleRef pThis);

		public void AbortFlagOff()
		{
			vtkCommand.vtkCommand_AbortFlagOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCommand_AbortFlagOn_02(HandleRef pThis);

		public void AbortFlagOn()
		{
			vtkCommand.vtkCommand_AbortFlagOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCommand_Execute_03(HandleRef pThis, HandleRef caller, uint eventId, IntPtr callData);

		public virtual void Execute(vtkObject caller, uint eventId, IntPtr callData)
		{
			vtkCommand.vtkCommand_Execute_03(base.GetCppThis(), (caller == null) ? default(HandleRef) : caller.GetCppThis(), eventId, callData);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCommand_GetAbortFlag_04(HandleRef pThis);

		public int GetAbortFlag()
		{
			return vtkCommand.vtkCommand_GetAbortFlag_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkCommand_GetEventIdFromString_05(string arg0);

		public static uint GetEventIdFromString(string arg0)
		{
			return vtkCommand.vtkCommand_GetEventIdFromString_05(arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCommand_GetPassiveObserver_06(HandleRef pThis);

		public int GetPassiveObserver()
		{
			return vtkCommand.vtkCommand_GetPassiveObserver_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCommand_GetStringFromEventId_07(uint arg0);

		public static string GetStringFromEventId(uint arg0)
		{
			return Marshal.PtrToStringAnsi(vtkCommand.vtkCommand_GetStringFromEventId_07(arg0));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCommand_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCommand.vtkCommand_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkCommand_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCommand.vtkCommand_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCommand_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCommand NewInstance()
		{
			vtkCommand result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCommand.vtkCommand_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCommand)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCommand_PassiveObserverOff_11(HandleRef pThis);

		public void PassiveObserverOff()
		{
			vtkCommand.vtkCommand_PassiveObserverOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCommand_PassiveObserverOn_12(HandleRef pThis);

		public void PassiveObserverOn()
		{
			vtkCommand.vtkCommand_PassiveObserverOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkCommand_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkCommand SafeDownCast(vtkObjectBase o)
		{
			vtkCommand vtkCommand = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCommand.vtkCommand_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommand = (vtkCommand)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommand.Register(null);
				}
			}
			return vtkCommand;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCommand_SetAbortFlag_14(HandleRef pThis, int f);

		public void SetAbortFlag(int f)
		{
			vtkCommand.vtkCommand_SetAbortFlag_14(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkCommand_SetPassiveObserver_15(HandleRef pThis, int f);

		public void SetPassiveObserver(int f)
		{
			vtkCommand.vtkCommand_SetPassiveObserver_15(base.GetCppThis(), f);
		}
	}
}

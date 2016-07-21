using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRenderWindowInteractor : vtkObject
	{
		public enum OneShotTimer_WrapperEnum
		{
			OneShotTimer = 1,
			RepeatingTimer
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderWindowInteractor";

		public new static readonly string MRClassNameKey;

		static vtkRenderWindowInteractor()
		{
			vtkRenderWindowInteractor.MRClassNameKey = "class vtkRenderWindowInteractor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderWindowInteractor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderWindowInteractor"));
		}

		public vtkRenderWindowInteractor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindowInteractor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderWindowInteractor New()
		{
			vtkRenderWindowInteractor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRenderWindowInteractor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRenderWindowInteractor.vtkRenderWindowInteractor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_UnRegister_133(HandleRef pThis, HandleRef o);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkRenderWindowInteractor.vtkRenderWindowInteractor_UnRegister_133(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_CharEvent_01(HandleRef pThis);

		public virtual void CharEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_CharEvent_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_ConfigureEvent_02(HandleRef pThis);

		public virtual void ConfigureEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_ConfigureEvent_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindowInteractor_CreateDefaultPicker_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractPropPicker CreateDefaultPicker()
		{
			vtkAbstractPropPicker vtkAbstractPropPicker = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_CreateDefaultPicker_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPropPicker = (vtkAbstractPropPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPropPicker.Register(null);
				}
			}
			return vtkAbstractPropPicker;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_CreateOneShotTimer_04(HandleRef pThis, uint duration);

		public int CreateOneShotTimer(uint duration)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_CreateOneShotTimer_04(base.GetCppThis(), duration);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_CreateRepeatingTimer_05(HandleRef pThis, uint duration);

		public int CreateRepeatingTimer(uint duration)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_CreateRepeatingTimer_05(base.GetCppThis(), duration);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_CreateTimer_06(HandleRef pThis, int timerType);

		public virtual int CreateTimer(int timerType)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_CreateTimer_06(base.GetCppThis(), timerType);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_DestroyTimer_07(HandleRef pThis);

		public virtual int DestroyTimer()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_DestroyTimer_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_DestroyTimer_08(HandleRef pThis, int timerId);

		public int DestroyTimer(int timerId)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_DestroyTimer_08(base.GetCppThis(), timerId);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_Disable_09(HandleRef pThis);

		public virtual void Disable()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_Disable_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_Enable_10(HandleRef pThis);

		public virtual void Enable()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_Enable_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_EnableRenderOff_11(HandleRef pThis);

		public virtual void EnableRenderOff()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_EnableRenderOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_EnableRenderOn_12(HandleRef pThis);

		public virtual void EnableRenderOn()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_EnableRenderOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_EndPickCallback_13(HandleRef pThis);

		public virtual void EndPickCallback()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_EndPickCallback_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_EnterEvent_14(HandleRef pThis);

		public virtual void EnterEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_EnterEvent_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_ExitCallback_15(HandleRef pThis);

		public virtual void ExitCallback()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_ExitCallback_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_ExitEvent_16(HandleRef pThis);

		public virtual void ExitEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_ExitEvent_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_ExposeEvent_17(HandleRef pThis);

		public virtual void ExposeEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_ExposeEvent_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindowInteractor_FindPokedRenderer_18(HandleRef pThis, int arg0, int arg1, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer FindPokedRenderer(int arg0, int arg1)
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_FindPokedRenderer_18(base.GetCppThis(), arg0, arg1, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_FlyTo_19(HandleRef pThis, HandleRef ren, double x, double y, double z);

		public void FlyTo(vtkRenderer ren, double x, double y, double z)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_FlyTo_19(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_FlyTo_20(HandleRef pThis, HandleRef ren, IntPtr x);

		public void FlyTo(vtkRenderer ren, IntPtr x)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_FlyTo_20(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_FlyToImage_21(HandleRef pThis, HandleRef ren, double x, double y);

		public void FlyToImage(vtkRenderer ren, double x, double y)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_FlyToImage_21(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_FlyToImage_22(HandleRef pThis, HandleRef ren, IntPtr x);

		public void FlyToImage(vtkRenderer ren, IntPtr x)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_FlyToImage_22(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_GetAltKey_23(HandleRef pThis);

		public virtual int GetAltKey()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetAltKey_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_GetControlKey_24(HandleRef pThis);

		public virtual int GetControlKey()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetControlKey_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderWindowInteractor_GetDesiredUpdateRate_25(HandleRef pThis);

		public virtual double GetDesiredUpdateRate()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetDesiredUpdateRate_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderWindowInteractor_GetDesiredUpdateRateMaxValue_26(HandleRef pThis);

		public virtual double GetDesiredUpdateRateMaxValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetDesiredUpdateRateMaxValue_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderWindowInteractor_GetDesiredUpdateRateMinValue_27(HandleRef pThis);

		public virtual double GetDesiredUpdateRateMinValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetDesiredUpdateRateMinValue_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderWindowInteractor_GetDolly_28(HandleRef pThis);

		public virtual double GetDolly()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetDolly_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkRenderWindowInteractor_GetEnableRender_29(HandleRef pThis);

		public virtual bool GetEnableRender()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEnableRender_29(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_GetEnabled_30(HandleRef pThis);

		public virtual int GetEnabled()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEnabled_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindowInteractor_GetEventPosition_31(HandleRef pThis);

		public virtual int[] GetEventPosition()
		{
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEventPosition_31(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_GetEventPosition_32(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetEventPosition(ref int _arg1, ref int _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEventPosition_32(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_GetEventPosition_33(HandleRef pThis, IntPtr _arg);

		public virtual void GetEventPosition(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEventPosition_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindowInteractor_GetEventSize_34(HandleRef pThis);

		public virtual int[] GetEventSize()
		{
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEventSize_34(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_GetEventSize_35(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetEventSize(ref int _arg1, ref int _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEventSize_35(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_GetEventSize_36(HandleRef pThis, IntPtr _arg);

		public virtual void GetEventSize(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetEventSize_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_GetInitialized_37(HandleRef pThis);

		public virtual int GetInitialized()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetInitialized_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindowInteractor_GetInteractorStyle_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInteractorObserver GetInteractorStyle()
		{
			vtkInteractorObserver vtkInteractorObserver = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetInteractorStyle_38(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorObserver = (vtkInteractorObserver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorObserver.Register(null);
				}
			}
			return vtkInteractorObserver;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern sbyte vtkRenderWindowInteractor_GetKeyCode_39(HandleRef pThis);

		public virtual sbyte GetKeyCode()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetKeyCode_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindowInteractor_GetKeySym_40(HandleRef pThis);

		public virtual string GetKeySym()
		{
			return Marshal.PtrToStringAnsi(vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetKeySym_40(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindowInteractor_GetLastEventPosition_41(HandleRef pThis);

		public virtual int[] GetLastEventPosition()
		{
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetLastEventPosition_41(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_GetLastEventPosition_42(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetLastEventPosition(ref int _arg1, ref int _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetLastEventPosition_42(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_GetLastEventPosition_43(HandleRef pThis, IntPtr _arg);

		public virtual void GetLastEventPosition(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetLastEventPosition_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_GetLightFollowCamera_44(HandleRef pThis);

		public virtual int GetLightFollowCamera()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetLightFollowCamera_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_GetMousePosition_45(HandleRef pThis, IntPtr x, IntPtr y);

		public virtual void GetMousePosition(IntPtr x, IntPtr y)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetMousePosition_45(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_GetNumberOfFlyFrames_46(HandleRef pThis);

		public virtual int GetNumberOfFlyFrames()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetNumberOfFlyFrames_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_GetNumberOfFlyFramesMaxValue_47(HandleRef pThis);

		public virtual int GetNumberOfFlyFramesMaxValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetNumberOfFlyFramesMaxValue_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_GetNumberOfFlyFramesMinValue_48(HandleRef pThis);

		public virtual int GetNumberOfFlyFramesMinValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetNumberOfFlyFramesMinValue_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindowInteractor_GetObserverMediator_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkObserverMediator GetObserverMediator()
		{
			vtkObserverMediator vtkObserverMediator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetObserverMediator_49(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObserverMediator = (vtkObserverMediator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObserverMediator.Register(null);
				}
			}
			return vtkObserverMediator;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindowInteractor_GetPicker_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractPicker GetPicker()
		{
			vtkAbstractPicker vtkAbstractPicker = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetPicker_50(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPicker = (vtkAbstractPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPicker.Register(null);
				}
			}
			return vtkAbstractPicker;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindowInteractor_GetRenderWindow_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetRenderWindow_51(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_GetRepeatCount_52(HandleRef pThis);

		public virtual int GetRepeatCount()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetRepeatCount_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_GetShiftKey_53(HandleRef pThis);

		public virtual int GetShiftKey()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetShiftKey_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindowInteractor_GetSize_54(HandleRef pThis);

		public virtual int[] GetSize()
		{
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetSize_54(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_GetSize_55(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetSize(ref int _arg1, ref int _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetSize_55(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_GetSize_56(HandleRef pThis, IntPtr _arg);

		public virtual void GetSize(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetSize_56(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderWindowInteractor_GetStillUpdateRate_57(HandleRef pThis);

		public virtual double GetStillUpdateRate()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetStillUpdateRate_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderWindowInteractor_GetStillUpdateRateMaxValue_58(HandleRef pThis);

		public virtual double GetStillUpdateRateMaxValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetStillUpdateRateMaxValue_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderWindowInteractor_GetStillUpdateRateMinValue_59(HandleRef pThis);

		public virtual double GetStillUpdateRateMinValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetStillUpdateRateMinValue_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkRenderWindowInteractor_GetTimerDuration_60(HandleRef pThis, int timerId);

		public uint GetTimerDuration(int timerId)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerDuration_60(base.GetCppThis(), timerId);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkRenderWindowInteractor_GetTimerDuration_61(HandleRef pThis);

		public virtual uint GetTimerDuration()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerDuration_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkRenderWindowInteractor_GetTimerDurationMaxValue_62(HandleRef pThis);

		public virtual uint GetTimerDurationMaxValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerDurationMaxValue_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkRenderWindowInteractor_GetTimerDurationMinValue_63(HandleRef pThis);

		public virtual uint GetTimerDurationMinValue()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerDurationMinValue_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_GetTimerEventDuration_64(HandleRef pThis);

		public virtual int GetTimerEventDuration()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerEventDuration_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_GetTimerEventId_65(HandleRef pThis);

		public virtual int GetTimerEventId()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerEventId_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_GetTimerEventPlatformId_66(HandleRef pThis);

		public virtual int GetTimerEventPlatformId()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerEventPlatformId_66(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_GetTimerEventType_67(HandleRef pThis);

		public virtual int GetTimerEventType()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetTimerEventType_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkRenderWindowInteractor_GetUseTDx_68(HandleRef pThis);

		public virtual bool GetUseTDx()
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetUseTDx_68(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_GetVTKTimerId_69(HandleRef pThis, int platformTimerId);

		public virtual int GetVTKTimerId(int platformTimerId)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_GetVTKTimerId_69(base.GetCppThis(), platformTimerId);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_HideCursor_70(HandleRef pThis);

		public void HideCursor()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_HideCursor_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_Initialize_71(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_Initialize_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_IsA_72(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_IsA_72(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_IsOneShotTimer_73(HandleRef pThis, int timerId);

		public int IsOneShotTimer(int timerId)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_IsOneShotTimer_73(base.GetCppThis(), timerId);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_IsTypeOf_74(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_IsTypeOf_74(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_KeyPressEvent_75(HandleRef pThis);

		public virtual void KeyPressEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_KeyPressEvent_75(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_KeyReleaseEvent_76(HandleRef pThis);

		public virtual void KeyReleaseEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_KeyReleaseEvent_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_LeaveEvent_77(HandleRef pThis);

		public virtual void LeaveEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_LeaveEvent_77(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_LeftButtonPressEvent_78(HandleRef pThis);

		public virtual void LeftButtonPressEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_LeftButtonPressEvent_78(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_LeftButtonReleaseEvent_79(HandleRef pThis);

		public virtual void LeftButtonReleaseEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_LeftButtonReleaseEvent_79(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_LightFollowCameraOff_80(HandleRef pThis);

		public virtual void LightFollowCameraOff()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_LightFollowCameraOff_80(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_LightFollowCameraOn_81(HandleRef pThis);

		public virtual void LightFollowCameraOn()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_LightFollowCameraOn_81(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_MiddleButtonPressEvent_82(HandleRef pThis);

		public virtual void MiddleButtonPressEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_MiddleButtonPressEvent_82(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_MiddleButtonReleaseEvent_83(HandleRef pThis);

		public virtual void MiddleButtonReleaseEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_MiddleButtonReleaseEvent_83(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_MouseMoveEvent_84(HandleRef pThis);

		public virtual void MouseMoveEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_MouseMoveEvent_84(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_MouseWheelBackwardEvent_85(HandleRef pThis);

		public virtual void MouseWheelBackwardEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_MouseWheelBackwardEvent_85(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_MouseWheelForwardEvent_86(HandleRef pThis);

		public virtual void MouseWheelForwardEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_MouseWheelForwardEvent_86(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindowInteractor_NewInstance_88(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRenderWindowInteractor NewInstance()
		{
			vtkRenderWindowInteractor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_NewInstance_88(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_ReInitialize_89(HandleRef pThis);

		public void ReInitialize()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_ReInitialize_89(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_Render_90(HandleRef pThis);

		public virtual void Render()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_Render_90(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindowInteractor_ResetTimer_91(HandleRef pThis, int timerId);

		public int ResetTimer(int timerId)
		{
			return vtkRenderWindowInteractor.vtkRenderWindowInteractor_ResetTimer_91(base.GetCppThis(), timerId);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_RightButtonPressEvent_92(HandleRef pThis);

		public virtual void RightButtonPressEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_RightButtonPressEvent_92(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_RightButtonReleaseEvent_93(HandleRef pThis);

		public virtual void RightButtonReleaseEvent()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_RightButtonReleaseEvent_93(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindowInteractor_SafeDownCast_94(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderWindowInteractor SafeDownCast(vtkObjectBase o)
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindowInteractor.vtkRenderWindowInteractor_SafeDownCast_94((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowInteractor = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowInteractor.Register(null);
				}
			}
			return vtkRenderWindowInteractor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetAltKey_95(HandleRef pThis, int _arg);

		public virtual void SetAltKey(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetAltKey_95(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetControlKey_96(HandleRef pThis, int _arg);

		public virtual void SetControlKey(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetControlKey_96(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetDesiredUpdateRate_97(HandleRef pThis, double _arg);

		public virtual void SetDesiredUpdateRate(double _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetDesiredUpdateRate_97(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetDolly_98(HandleRef pThis, double _arg);

		public virtual void SetDolly(double _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetDolly_98(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetEnableRender_99(HandleRef pThis, byte _arg);

		public virtual void SetEnableRender(bool _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEnableRender_99(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetEventInformation_100(HandleRef pThis, int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym);

		public void SetEventInformation(int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventInformation_100(base.GetCppThis(), x, y, ctrl, shift, keycode, repeatcount, keysym);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetEventInformationFlipY_101(HandleRef pThis, int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym);

		public void SetEventInformationFlipY(int x, int y, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventInformationFlipY_101(base.GetCppThis(), x, y, ctrl, shift, keycode, repeatcount, keysym);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetEventPosition_102(HandleRef pThis, int x, int y);

		public virtual void SetEventPosition(int x, int y)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventPosition_102(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetEventPosition_103(HandleRef pThis, IntPtr pos);

		public virtual void SetEventPosition(IntPtr pos)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventPosition_103(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetEventPositionFlipY_104(HandleRef pThis, int x, int y);

		public virtual void SetEventPositionFlipY(int x, int y)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventPositionFlipY_104(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetEventPositionFlipY_105(HandleRef pThis, IntPtr pos);

		public virtual void SetEventPositionFlipY(IntPtr pos)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventPositionFlipY_105(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetEventSize_106(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetEventSize(int _arg1, int _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventSize_106(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetEventSize_107(HandleRef pThis, IntPtr _arg);

		public void SetEventSize(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetEventSize_107(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetInteractorStyle_108(HandleRef pThis, HandleRef arg0);

		public virtual void SetInteractorStyle(vtkInteractorObserver arg0)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetInteractorStyle_108(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetKeyCode_109(HandleRef pThis, sbyte _arg);

		public virtual void SetKeyCode(sbyte _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetKeyCode_109(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetKeyEventInformation_110(HandleRef pThis, int ctrl, int shift, sbyte keycode, int repeatcount, string keysym);

		public void SetKeyEventInformation(int ctrl, int shift, sbyte keycode, int repeatcount, string keysym)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetKeyEventInformation_110(base.GetCppThis(), ctrl, shift, keycode, repeatcount, keysym);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetKeySym_111(HandleRef pThis, string _arg);

		public virtual void SetKeySym(string _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetKeySym_111(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetLastEventPosition_112(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetLastEventPosition(int _arg1, int _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetLastEventPosition_112(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetLastEventPosition_113(HandleRef pThis, IntPtr _arg);

		public void SetLastEventPosition(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetLastEventPosition_113(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetLightFollowCamera_114(HandleRef pThis, int _arg);

		public virtual void SetLightFollowCamera(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetLightFollowCamera_114(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetNumberOfFlyFrames_115(HandleRef pThis, int _arg);

		public virtual void SetNumberOfFlyFrames(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetNumberOfFlyFrames_115(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetPicker_116(HandleRef pThis, HandleRef arg0);

		public virtual void SetPicker(vtkAbstractPicker arg0)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetPicker_116(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetRenderWindow_117(HandleRef pThis, HandleRef aren);

		public void SetRenderWindow(vtkRenderWindow aren)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetRenderWindow_117(base.GetCppThis(), (aren == null) ? default(HandleRef) : aren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetRepeatCount_118(HandleRef pThis, int _arg);

		public virtual void SetRepeatCount(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetRepeatCount_118(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetShiftKey_119(HandleRef pThis, int _arg);

		public virtual void SetShiftKey(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetShiftKey_119(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetSize_120(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetSize(int _arg1, int _arg2)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetSize_120(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetSize_121(HandleRef pThis, IntPtr _arg);

		public void SetSize(IntPtr _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetSize_121(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetStillUpdateRate_122(HandleRef pThis, double _arg);

		public virtual void SetStillUpdateRate(double _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetStillUpdateRate_122(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetTimerDuration_123(HandleRef pThis, uint _arg);

		public virtual void SetTimerDuration(uint _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetTimerDuration_123(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetTimerEventDuration_124(HandleRef pThis, int _arg);

		public virtual void SetTimerEventDuration(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetTimerEventDuration_124(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetTimerEventId_125(HandleRef pThis, int _arg);

		public virtual void SetTimerEventId(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetTimerEventId_125(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetTimerEventPlatformId_126(HandleRef pThis, int _arg);

		public virtual void SetTimerEventPlatformId(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetTimerEventPlatformId_126(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetTimerEventType_127(HandleRef pThis, int _arg);

		public virtual void SetTimerEventType(int _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetTimerEventType_127(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_SetUseTDx_128(HandleRef pThis, byte _arg);

		public virtual void SetUseTDx(bool _arg)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_SetUseTDx_128(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_ShowCursor_129(HandleRef pThis);

		public void ShowCursor()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_ShowCursor_129(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_Start_130(HandleRef pThis);

		public virtual void Start()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_Start_130(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_StartPickCallback_131(HandleRef pThis);

		public virtual void StartPickCallback()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_StartPickCallback_131(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_TerminateApp_132(HandleRef pThis);

		public virtual void TerminateApp()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_TerminateApp_132(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_UpdateSize_134(HandleRef pThis, int x, int y);

		public virtual void UpdateSize(int x, int y)
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_UpdateSize_134(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindowInteractor_UserCallback_135(HandleRef pThis);

		public virtual void UserCallback()
		{
			vtkRenderWindowInteractor.vtkRenderWindowInteractor_UserCallback_135(base.GetCppThis());
		}
	}
}

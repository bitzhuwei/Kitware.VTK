using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyle : vtkInteractorObserver
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyle";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyle()
		{
			vtkInteractorStyle.MRClassNameKey = "class vtkInteractorStyle";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyle"));
		}

		public vtkInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyle New()
		{
			vtkInteractorStyle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyle.vtkInteractorStyle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyle.vtkInteractorStyle_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_AutoAdjustCameraClippingRangeOff_01(HandleRef pThis);

		public virtual void AutoAdjustCameraClippingRangeOff()
		{
			vtkInteractorStyle.vtkInteractorStyle_AutoAdjustCameraClippingRangeOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_AutoAdjustCameraClippingRangeOn_02(HandleRef pThis);

		public virtual void AutoAdjustCameraClippingRangeOn()
		{
			vtkInteractorStyle.vtkInteractorStyle_AutoAdjustCameraClippingRangeOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_DelegateTDxEvent_03(HandleRef pThis, uint arg0, IntPtr calldata);

		public void DelegateTDxEvent(uint arg0, IntPtr calldata)
		{
			vtkInteractorStyle.vtkInteractorStyle_DelegateTDxEvent_03(base.GetCppThis(), arg0, calldata);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_Dolly_04(HandleRef pThis);

		public virtual void Dolly()
		{
			vtkInteractorStyle.vtkInteractorStyle_Dolly_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_EndDolly_05(HandleRef pThis);

		public virtual void EndDolly()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndDolly_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_EndPan_06(HandleRef pThis);

		public virtual void EndPan()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndPan_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_EndRotate_07(HandleRef pThis);

		public virtual void EndRotate()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndRotate_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_EndSpin_08(HandleRef pThis);

		public virtual void EndSpin()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndSpin_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_EndTimer_09(HandleRef pThis);

		public virtual void EndTimer()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndTimer_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_EndUniformScale_10(HandleRef pThis);

		public virtual void EndUniformScale()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndUniformScale_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_EndZoom_11(HandleRef pThis);

		public virtual void EndZoom()
		{
			vtkInteractorStyle.vtkInteractorStyle_EndZoom_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_FindPokedRenderer_12(HandleRef pThis, int arg0, int arg1);

		public void FindPokedRenderer(int arg0, int arg1)
		{
			vtkInteractorStyle.vtkInteractorStyle_FindPokedRenderer_12(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyle_GetAutoAdjustCameraClippingRange_13(HandleRef pThis);

		public virtual int GetAutoAdjustCameraClippingRange()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetAutoAdjustCameraClippingRange_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyle_GetAutoAdjustCameraClippingRangeMaxValue_14(HandleRef pThis);

		public virtual int GetAutoAdjustCameraClippingRangeMaxValue()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetAutoAdjustCameraClippingRangeMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyle_GetAutoAdjustCameraClippingRangeMinValue_15(HandleRef pThis);

		public virtual int GetAutoAdjustCameraClippingRangeMinValue()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetAutoAdjustCameraClippingRangeMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyle_GetHandleObservers_16(HandleRef pThis);

		public virtual int GetHandleObservers()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetHandleObservers_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkInteractorStyle_GetMouseWheelMotionFactor_17(HandleRef pThis);

		public virtual double GetMouseWheelMotionFactor()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetMouseWheelMotionFactor_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyle_GetPickColor_18(HandleRef pThis);

		public virtual double[] GetPickColor()
		{
			IntPtr intPtr = vtkInteractorStyle.vtkInteractorStyle_GetPickColor_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_GetPickColor_19(HandleRef pThis, IntPtr data);

		public virtual void GetPickColor(IntPtr data)
		{
			vtkInteractorStyle.vtkInteractorStyle_GetPickColor_19(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyle_GetState_20(HandleRef pThis);

		public virtual int GetState()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetState_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyle_GetTDxStyle_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTDxInteractorStyle GetTDxStyle()
		{
			vtkTDxInteractorStyle vtkTDxInteractorStyle = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyle.vtkInteractorStyle_GetTDxStyle_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTDxInteractorStyle = (vtkTDxInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTDxInteractorStyle.Register(null);
				}
			}
			return vtkTDxInteractorStyle;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkInteractorStyle_GetTimerDuration_22(HandleRef pThis);

		public virtual uint GetTimerDuration()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetTimerDuration_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkInteractorStyle_GetTimerDurationMaxValue_23(HandleRef pThis);

		public virtual uint GetTimerDurationMaxValue()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetTimerDurationMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkInteractorStyle_GetTimerDurationMinValue_24(HandleRef pThis);

		public virtual uint GetTimerDurationMinValue()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetTimerDurationMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyle_GetUseTimers_25(HandleRef pThis);

		public virtual int GetUseTimers()
		{
			return vtkInteractorStyle.vtkInteractorStyle_GetUseTimers_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_HandleObserversOff_26(HandleRef pThis);

		public virtual void HandleObserversOff()
		{
			vtkInteractorStyle.vtkInteractorStyle_HandleObserversOff_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_HandleObserversOn_27(HandleRef pThis);

		public virtual void HandleObserversOn()
		{
			vtkInteractorStyle.vtkInteractorStyle_HandleObserversOn_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_HighlightActor2D_28(HandleRef pThis, HandleRef actor2D);

		public virtual void HighlightActor2D(vtkActor2D actor2D)
		{
			vtkInteractorStyle.vtkInteractorStyle_HighlightActor2D_28(base.GetCppThis(), (actor2D == null) ? default(HandleRef) : actor2D.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_HighlightProp_29(HandleRef pThis, HandleRef prop);

		public virtual void HighlightProp(vtkProp prop)
		{
			vtkInteractorStyle.vtkInteractorStyle_HighlightProp_29(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_HighlightProp3D_30(HandleRef pThis, HandleRef prop3D);

		public virtual void HighlightProp3D(vtkProp3D prop3D)
		{
			vtkInteractorStyle.vtkInteractorStyle_HighlightProp3D_30(base.GetCppThis(), (prop3D == null) ? default(HandleRef) : prop3D.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyle_IsA_31(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyle.vtkInteractorStyle_IsA_31(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyle_IsTypeOf_32(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyle.vtkInteractorStyle_IsTypeOf_32(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyle_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyle NewInstance()
		{
			vtkInteractorStyle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyle.vtkInteractorStyle_NewInstance_34(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnChar_35(HandleRef pThis);

		public override void OnChar()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnChar_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnConfigure_36(HandleRef pThis);

		public virtual void OnConfigure()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnConfigure_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnEnter_37(HandleRef pThis);

		public virtual void OnEnter()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnEnter_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnExpose_38(HandleRef pThis);

		public virtual void OnExpose()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnExpose_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnKeyDown_39(HandleRef pThis);

		public virtual void OnKeyDown()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnKeyDown_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnKeyPress_40(HandleRef pThis);

		public virtual void OnKeyPress()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnKeyPress_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnKeyRelease_41(HandleRef pThis);

		public virtual void OnKeyRelease()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnKeyRelease_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnKeyUp_42(HandleRef pThis);

		public virtual void OnKeyUp()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnKeyUp_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnLeave_43(HandleRef pThis);

		public virtual void OnLeave()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnLeave_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnLeftButtonDown_44(HandleRef pThis);

		public virtual void OnLeftButtonDown()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnLeftButtonDown_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnLeftButtonUp_45(HandleRef pThis);

		public virtual void OnLeftButtonUp()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnLeftButtonUp_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnMiddleButtonDown_46(HandleRef pThis);

		public virtual void OnMiddleButtonDown()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnMiddleButtonDown_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnMiddleButtonUp_47(HandleRef pThis);

		public virtual void OnMiddleButtonUp()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnMiddleButtonUp_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnMouseMove_48(HandleRef pThis);

		public virtual void OnMouseMove()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnMouseMove_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnMouseWheelBackward_49(HandleRef pThis);

		public virtual void OnMouseWheelBackward()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnMouseWheelBackward_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnMouseWheelForward_50(HandleRef pThis);

		public virtual void OnMouseWheelForward()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnMouseWheelForward_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnRightButtonDown_51(HandleRef pThis);

		public virtual void OnRightButtonDown()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnRightButtonDown_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnRightButtonUp_52(HandleRef pThis);

		public virtual void OnRightButtonUp()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnRightButtonUp_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_OnTimer_53(HandleRef pThis);

		public virtual void OnTimer()
		{
			vtkInteractorStyle.vtkInteractorStyle_OnTimer_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_Pan_54(HandleRef pThis);

		public virtual void Pan()
		{
			vtkInteractorStyle.vtkInteractorStyle_Pan_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_Rotate_55(HandleRef pThis);

		public virtual void Rotate()
		{
			vtkInteractorStyle.vtkInteractorStyle_Rotate_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyle_SafeDownCast_56(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyle SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyle vtkInteractorStyle = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyle.vtkInteractorStyle_SafeDownCast_56((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyle = (vtkInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyle.Register(null);
				}
			}
			return vtkInteractorStyle;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_SetAutoAdjustCameraClippingRange_57(HandleRef pThis, int _arg);

		public virtual void SetAutoAdjustCameraClippingRange(int _arg)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetAutoAdjustCameraClippingRange_57(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_SetEnabled_58(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetEnabled_58(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_SetHandleObservers_59(HandleRef pThis, int _arg);

		public virtual void SetHandleObservers(int _arg)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetHandleObservers_59(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_SetInteractor_60(HandleRef pThis, HandleRef interactor);

		public override void SetInteractor(vtkRenderWindowInteractor interactor)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetInteractor_60(base.GetCppThis(), (interactor == null) ? default(HandleRef) : interactor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_SetMouseWheelMotionFactor_61(HandleRef pThis, double _arg);

		public virtual void SetMouseWheelMotionFactor(double _arg)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetMouseWheelMotionFactor_61(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_SetPickColor_62(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPickColor(double _arg1, double _arg2, double _arg3)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetPickColor_62(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_SetPickColor_63(HandleRef pThis, IntPtr _arg);

		public virtual void SetPickColor(IntPtr _arg)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetPickColor_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_SetTDxStyle_64(HandleRef pThis, HandleRef tdxStyle);

		public virtual void SetTDxStyle(vtkTDxInteractorStyle tdxStyle)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetTDxStyle_64(base.GetCppThis(), (tdxStyle == null) ? default(HandleRef) : tdxStyle.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_SetTimerDuration_65(HandleRef pThis, uint _arg);

		public virtual void SetTimerDuration(uint _arg)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetTimerDuration_65(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_SetUseTimers_66(HandleRef pThis, int _arg);

		public virtual void SetUseTimers(int _arg)
		{
			vtkInteractorStyle.vtkInteractorStyle_SetUseTimers_66(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_Spin_67(HandleRef pThis);

		public virtual void Spin()
		{
			vtkInteractorStyle.vtkInteractorStyle_Spin_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_StartAnimate_68(HandleRef pThis);

		public virtual void StartAnimate()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartAnimate_68(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_StartDolly_69(HandleRef pThis);

		public virtual void StartDolly()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartDolly_69(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_StartPan_70(HandleRef pThis);

		public virtual void StartPan()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartPan_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_StartRotate_71(HandleRef pThis);

		public virtual void StartRotate()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartRotate_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_StartSpin_72(HandleRef pThis);

		public virtual void StartSpin()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartSpin_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_StartState_73(HandleRef pThis, int newstate);

		public virtual void StartState(int newstate)
		{
			vtkInteractorStyle.vtkInteractorStyle_StartState_73(base.GetCppThis(), newstate);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_StartTimer_74(HandleRef pThis);

		public virtual void StartTimer()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartTimer_74(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_StartUniformScale_75(HandleRef pThis);

		public virtual void StartUniformScale()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartUniformScale_75(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_StartZoom_76(HandleRef pThis);

		public virtual void StartZoom()
		{
			vtkInteractorStyle.vtkInteractorStyle_StartZoom_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_StopAnimate_77(HandleRef pThis);

		public virtual void StopAnimate()
		{
			vtkInteractorStyle.vtkInteractorStyle_StopAnimate_77(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_StopState_78(HandleRef pThis);

		public virtual void StopState()
		{
			vtkInteractorStyle.vtkInteractorStyle_StopState_78(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_UniformScale_79(HandleRef pThis);

		public virtual void UniformScale()
		{
			vtkInteractorStyle.vtkInteractorStyle_UniformScale_79(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_UseTimersOff_80(HandleRef pThis);

		public virtual void UseTimersOff()
		{
			vtkInteractorStyle.vtkInteractorStyle_UseTimersOff_80(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_UseTimersOn_81(HandleRef pThis);

		public virtual void UseTimersOn()
		{
			vtkInteractorStyle.vtkInteractorStyle_UseTimersOn_81(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyle_Zoom_82(HandleRef pThis);

		public virtual void Zoom()
		{
			vtkInteractorStyle.vtkInteractorStyle_Zoom_82(base.GetCppThis());
		}
	}
}

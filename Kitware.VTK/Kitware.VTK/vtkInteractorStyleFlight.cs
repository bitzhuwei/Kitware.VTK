using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleFlight : vtkInteractorStyle
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleFlight";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleFlight()
		{
			vtkInteractorStyleFlight.MRClassNameKey = "class vtkInteractorStyleFlight";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleFlight.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleFlight"));
		}

		public vtkInteractorStyleFlight(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleFlight_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleFlight New()
		{
			vtkInteractorStyleFlight result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleFlight.vtkInteractorStyleFlight_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleFlight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleFlight() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleFlight.vtkInteractorStyleFlight_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_DisableMotionOff_01(HandleRef pThis);

		public virtual void DisableMotionOff()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_DisableMotionOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_DisableMotionOn_02(HandleRef pThis);

		public virtual void DisableMotionOn()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_DisableMotionOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_EndForwardFly_03(HandleRef pThis);

		public virtual void EndForwardFly()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_EndForwardFly_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_EndReverseFly_04(HandleRef pThis);

		public virtual void EndReverseFly()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_EndReverseFly_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_ForwardFly_05(HandleRef pThis);

		public virtual void ForwardFly()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_ForwardFly_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkInteractorStyleFlight_GetAngleAccelerationFactor_06(HandleRef pThis);

		public virtual double GetAngleAccelerationFactor()
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetAngleAccelerationFactor_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkInteractorStyleFlight_GetAngleStepSize_07(HandleRef pThis);

		public virtual double GetAngleStepSize()
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetAngleStepSize_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleFlight_GetDefaultUpVector_08(HandleRef pThis);

		public virtual double[] GetDefaultUpVector()
		{
			IntPtr intPtr = vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetDefaultUpVector_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_GetDefaultUpVector_09(HandleRef pThis, IntPtr data);

		public virtual void GetDefaultUpVector(IntPtr data)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetDefaultUpVector_09(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleFlight_GetDisableMotion_10(HandleRef pThis);

		public virtual int GetDisableMotion()
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetDisableMotion_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkInteractorStyleFlight_GetMotionAccelerationFactor_11(HandleRef pThis);

		public virtual double GetMotionAccelerationFactor()
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetMotionAccelerationFactor_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkInteractorStyleFlight_GetMotionStepSize_12(HandleRef pThis);

		public virtual double GetMotionStepSize()
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetMotionStepSize_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleFlight_GetRestoreUpVector_13(HandleRef pThis);

		public virtual int GetRestoreUpVector()
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetRestoreUpVector_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleFlight_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleFlight_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_JumpTo_16(HandleRef pThis, IntPtr campos, IntPtr focpos);

		public void JumpTo(IntPtr campos, IntPtr focpos)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_JumpTo_16(base.GetCppThis(), campos, focpos);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleFlight_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleFlight NewInstance()
		{
			vtkInteractorStyleFlight result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleFlight.vtkInteractorStyleFlight_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleFlight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_OnChar_19(HandleRef pThis);

		public override void OnChar()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnChar_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_OnKeyDown_20(HandleRef pThis);

		public override void OnKeyDown()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnKeyDown_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_OnKeyUp_21(HandleRef pThis);

		public override void OnKeyUp()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnKeyUp_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_OnLeftButtonDown_22(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnLeftButtonDown_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_OnLeftButtonUp_23(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnLeftButtonUp_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_OnMiddleButtonDown_24(HandleRef pThis);

		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnMiddleButtonDown_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_OnMiddleButtonUp_25(HandleRef pThis);

		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnMiddleButtonUp_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_OnMouseMove_26(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnMouseMove_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_OnRightButtonDown_27(HandleRef pThis);

		public override void OnRightButtonDown()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnRightButtonDown_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_OnRightButtonUp_28(HandleRef pThis);

		public override void OnRightButtonUp()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnRightButtonUp_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_OnTimer_29(HandleRef pThis);

		public override void OnTimer()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnTimer_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_RestoreUpVectorOff_30(HandleRef pThis);

		public virtual void RestoreUpVectorOff()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_RestoreUpVectorOff_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_RestoreUpVectorOn_31(HandleRef pThis);

		public virtual void RestoreUpVectorOn()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_RestoreUpVectorOn_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_ReverseFly_32(HandleRef pThis);

		public virtual void ReverseFly()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_ReverseFly_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleFlight_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleFlight SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleFlight vtkInteractorStyleFlight = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleFlight.vtkInteractorStyleFlight_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleFlight = (vtkInteractorStyleFlight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleFlight.Register(null);
				}
			}
			return vtkInteractorStyleFlight;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_SetAngleAccelerationFactor_34(HandleRef pThis, double _arg);

		public virtual void SetAngleAccelerationFactor(double _arg)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_SetAngleAccelerationFactor_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_SetAngleStepSize_35(HandleRef pThis, double _arg);

		public virtual void SetAngleStepSize(double _arg)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_SetAngleStepSize_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_SetDefaultUpVector_36(HandleRef pThis, IntPtr data);

		public virtual void SetDefaultUpVector(IntPtr data)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_SetDefaultUpVector_36(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_SetDisableMotion_37(HandleRef pThis, int _arg);

		public virtual void SetDisableMotion(int _arg)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_SetDisableMotion_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_SetMotionAccelerationFactor_38(HandleRef pThis, double _arg);

		public virtual void SetMotionAccelerationFactor(double _arg)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_SetMotionAccelerationFactor_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_SetMotionStepSize_39(HandleRef pThis, double _arg);

		public virtual void SetMotionStepSize(double _arg)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_SetMotionStepSize_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_SetRestoreUpVector_40(HandleRef pThis, int _arg);

		public virtual void SetRestoreUpVector(int _arg)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_SetRestoreUpVector_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_StartForwardFly_41(HandleRef pThis);

		public virtual void StartForwardFly()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_StartForwardFly_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleFlight_StartReverseFly_42(HandleRef pThis);

		public virtual void StartReverseFly()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_StartReverseFly_42(base.GetCppThis());
		}
	}
}

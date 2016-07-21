using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkDistanceRepresentation : vtkWidgetRepresentation
	{
		public enum NearP1_WrapperEnum
		{
			NearP1 = 1,
			NearP2,
			Outside = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkDistanceRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkDistanceRepresentation()
		{
			vtkDistanceRepresentation.MRClassNameKey = "class vtkDistanceRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistanceRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistanceRepresentation"));
		}

		public vtkDistanceRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkDistanceRepresentation_GetDistance_03(HandleRef pThis);

		public virtual double GetDistance()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetDistance_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation_GetLabelFormat_04(HandleRef pThis);

		public virtual string GetLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkDistanceRepresentation.vtkDistanceRepresentation_GetLabelFormat_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation_GetNumberOfRulerTicks_05(HandleRef pThis);

		public virtual int GetNumberOfRulerTicks()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetNumberOfRulerTicks_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation_GetNumberOfRulerTicksMaxValue_06(HandleRef pThis);

		public virtual int GetNumberOfRulerTicksMaxValue()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetNumberOfRulerTicksMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation_GetNumberOfRulerTicksMinValue_07(HandleRef pThis);

		public virtual int GetNumberOfRulerTicksMinValue()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetNumberOfRulerTicksMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_GetPoint1DisplayPosition_08(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint1DisplayPosition_08(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation_GetPoint1Representation_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHandleRepresentation GetPoint1Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint1Representation_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleRepresentation = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleRepresentation.Register(null);
				}
			}
			return vtkHandleRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_GetPoint1WorldPosition_10(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint1WorldPosition_10(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation_GetPoint1WorldPosition_11(HandleRef pThis);

		public virtual double[] GetPoint1WorldPosition()
		{
			IntPtr intPtr = vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint1WorldPosition_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_GetPoint2DisplayPosition_12(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint2DisplayPosition_12(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation_GetPoint2Representation_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHandleRepresentation GetPoint2Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint2Representation_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleRepresentation = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleRepresentation.Register(null);
				}
			}
			return vtkHandleRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_GetPoint2WorldPosition_14(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint2WorldPosition_14(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation_GetPoint2WorldPosition_15(HandleRef pThis);

		public virtual double[] GetPoint2WorldPosition()
		{
			IntPtr intPtr = vtkDistanceRepresentation.vtkDistanceRepresentation_GetPoint2WorldPosition_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkDistanceRepresentation_GetRulerDistance_16(HandleRef pThis);

		public virtual double GetRulerDistance()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetRulerDistance_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkDistanceRepresentation_GetRulerDistanceMaxValue_17(HandleRef pThis);

		public virtual double GetRulerDistanceMaxValue()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetRulerDistanceMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkDistanceRepresentation_GetRulerDistanceMinValue_18(HandleRef pThis);

		public virtual double GetRulerDistanceMinValue()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetRulerDistanceMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation_GetRulerMode_19(HandleRef pThis);

		public virtual int GetRulerMode()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetRulerMode_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation_GetTolerance_20(HandleRef pThis);

		public virtual int GetTolerance()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetTolerance_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation_GetToleranceMaxValue_21(HandleRef pThis);

		public virtual int GetToleranceMaxValue()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetToleranceMaxValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation_GetToleranceMinValue_22(HandleRef pThis);

		public virtual int GetToleranceMinValue()
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_GetToleranceMinValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_InstantiateHandleRepresentation_23(HandleRef pThis);

		public void InstantiateHandleRepresentation()
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_InstantiateHandleRepresentation_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation_IsA_24(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_IsA_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkDistanceRepresentation_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDistanceRepresentation.vtkDistanceRepresentation_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDistanceRepresentation NewInstance()
		{
			vtkDistanceRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation.vtkDistanceRepresentation_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_RulerModeOff_27(HandleRef pThis);

		public virtual void RulerModeOff()
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_RulerModeOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_RulerModeOn_28(HandleRef pThis);

		public virtual void RulerModeOn()
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_RulerModeOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkDistanceRepresentation_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDistanceRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkDistanceRepresentation vtkDistanceRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistanceRepresentation.vtkDistanceRepresentation_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistanceRepresentation = (vtkDistanceRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistanceRepresentation.Register(null);
				}
			}
			return vtkDistanceRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_SetHandleRepresentation_30(HandleRef pThis, HandleRef handle);

		public void SetHandleRepresentation(vtkHandleRepresentation handle)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetHandleRepresentation_30(base.GetCppThis(), (handle == null) ? default(HandleRef) : handle.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_SetLabelFormat_31(HandleRef pThis, string _arg);

		public virtual void SetLabelFormat(string _arg)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetLabelFormat_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_SetNumberOfRulerTicks_32(HandleRef pThis, int _arg);

		public virtual void SetNumberOfRulerTicks(int _arg)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetNumberOfRulerTicks_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_SetPoint1DisplayPosition_33(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetPoint1DisplayPosition_33(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_SetPoint1WorldPosition_34(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint1WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetPoint1WorldPosition_34(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_SetPoint2DisplayPosition_35(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetPoint2DisplayPosition_35(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_SetPoint2WorldPosition_36(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint2WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetPoint2WorldPosition_36(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_SetRulerDistance_37(HandleRef pThis, double _arg);

		public virtual void SetRulerDistance(double _arg)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetRulerDistance_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_SetRulerMode_38(HandleRef pThis, int _arg);

		public virtual void SetRulerMode(int _arg)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetRulerMode_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_SetTolerance_39(HandleRef pThis, int _arg);

		public virtual void SetTolerance(int _arg)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_SetTolerance_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_StartWidgetInteraction_40(HandleRef pThis, IntPtr e);

		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_StartWidgetInteraction_40(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkDistanceRepresentation_WidgetInteraction_41(HandleRef pThis, IntPtr e);

		public override void WidgetInteraction(IntPtr e)
		{
			vtkDistanceRepresentation.vtkDistanceRepresentation_WidgetInteraction_41(base.GetCppThis(), e);
		}
	}
}

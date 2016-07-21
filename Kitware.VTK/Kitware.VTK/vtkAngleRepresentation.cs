using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkAngleRepresentation : vtkWidgetRepresentation
	{
		public enum NearCenter_WrapperEnum
		{
			NearCenter = 2,
			NearP1 = 1,
			NearP2 = 3,
			Outside = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkAngleRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkAngleRepresentation()
		{
			vtkAngleRepresentation.MRClassNameKey = "class vtkAngleRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAngleRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAngleRepresentation"));
		}

		public vtkAngleRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_ArcVisibilityOff_01(HandleRef pThis);

		public virtual void ArcVisibilityOff()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_ArcVisibilityOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_ArcVisibilityOn_02(HandleRef pThis);

		public virtual void ArcVisibilityOn()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_ArcVisibilityOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_BuildRepresentation_03(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_BuildRepresentation_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_CenterWidgetInteraction_04(HandleRef pThis, IntPtr e);

		public virtual void CenterWidgetInteraction(IntPtr e)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_CenterWidgetInteraction_04(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation_ComputeInteractionState_05(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_ComputeInteractionState_05(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkAngleRepresentation_GetAngle_06(HandleRef pThis);

		public virtual double GetAngle()
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetAngle_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation_GetArcVisibility_07(HandleRef pThis);

		public virtual int GetArcVisibility()
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetArcVisibility_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_GetCenterDisplayPosition_08(HandleRef pThis, IntPtr pos);

		public virtual void GetCenterDisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_GetCenterDisplayPosition_08(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation_GetCenterRepresentation_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHandleRepresentation GetCenterRepresentation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation.vtkAngleRepresentation_GetCenterRepresentation_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkAngleRepresentation_GetCenterWorldPosition_10(HandleRef pThis, IntPtr pos);

		public virtual void GetCenterWorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_GetCenterWorldPosition_10(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation_GetLabelFormat_11(HandleRef pThis);

		public virtual string GetLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkAngleRepresentation.vtkAngleRepresentation_GetLabelFormat_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_GetPoint1DisplayPosition_12(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_GetPoint1DisplayPosition_12(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation_GetPoint1Representation_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHandleRepresentation GetPoint1Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation.vtkAngleRepresentation_GetPoint1Representation_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkAngleRepresentation_GetPoint1WorldPosition_14(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_GetPoint1WorldPosition_14(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_GetPoint2DisplayPosition_15(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_GetPoint2DisplayPosition_15(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation_GetPoint2Representation_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHandleRepresentation GetPoint2Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation.vtkAngleRepresentation_GetPoint2Representation_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkAngleRepresentation_GetPoint2WorldPosition_17(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_GetPoint2WorldPosition_17(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation_GetRay1Visibility_18(HandleRef pThis);

		public virtual int GetRay1Visibility()
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetRay1Visibility_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation_GetRay2Visibility_19(HandleRef pThis);

		public virtual int GetRay2Visibility()
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetRay2Visibility_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation_GetTolerance_20(HandleRef pThis);

		public virtual int GetTolerance()
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetTolerance_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation_GetToleranceMaxValue_21(HandleRef pThis);

		public virtual int GetToleranceMaxValue()
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetToleranceMaxValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation_GetToleranceMinValue_22(HandleRef pThis);

		public virtual int GetToleranceMinValue()
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_GetToleranceMinValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_InstantiateHandleRepresentation_23(HandleRef pThis);

		public void InstantiateHandleRepresentation()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_InstantiateHandleRepresentation_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation_IsA_24(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_IsA_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAngleRepresentation_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAngleRepresentation.vtkAngleRepresentation_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAngleRepresentation NewInstance()
		{
			vtkAngleRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation.vtkAngleRepresentation_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_Ray1VisibilityOff_27(HandleRef pThis);

		public virtual void Ray1VisibilityOff()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_Ray1VisibilityOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_Ray1VisibilityOn_28(HandleRef pThis);

		public virtual void Ray1VisibilityOn()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_Ray1VisibilityOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_Ray2VisibilityOff_29(HandleRef pThis);

		public virtual void Ray2VisibilityOff()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_Ray2VisibilityOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_Ray2VisibilityOn_30(HandleRef pThis);

		public virtual void Ray2VisibilityOn()
		{
			vtkAngleRepresentation.vtkAngleRepresentation_Ray2VisibilityOn_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAngleRepresentation_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAngleRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkAngleRepresentation vtkAngleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAngleRepresentation.vtkAngleRepresentation_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAngleRepresentation = (vtkAngleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAngleRepresentation.Register(null);
				}
			}
			return vtkAngleRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_SetArcVisibility_32(HandleRef pThis, int _arg);

		public virtual void SetArcVisibility(int _arg)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetArcVisibility_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_SetCenterDisplayPosition_33(HandleRef pThis, IntPtr pos);

		public virtual void SetCenterDisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetCenterDisplayPosition_33(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_SetHandleRepresentation_34(HandleRef pThis, HandleRef handle);

		public void SetHandleRepresentation(vtkHandleRepresentation handle)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetHandleRepresentation_34(base.GetCppThis(), (handle == null) ? default(HandleRef) : handle.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_SetLabelFormat_35(HandleRef pThis, string _arg);

		public virtual void SetLabelFormat(string _arg)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetLabelFormat_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_SetPoint1DisplayPosition_36(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetPoint1DisplayPosition_36(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_SetPoint2DisplayPosition_37(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetPoint2DisplayPosition_37(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_SetRay1Visibility_38(HandleRef pThis, int _arg);

		public virtual void SetRay1Visibility(int _arg)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetRay1Visibility_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_SetRay2Visibility_39(HandleRef pThis, int _arg);

		public virtual void SetRay2Visibility(int _arg)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetRay2Visibility_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_SetTolerance_40(HandleRef pThis, int _arg);

		public virtual void SetTolerance(int _arg)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_SetTolerance_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_StartWidgetInteraction_41(HandleRef pThis, IntPtr e);

		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_StartWidgetInteraction_41(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAngleRepresentation_WidgetInteraction_42(HandleRef pThis, IntPtr e);

		public override void WidgetInteraction(IntPtr e)
		{
			vtkAngleRepresentation.vtkAngleRepresentation_WidgetInteraction_42(base.GetCppThis(), e);
		}
	}
}

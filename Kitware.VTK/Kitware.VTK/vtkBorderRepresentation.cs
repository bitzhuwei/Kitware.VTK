using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBorderRepresentation : vtkWidgetRepresentation
	{
		public enum BORDER_ACTIVE_WrapperEnum
		{
			BORDER_ACTIVE = 2,
			BORDER_OFF = 0,
			BORDER_ON
		}

		public enum _InteractionState
		{
			AdjustingE0 = 6,
			AdjustingE1,
			AdjustingE2,
			AdjustingE3,
			AdjustingP0 = 2,
			AdjustingP1,
			AdjustingP2,
			AdjustingP3,
			Inside = 1,
			Outside = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkBorderRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkBorderRepresentation()
		{
			vtkBorderRepresentation.MRClassNameKey = "class vtkBorderRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBorderRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBorderRepresentation"));
		}

		public vtkBorderRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBorderRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBorderRepresentation New()
		{
			vtkBorderRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBorderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBorderRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBorderRepresentation.vtkBorderRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_GetActors2D_03(HandleRef pThis, HandleRef arg0);

		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetActors2D_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBorderRepresentation_GetBorderProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetBorderProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetBorderProperty_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBorderRepresentation_GetMaximumSize_05(HandleRef pThis);

		public virtual int[] GetMaximumSize()
		{
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetMaximumSize_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_GetMaximumSize_06(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetMaximumSize(ref int _arg1, ref int _arg2)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetMaximumSize_06(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_GetMaximumSize_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetMaximumSize(IntPtr _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetMaximumSize_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBorderRepresentation_GetMinimumSize_08(HandleRef pThis);

		public virtual int[] GetMinimumSize()
		{
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetMinimumSize_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_GetMinimumSize_09(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetMinimumSize(ref int _arg1, ref int _arg2)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetMinimumSize_09(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_GetMinimumSize_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetMinimumSize(IntPtr _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetMinimumSize_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderRepresentation_GetMoving_11(HandleRef pThis);

		public virtual int GetMoving()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetMoving_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBorderRepresentation_GetPosition_12(HandleRef pThis);

		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetPosition_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBorderRepresentation_GetPosition2_13(HandleRef pThis);

		public virtual double[] GetPosition2()
		{
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetPosition2_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBorderRepresentation_GetPosition2Coordinate_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoordinate GetPosition2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetPosition2Coordinate_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBorderRepresentation_GetPositionCoordinate_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoordinate GetPositionCoordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetPositionCoordinate_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderRepresentation_GetProportionalResize_16(HandleRef pThis);

		public virtual int GetProportionalResize()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetProportionalResize_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBorderRepresentation_GetSelectionPoint_17(HandleRef pThis);

		public virtual double[] GetSelectionPoint()
		{
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetSelectionPoint_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_GetSelectionPoint_18(HandleRef pThis, IntPtr data);

		public virtual void GetSelectionPoint(IntPtr data)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetSelectionPoint_18(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderRepresentation_GetShowBorder_19(HandleRef pThis);

		public virtual int GetShowBorder()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowBorder_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderRepresentation_GetShowBorderMaxValue_20(HandleRef pThis);

		public virtual int GetShowBorderMaxValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowBorderMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderRepresentation_GetShowBorderMinValue_21(HandleRef pThis);

		public virtual int GetShowBorderMinValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowBorderMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_GetSize_22(HandleRef pThis, IntPtr size);

		public virtual void GetSize(IntPtr size)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetSize_22(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderRepresentation_GetTolerance_23(HandleRef pThis);

		public virtual int GetTolerance()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetTolerance_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderRepresentation_GetToleranceMaxValue_24(HandleRef pThis);

		public virtual int GetToleranceMaxValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetToleranceMaxValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderRepresentation_GetToleranceMinValue_25(HandleRef pThis);

		public virtual int GetToleranceMinValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetToleranceMinValue_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderRepresentation_HasTranslucentPolygonalGeometry_26(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_HasTranslucentPolygonalGeometry_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderRepresentation_IsA_27(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_IsA_27(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderRepresentation_IsTypeOf_28(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_IsTypeOf_28(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_MovingOff_29(HandleRef pThis);

		public virtual void MovingOff()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_MovingOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_MovingOn_30(HandleRef pThis);

		public virtual void MovingOn()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_MovingOn_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBorderRepresentation_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBorderRepresentation NewInstance()
		{
			vtkBorderRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_NewInstance_32(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBorderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_ProportionalResizeOff_33(HandleRef pThis);

		public virtual void ProportionalResizeOff()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_ProportionalResizeOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_ProportionalResizeOn_34(HandleRef pThis);

		public virtual void ProportionalResizeOn()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_ProportionalResizeOn_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_ReleaseGraphicsResources_35(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_ReleaseGraphicsResources_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderRepresentation_RenderOpaqueGeometry_36(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_RenderOpaqueGeometry_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderRepresentation_RenderOverlay_37(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_RenderOverlay_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBorderRepresentation_RenderTranslucentPolygonalGeometry_38(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_RenderTranslucentPolygonalGeometry_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBorderRepresentation_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBorderRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkBorderRepresentation vtkBorderRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBorderRepresentation = (vtkBorderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBorderRepresentation.Register(null);
				}
			}
			return vtkBorderRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_SetMaximumSize_40(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetMaximumSize(int _arg1, int _arg2)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetMaximumSize_40(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_SetMaximumSize_41(HandleRef pThis, IntPtr _arg);

		public void SetMaximumSize(IntPtr _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetMaximumSize_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_SetMinimumSize_42(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetMinimumSize(int _arg1, int _arg2)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetMinimumSize_42(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_SetMinimumSize_43(HandleRef pThis, IntPtr _arg);

		public void SetMinimumSize(IntPtr _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetMinimumSize_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_SetMoving_44(HandleRef pThis, int _arg);

		public virtual void SetMoving(int _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetMoving_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_SetPosition_45(HandleRef pThis, IntPtr x);

		public virtual void SetPosition(IntPtr x)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetPosition_45(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_SetPosition_46(HandleRef pThis, double x, double y);

		public virtual void SetPosition(double x, double y)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetPosition_46(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_SetPosition2_47(HandleRef pThis, IntPtr x);

		public virtual void SetPosition2(IntPtr x)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetPosition2_47(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_SetPosition2_48(HandleRef pThis, double x, double y);

		public virtual void SetPosition2(double x, double y)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetPosition2_48(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_SetProportionalResize_49(HandleRef pThis, int _arg);

		public virtual void SetProportionalResize(int _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetProportionalResize_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_SetShowBorder_50(HandleRef pThis, int _arg);

		public virtual void SetShowBorder(int _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetShowBorder_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_SetShowBorderToActive_51(HandleRef pThis);

		public void SetShowBorderToActive()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetShowBorderToActive_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_SetShowBorderToOff_52(HandleRef pThis);

		public void SetShowBorderToOff()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetShowBorderToOff_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_SetShowBorderToOn_53(HandleRef pThis);

		public void SetShowBorderToOn()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetShowBorderToOn_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_SetTolerance_54(HandleRef pThis, int _arg);

		public virtual void SetTolerance(int _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetTolerance_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_StartWidgetInteraction_55(HandleRef pThis, IntPtr eventPos);

		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_StartWidgetInteraction_55(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBorderRepresentation_WidgetInteraction_56(HandleRef pThis, IntPtr eventPos);

		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_WidgetInteraction_56(base.GetCppThis(), eventPos);
		}
	}
}

using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkBiDimensionalRepresentation : vtkWidgetRepresentation
	{
		public enum NearP1_WrapperEnum
		{
			NearP1 = 1,
			NearP2,
			NearP3,
			NearP4,
			OnCenter = 9,
			OnL1Inner = 5,
			OnL1Outer,
			OnL2Inner,
			OnL2Outer,
			Outside = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkBiDimensionalRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkBiDimensionalRepresentation()
		{
			vtkBiDimensionalRepresentation.MRClassNameKey = "class vtkBiDimensionalRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBiDimensionalRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiDimensionalRepresentation"));
		}

		public vtkBiDimensionalRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern long vtkBiDimensionalRepresentation_GetID_01(HandleRef pThis);

		public virtual long GetID()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetID_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalRepresentation_GetLabelFormat_02(HandleRef pThis);

		public virtual string GetLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLabelFormat_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalRepresentation_GetLabelPosition_03(HandleRef pThis);

		public virtual IntPtr GetLabelPosition()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLabelPosition_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_GetLabelPosition_04(HandleRef pThis, IntPtr pos);

		public virtual void GetLabelPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLabelPosition_04(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalRepresentation_GetLabelText_05(HandleRef pThis);

		public virtual string GetLabelText()
		{
			return Marshal.PtrToStringAnsi(vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLabelText_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkBiDimensionalRepresentation_GetLength1_06(HandleRef pThis);

		public virtual double GetLength1()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLength1_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkBiDimensionalRepresentation_GetLength2_07(HandleRef pThis);

		public virtual double GetLength2()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLength2_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalRepresentation_GetLine1Visibility_08(HandleRef pThis);

		public virtual int GetLine1Visibility()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLine1Visibility_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalRepresentation_GetLine2Visibility_09(HandleRef pThis);

		public virtual int GetLine2Visibility()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetLine2Visibility_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_GetPoint1DisplayPosition_10(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint1DisplayPosition_10(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalRepresentation_GetPoint1Representation_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHandleRepresentation GetPoint1Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint1Representation_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkBiDimensionalRepresentation_GetPoint1WorldPosition_12(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint1WorldPosition_12(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_GetPoint2DisplayPosition_13(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint2DisplayPosition_13(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalRepresentation_GetPoint2Representation_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHandleRepresentation GetPoint2Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint2Representation_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkBiDimensionalRepresentation_GetPoint2WorldPosition_15(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint2WorldPosition_15(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_GetPoint3DisplayPosition_16(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint3DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint3DisplayPosition_16(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalRepresentation_GetPoint3Representation_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHandleRepresentation GetPoint3Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint3Representation_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkBiDimensionalRepresentation_GetPoint3WorldPosition_18(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint3WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint3WorldPosition_18(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_GetPoint4DisplayPosition_19(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint4DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint4DisplayPosition_19(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalRepresentation_GetPoint4Representation_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHandleRepresentation GetPoint4Representation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint4Representation_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkBiDimensionalRepresentation_GetPoint4WorldPosition_21(HandleRef pThis, IntPtr pos);

		public virtual void GetPoint4WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetPoint4WorldPosition_21(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalRepresentation_GetShowLabelAboveWidget_22(HandleRef pThis);

		public virtual int GetShowLabelAboveWidget()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetShowLabelAboveWidget_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalRepresentation_GetTolerance_23(HandleRef pThis);

		public virtual int GetTolerance()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetTolerance_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalRepresentation_GetToleranceMaxValue_24(HandleRef pThis);

		public virtual int GetToleranceMaxValue()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetToleranceMaxValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalRepresentation_GetToleranceMinValue_25(HandleRef pThis);

		public virtual int GetToleranceMinValue()
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetToleranceMinValue_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_GetWorldLabelPosition_26(HandleRef pThis, IntPtr pos);

		public virtual void GetWorldLabelPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_GetWorldLabelPosition_26(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_InstantiateHandleRepresentation_27(HandleRef pThis);

		public virtual void InstantiateHandleRepresentation()
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_InstantiateHandleRepresentation_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalRepresentation_IsA_28(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_IsA_28(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalRepresentation_IsTypeOf_29(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_IsTypeOf_29(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_Line1VisibilityOff_30(HandleRef pThis);

		public virtual void Line1VisibilityOff()
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_Line1VisibilityOff_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_Line1VisibilityOn_31(HandleRef pThis);

		public virtual void Line1VisibilityOn()
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_Line1VisibilityOn_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_Line2VisibilityOff_32(HandleRef pThis);

		public virtual void Line2VisibilityOff()
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_Line2VisibilityOff_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_Line2VisibilityOn_33(HandleRef pThis);

		public virtual void Line2VisibilityOn()
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_Line2VisibilityOn_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalRepresentation_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBiDimensionalRepresentation NewInstance()
		{
			vtkBiDimensionalRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_NewInstance_34(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiDimensionalRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_Point2WidgetInteraction_35(HandleRef pThis, IntPtr e);

		public virtual void Point2WidgetInteraction(IntPtr e)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_Point2WidgetInteraction_35(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_Point3WidgetInteraction_36(HandleRef pThis, IntPtr e);

		public virtual void Point3WidgetInteraction(IntPtr e)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_Point3WidgetInteraction_36(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalRepresentation_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBiDimensionalRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkBiDimensionalRepresentation vtkBiDimensionalRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBiDimensionalRepresentation = (vtkBiDimensionalRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBiDimensionalRepresentation.Register(null);
				}
			}
			return vtkBiDimensionalRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_SetHandleRepresentation_38(HandleRef pThis, HandleRef handle);

		public void SetHandleRepresentation(vtkHandleRepresentation handle)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetHandleRepresentation_38(base.GetCppThis(), (handle == null) ? default(HandleRef) : handle.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_SetID_39(HandleRef pThis, long id);

		public void SetID(long id)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetID_39(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_SetLabelFormat_40(HandleRef pThis, string _arg);

		public virtual void SetLabelFormat(string _arg)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetLabelFormat_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_SetLine1Visibility_41(HandleRef pThis, int _arg);

		public virtual void SetLine1Visibility(int _arg)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetLine1Visibility_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_SetLine2Visibility_42(HandleRef pThis, int _arg);

		public virtual void SetLine2Visibility(int _arg)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetLine2Visibility_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint1DisplayPosition_43(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint1DisplayPosition_43(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint1WorldPosition_44(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint1WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint1WorldPosition_44(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint2DisplayPosition_45(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint2DisplayPosition_45(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint2WorldPosition_46(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint2WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint2WorldPosition_46(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint3DisplayPosition_47(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint3DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint3DisplayPosition_47(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint3WorldPosition_48(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint3WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint3WorldPosition_48(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint4DisplayPosition_49(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint4DisplayPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint4DisplayPosition_49(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_SetPoint4WorldPosition_50(HandleRef pThis, IntPtr pos);

		public virtual void SetPoint4WorldPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetPoint4WorldPosition_50(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_SetShowLabelAboveWidget_51(HandleRef pThis, int _arg);

		public virtual void SetShowLabelAboveWidget(int _arg)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetShowLabelAboveWidget_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_SetTolerance_52(HandleRef pThis, int _arg);

		public virtual void SetTolerance(int _arg)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_SetTolerance_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_ShowLabelAboveWidgetOff_53(HandleRef pThis);

		public virtual void ShowLabelAboveWidgetOff()
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_ShowLabelAboveWidgetOff_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_ShowLabelAboveWidgetOn_54(HandleRef pThis);

		public virtual void ShowLabelAboveWidgetOn()
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_ShowLabelAboveWidgetOn_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_StartWidgetDefinition_55(HandleRef pThis, IntPtr e);

		public virtual void StartWidgetDefinition(IntPtr e)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_StartWidgetDefinition_55(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation_StartWidgetManipulation_56(HandleRef pThis, IntPtr e);

		public virtual void StartWidgetManipulation(IntPtr e)
		{
			vtkBiDimensionalRepresentation.vtkBiDimensionalRepresentation_StartWidgetManipulation_56(base.GetCppThis(), e);
		}
	}
}

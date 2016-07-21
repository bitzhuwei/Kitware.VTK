using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLeaderActor2D : vtkActor2D
	{
		public enum VTK_ARROW_BOTH_WrapperEnum
		{
			VTK_ARROW_BOTH = 3,
			VTK_ARROW_NONE = 0,
			VTK_ARROW_POINT1,
			VTK_ARROW_POINT2
		}

		public enum VTK_ARROW_FILLED_WrapperEnum
		{
			VTK_ARROW_FILLED,
			VTK_ARROW_HOLLOW = 2,
			VTK_ARROW_OPEN = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkLeaderActor2D";

		public new static readonly string MRClassNameKey;

		static vtkLeaderActor2D()
		{
			vtkLeaderActor2D.MRClassNameKey = "class vtkLeaderActor2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLeaderActor2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLeaderActor2D"));
		}

		public vtkLeaderActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLeaderActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLeaderActor2D New()
		{
			vtkLeaderActor2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLeaderActor2D.vtkLeaderActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLeaderActor2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLeaderActor2D.vtkLeaderActor2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_AutoLabelOff_01(HandleRef pThis);

		public virtual void AutoLabelOff()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_AutoLabelOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_AutoLabelOn_02(HandleRef pThis);

		public virtual void AutoLabelOn()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_AutoLabelOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetAngle_03(HandleRef pThis);

		public virtual double GetAngle()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetAngle_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetArrowLength_04(HandleRef pThis);

		public virtual double GetArrowLength()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowLength_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetArrowLengthMaxValue_05(HandleRef pThis);

		public virtual double GetArrowLengthMaxValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowLengthMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetArrowLengthMinValue_06(HandleRef pThis);

		public virtual double GetArrowLengthMinValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowLengthMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLeaderActor2D_GetArrowPlacement_07(HandleRef pThis);

		public virtual int GetArrowPlacement()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowPlacement_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLeaderActor2D_GetArrowPlacementMaxValue_08(HandleRef pThis);

		public virtual int GetArrowPlacementMaxValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowPlacementMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLeaderActor2D_GetArrowPlacementMinValue_09(HandleRef pThis);

		public virtual int GetArrowPlacementMinValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowPlacementMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLeaderActor2D_GetArrowStyle_10(HandleRef pThis);

		public virtual int GetArrowStyle()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowStyle_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLeaderActor2D_GetArrowStyleMaxValue_11(HandleRef pThis);

		public virtual int GetArrowStyleMaxValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowStyleMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLeaderActor2D_GetArrowStyleMinValue_12(HandleRef pThis);

		public virtual int GetArrowStyleMinValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowStyleMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetArrowWidth_13(HandleRef pThis);

		public virtual double GetArrowWidth()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowWidth_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetArrowWidthMaxValue_14(HandleRef pThis);

		public virtual double GetArrowWidthMaxValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowWidthMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetArrowWidthMinValue_15(HandleRef pThis);

		public virtual double GetArrowWidthMinValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowWidthMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLeaderActor2D_GetAutoLabel_16(HandleRef pThis);

		public virtual int GetAutoLabel()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetAutoLabel_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLeaderActor2D_GetLabel_17(HandleRef pThis);

		public virtual string GetLabel()
		{
			return Marshal.PtrToStringAnsi(vtkLeaderActor2D.vtkLeaderActor2D_GetLabel_17(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetLabelFactor_18(HandleRef pThis);

		public virtual double GetLabelFactor()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetLabelFactor_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetLabelFactorMaxValue_19(HandleRef pThis);

		public virtual double GetLabelFactorMaxValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetLabelFactorMaxValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetLabelFactorMinValue_20(HandleRef pThis);

		public virtual double GetLabelFactorMinValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetLabelFactorMinValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLeaderActor2D_GetLabelFormat_21(HandleRef pThis);

		public virtual string GetLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkLeaderActor2D.vtkLeaderActor2D_GetLabelFormat_21(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLeaderActor2D_GetLabelTextProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLeaderActor2D.vtkLeaderActor2D_GetLabelTextProperty_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetLength_23(HandleRef pThis);

		public virtual double GetLength()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetLength_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetMaximumArrowSize_24(HandleRef pThis);

		public virtual double GetMaximumArrowSize()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetMaximumArrowSize_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetMaximumArrowSizeMaxValue_25(HandleRef pThis);

		public virtual double GetMaximumArrowSizeMaxValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetMaximumArrowSizeMaxValue_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetMaximumArrowSizeMinValue_26(HandleRef pThis);

		public virtual double GetMaximumArrowSizeMinValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetMaximumArrowSizeMinValue_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetMinimumArrowSize_27(HandleRef pThis);

		public virtual double GetMinimumArrowSize()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetMinimumArrowSize_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetMinimumArrowSizeMaxValue_28(HandleRef pThis);

		public virtual double GetMinimumArrowSizeMaxValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetMinimumArrowSizeMaxValue_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetMinimumArrowSizeMinValue_29(HandleRef pThis);

		public virtual double GetMinimumArrowSizeMinValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetMinimumArrowSizeMinValue_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLeaderActor2D_GetRadius_30(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetRadius_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLeaderActor2D_HasTranslucentPolygonalGeometry_31(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_HasTranslucentPolygonalGeometry_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLeaderActor2D_IsA_32(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_IsA_32(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLeaderActor2D_IsTypeOf_33(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_IsTypeOf_33(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLeaderActor2D_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLeaderActor2D NewInstance()
		{
			vtkLeaderActor2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLeaderActor2D.vtkLeaderActor2D_NewInstance_35(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_ReleaseGraphicsResources_36(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_ReleaseGraphicsResources_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLeaderActor2D_RenderOpaqueGeometry_37(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_RenderOpaqueGeometry_37(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLeaderActor2D_RenderOverlay_38(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_RenderOverlay_38(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLeaderActor2D_RenderTranslucentPolygonalGeometry_39(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_RenderTranslucentPolygonalGeometry_39(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLeaderActor2D_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLeaderActor2D SafeDownCast(vtkObjectBase o)
		{
			vtkLeaderActor2D vtkLeaderActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLeaderActor2D.vtkLeaderActor2D_SafeDownCast_40((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLeaderActor2D = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLeaderActor2D.Register(null);
				}
			}
			return vtkLeaderActor2D;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetArrowLength_41(HandleRef pThis, double _arg);

		public virtual void SetArrowLength(double _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowLength_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetArrowPlacement_42(HandleRef pThis, int _arg);

		public virtual void SetArrowPlacement(int _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowPlacement_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetArrowPlacementToBoth_43(HandleRef pThis);

		public void SetArrowPlacementToBoth()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowPlacementToBoth_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetArrowPlacementToNone_44(HandleRef pThis);

		public void SetArrowPlacementToNone()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowPlacementToNone_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetArrowPlacementToPoint1_45(HandleRef pThis);

		public void SetArrowPlacementToPoint1()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowPlacementToPoint1_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetArrowPlacementToPoint2_46(HandleRef pThis);

		public void SetArrowPlacementToPoint2()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowPlacementToPoint2_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetArrowStyle_47(HandleRef pThis, int _arg);

		public virtual void SetArrowStyle(int _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowStyle_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetArrowStyleToFilled_48(HandleRef pThis);

		public void SetArrowStyleToFilled()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowStyleToFilled_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetArrowStyleToHollow_49(HandleRef pThis);

		public void SetArrowStyleToHollow()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowStyleToHollow_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetArrowStyleToOpen_50(HandleRef pThis);

		public void SetArrowStyleToOpen()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowStyleToOpen_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetArrowWidth_51(HandleRef pThis, double _arg);

		public virtual void SetArrowWidth(double _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowWidth_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetAutoLabel_52(HandleRef pThis, int _arg);

		public virtual void SetAutoLabel(int _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetAutoLabel_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetLabel_53(HandleRef pThis, string _arg);

		public virtual void SetLabel(string _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetLabel_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetLabelFactor_54(HandleRef pThis, double _arg);

		public virtual void SetLabelFactor(double _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetLabelFactor_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetLabelFormat_55(HandleRef pThis, string _arg);

		public virtual void SetLabelFormat(string _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetLabelFormat_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetLabelTextProperty_56(HandleRef pThis, HandleRef p);

		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetLabelTextProperty_56(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetMaximumArrowSize_57(HandleRef pThis, double _arg);

		public virtual void SetMaximumArrowSize(double _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetMaximumArrowSize_57(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetMinimumArrowSize_58(HandleRef pThis, double _arg);

		public virtual void SetMinimumArrowSize(double _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetMinimumArrowSize_58(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_SetRadius_59(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetRadius_59(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLeaderActor2D_ShallowCopy_60(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_ShallowCopy_60(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}

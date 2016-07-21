using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLegendScaleActor : vtkProp
	{
		public enum AttributeLocation
		{
			DISTANCE,
			XY_COORDINATES
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkLegendScaleActor";

		public new static readonly string MRClassNameKey;

		static vtkLegendScaleActor()
		{
			vtkLegendScaleActor.MRClassNameKey = "class vtkLegendScaleActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLegendScaleActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLegendScaleActor"));
		}

		public vtkLegendScaleActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendScaleActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLegendScaleActor New()
		{
			vtkLegendScaleActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLegendScaleActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLegendScaleActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLegendScaleActor.vtkLegendScaleActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_AllAnnotationsOff_01(HandleRef pThis);

		public void AllAnnotationsOff()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_AllAnnotationsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_AllAnnotationsOn_02(HandleRef pThis);

		public void AllAnnotationsOn()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_AllAnnotationsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_AllAxesOff_03(HandleRef pThis);

		public void AllAxesOff()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_AllAxesOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_AllAxesOn_04(HandleRef pThis);

		public void AllAxesOn()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_AllAxesOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_BottomAxisVisibilityOff_05(HandleRef pThis);

		public virtual void BottomAxisVisibilityOff()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_BottomAxisVisibilityOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_BottomAxisVisibilityOn_06(HandleRef pThis);

		public virtual void BottomAxisVisibilityOn()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_BottomAxisVisibilityOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_BuildRepresentation_07(HandleRef pThis, HandleRef viewport);

		public virtual void BuildRepresentation(vtkViewport viewport)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_BuildRepresentation_07(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_GetActors2D_08(HandleRef pThis, HandleRef arg0);

		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_GetActors2D_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendScaleActor_GetBottomAxis_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAxisActor2D GetBottomAxis()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_GetBottomAxis_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetBottomAxisVisibility_10(HandleRef pThis);

		public virtual int GetBottomAxisVisibility()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetBottomAxisVisibility_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetBottomBorderOffset_11(HandleRef pThis);

		public virtual int GetBottomBorderOffset()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetBottomBorderOffset_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetBottomBorderOffsetMaxValue_12(HandleRef pThis);

		public virtual int GetBottomBorderOffsetMaxValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetBottomBorderOffsetMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetBottomBorderOffsetMinValue_13(HandleRef pThis);

		public virtual int GetBottomBorderOffsetMinValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetBottomBorderOffsetMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkLegendScaleActor_GetCornerOffsetFactor_14(HandleRef pThis);

		public virtual double GetCornerOffsetFactor()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetCornerOffsetFactor_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkLegendScaleActor_GetCornerOffsetFactorMaxValue_15(HandleRef pThis);

		public virtual double GetCornerOffsetFactorMaxValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetCornerOffsetFactorMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkLegendScaleActor_GetCornerOffsetFactorMinValue_16(HandleRef pThis);

		public virtual double GetCornerOffsetFactorMinValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetCornerOffsetFactorMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetLabelMode_17(HandleRef pThis);

		public virtual int GetLabelMode()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLabelMode_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetLabelModeMaxValue_18(HandleRef pThis);

		public virtual int GetLabelModeMaxValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLabelModeMaxValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetLabelModeMinValue_19(HandleRef pThis);

		public virtual int GetLabelModeMinValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLabelModeMinValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendScaleActor_GetLeftAxis_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAxisActor2D GetLeftAxis()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_GetLeftAxis_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetLeftAxisVisibility_21(HandleRef pThis);

		public virtual int GetLeftAxisVisibility()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLeftAxisVisibility_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetLeftBorderOffset_22(HandleRef pThis);

		public virtual int GetLeftBorderOffset()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLeftBorderOffset_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetLeftBorderOffsetMaxValue_23(HandleRef pThis);

		public virtual int GetLeftBorderOffsetMaxValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLeftBorderOffsetMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetLeftBorderOffsetMinValue_24(HandleRef pThis);

		public virtual int GetLeftBorderOffsetMinValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLeftBorderOffsetMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendScaleActor_GetLegendLabelProperty_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetLegendLabelProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_GetLegendLabelProperty_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendScaleActor_GetLegendTitleProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetLegendTitleProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_GetLegendTitleProperty_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetLegendVisibility_27(HandleRef pThis);

		public virtual int GetLegendVisibility()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetLegendVisibility_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendScaleActor_GetRightAxis_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAxisActor2D GetRightAxis()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_GetRightAxis_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetRightAxisVisibility_29(HandleRef pThis);

		public virtual int GetRightAxisVisibility()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetRightAxisVisibility_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetRightBorderOffset_30(HandleRef pThis);

		public virtual int GetRightBorderOffset()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetRightBorderOffset_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetRightBorderOffsetMaxValue_31(HandleRef pThis);

		public virtual int GetRightBorderOffsetMaxValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetRightBorderOffsetMaxValue_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetRightBorderOffsetMinValue_32(HandleRef pThis);

		public virtual int GetRightBorderOffsetMinValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetRightBorderOffsetMinValue_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendScaleActor_GetTopAxis_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAxisActor2D GetTopAxis()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_GetTopAxis_33(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetTopAxisVisibility_34(HandleRef pThis);

		public virtual int GetTopAxisVisibility()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetTopAxisVisibility_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetTopBorderOffset_35(HandleRef pThis);

		public virtual int GetTopBorderOffset()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetTopBorderOffset_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetTopBorderOffsetMaxValue_36(HandleRef pThis);

		public virtual int GetTopBorderOffsetMaxValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetTopBorderOffsetMaxValue_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_GetTopBorderOffsetMinValue_37(HandleRef pThis);

		public virtual int GetTopBorderOffsetMinValue()
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_GetTopBorderOffsetMinValue_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_IsA_38(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_IsA_38(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_IsTypeOf_39(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_IsTypeOf_39(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_LeftAxisVisibilityOff_40(HandleRef pThis);

		public virtual void LeftAxisVisibilityOff()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_LeftAxisVisibilityOff_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_LeftAxisVisibilityOn_41(HandleRef pThis);

		public virtual void LeftAxisVisibilityOn()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_LeftAxisVisibilityOn_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_LegendVisibilityOff_42(HandleRef pThis);

		public virtual void LegendVisibilityOff()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_LegendVisibilityOff_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_LegendVisibilityOn_43(HandleRef pThis);

		public virtual void LegendVisibilityOn()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_LegendVisibilityOn_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendScaleActor_NewInstance_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLegendScaleActor NewInstance()
		{
			vtkLegendScaleActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_NewInstance_45(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLegendScaleActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_ReleaseGraphicsResources_46(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_ReleaseGraphicsResources_46(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_RenderOpaqueGeometry_47(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_RenderOpaqueGeometry_47(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLegendScaleActor_RenderOverlay_48(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkLegendScaleActor.vtkLegendScaleActor_RenderOverlay_48(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_RightAxisVisibilityOff_49(HandleRef pThis);

		public virtual void RightAxisVisibilityOff()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_RightAxisVisibilityOff_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_RightAxisVisibilityOn_50(HandleRef pThis);

		public virtual void RightAxisVisibilityOn()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_RightAxisVisibilityOn_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLegendScaleActor_SafeDownCast_51(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLegendScaleActor SafeDownCast(vtkObjectBase o)
		{
			vtkLegendScaleActor vtkLegendScaleActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLegendScaleActor.vtkLegendScaleActor_SafeDownCast_51((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLegendScaleActor = (vtkLegendScaleActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLegendScaleActor.Register(null);
				}
			}
			return vtkLegendScaleActor;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_SetBottomAxisVisibility_52(HandleRef pThis, int _arg);

		public virtual void SetBottomAxisVisibility(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetBottomAxisVisibility_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_SetBottomBorderOffset_53(HandleRef pThis, int _arg);

		public virtual void SetBottomBorderOffset(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetBottomBorderOffset_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_SetCornerOffsetFactor_54(HandleRef pThis, double _arg);

		public virtual void SetCornerOffsetFactor(double _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetCornerOffsetFactor_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_SetLabelMode_55(HandleRef pThis, int _arg);

		public virtual void SetLabelMode(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetLabelMode_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_SetLabelModeToDistance_56(HandleRef pThis);

		public void SetLabelModeToDistance()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetLabelModeToDistance_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_SetLabelModeToXYCoordinates_57(HandleRef pThis);

		public void SetLabelModeToXYCoordinates()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetLabelModeToXYCoordinates_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_SetLeftAxisVisibility_58(HandleRef pThis, int _arg);

		public virtual void SetLeftAxisVisibility(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetLeftAxisVisibility_58(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_SetLeftBorderOffset_59(HandleRef pThis, int _arg);

		public virtual void SetLeftBorderOffset(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetLeftBorderOffset_59(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_SetLegendVisibility_60(HandleRef pThis, int _arg);

		public virtual void SetLegendVisibility(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetLegendVisibility_60(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_SetRightAxisVisibility_61(HandleRef pThis, int _arg);

		public virtual void SetRightAxisVisibility(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetRightAxisVisibility_61(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_SetRightBorderOffset_62(HandleRef pThis, int _arg);

		public virtual void SetRightBorderOffset(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetRightBorderOffset_62(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_SetTopAxisVisibility_63(HandleRef pThis, int _arg);

		public virtual void SetTopAxisVisibility(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetTopAxisVisibility_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_SetTopBorderOffset_64(HandleRef pThis, int _arg);

		public virtual void SetTopBorderOffset(int _arg)
		{
			vtkLegendScaleActor.vtkLegendScaleActor_SetTopBorderOffset_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_TopAxisVisibilityOff_65(HandleRef pThis);

		public virtual void TopAxisVisibilityOff()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_TopAxisVisibilityOff_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLegendScaleActor_TopAxisVisibilityOn_66(HandleRef pThis);

		public virtual void TopAxisVisibilityOn()
		{
			vtkLegendScaleActor.vtkLegendScaleActor_TopAxisVisibilityOn_66(base.GetCppThis());
		}
	}
}

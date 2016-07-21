using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPointHandleRepresentation3D : vtkHandleRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointHandleRepresentation3D";

		public new static readonly string MRClassNameKey;

		static vtkPointHandleRepresentation3D()
		{
			vtkPointHandleRepresentation3D.MRClassNameKey = "class vtkPointHandleRepresentation3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointHandleRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointHandleRepresentation3D"));
		}

		public vtkPointHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointHandleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointHandleRepresentation3D New()
		{
			vtkPointHandleRepresentation3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPointHandleRepresentation3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_AllOff_01(HandleRef pThis);

		public void AllOff()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_AllOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_AllOn_02(HandleRef pThis);

		public void AllOn()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_AllOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_BuildRepresentation_03(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_BuildRepresentation_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointHandleRepresentation3D_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_ComputeInteractionState_04(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_GetActors_05(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetActors_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointHandleRepresentation3D_GetBounds_06(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkPointHandleRepresentation3D_GetHotSpotSize_07(HandleRef pThis);

		public virtual double GetHotSpotSize()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetHotSpotSize_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkPointHandleRepresentation3D_GetHotSpotSizeMaxValue_08(HandleRef pThis);

		public virtual double GetHotSpotSizeMaxValue()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetHotSpotSizeMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkPointHandleRepresentation3D_GetHotSpotSizeMinValue_09(HandleRef pThis);

		public virtual double GetHotSpotSizeMinValue()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetHotSpotSizeMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointHandleRepresentation3D_GetOutline_10(HandleRef pThis);

		public int GetOutline()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetOutline_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointHandleRepresentation3D_GetProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetProperty_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointHandleRepresentation3D_GetSelectedProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetSelectedProperty_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointHandleRepresentation3D_GetTranslationMode_13(HandleRef pThis);

		public virtual int GetTranslationMode()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetTranslationMode_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointHandleRepresentation3D_GetXShadows_14(HandleRef pThis);

		public int GetXShadows()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetXShadows_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointHandleRepresentation3D_GetYShadows_15(HandleRef pThis);

		public int GetYShadows()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetYShadows_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointHandleRepresentation3D_GetZShadows_16(HandleRef pThis);

		public int GetZShadows()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetZShadows_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointHandleRepresentation3D_HasTranslucentPolygonalGeometry_17(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_HasTranslucentPolygonalGeometry_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_Highlight_18(HandleRef pThis, int highlight);

		public override void Highlight(int highlight)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_Highlight_18(base.GetCppThis(), highlight);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointHandleRepresentation3D_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointHandleRepresentation3D_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointHandleRepresentation3D_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPointHandleRepresentation3D NewInstance()
		{
			vtkPointHandleRepresentation3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_OutlineOff_23(HandleRef pThis);

		public void OutlineOff()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_OutlineOff_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_OutlineOn_24(HandleRef pThis);

		public void OutlineOn()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_OutlineOn_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_PlaceWidget_25(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_PlaceWidget_25(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_ReleaseGraphicsResources_26(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_ReleaseGraphicsResources_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointHandleRepresentation3D_RenderOpaqueGeometry_27(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_RenderOpaqueGeometry_27(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointHandleRepresentation3D_RenderTranslucentPolygonalGeometry_28(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_RenderTranslucentPolygonalGeometry_28(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointHandleRepresentation3D_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointHandleRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkPointHandleRepresentation3D vtkPointHandleRepresentation3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointHandleRepresentation3D = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointHandleRepresentation3D.Register(null);
				}
			}
			return vtkPointHandleRepresentation3D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_SetDisplayPosition_30(HandleRef pThis, IntPtr p);

		public override void SetDisplayPosition(IntPtr p)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetDisplayPosition_30(base.GetCppThis(), p);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_SetHandleSize_31(HandleRef pThis, double size);

		public override void SetHandleSize(double size)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetHandleSize_31(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_SetHotSpotSize_32(HandleRef pThis, double _arg);

		public virtual void SetHotSpotSize(double _arg)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetHotSpotSize_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_SetOutline_33(HandleRef pThis, int o);

		public void SetOutline(int o)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetOutline_33(base.GetCppThis(), o);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_SetProperty_34(HandleRef pThis, HandleRef arg0);

		public void SetProperty(vtkProperty arg0)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetProperty_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_SetSelectedProperty_35(HandleRef pThis, HandleRef arg0);

		public void SetSelectedProperty(vtkProperty arg0)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetSelectedProperty_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_SetTranslationMode_36(HandleRef pThis, int _arg);

		public virtual void SetTranslationMode(int _arg)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetTranslationMode_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_SetWorldPosition_37(HandleRef pThis, IntPtr p);

		public override void SetWorldPosition(IntPtr p)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetWorldPosition_37(base.GetCppThis(), p);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_SetXShadows_38(HandleRef pThis, int o);

		public void SetXShadows(int o)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetXShadows_38(base.GetCppThis(), o);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_SetYShadows_39(HandleRef pThis, int o);

		public void SetYShadows(int o)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetYShadows_39(base.GetCppThis(), o);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_SetZShadows_40(HandleRef pThis, int o);

		public void SetZShadows(int o)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetZShadows_40(base.GetCppThis(), o);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_ShallowCopy_41(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_ShallowCopy_41(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_StartWidgetInteraction_42(HandleRef pThis, IntPtr eventPos);

		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_StartWidgetInteraction_42(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_TranslationModeOff_43(HandleRef pThis);

		public virtual void TranslationModeOff()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_TranslationModeOff_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_TranslationModeOn_44(HandleRef pThis);

		public virtual void TranslationModeOn()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_TranslationModeOn_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_WidgetInteraction_45(HandleRef pThis, IntPtr eventPos);

		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_WidgetInteraction_45(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_XShadowsOff_46(HandleRef pThis);

		public void XShadowsOff()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_XShadowsOff_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_XShadowsOn_47(HandleRef pThis);

		public void XShadowsOn()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_XShadowsOn_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_YShadowsOff_48(HandleRef pThis);

		public void YShadowsOff()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_YShadowsOff_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_YShadowsOn_49(HandleRef pThis);

		public void YShadowsOn()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_YShadowsOn_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_ZShadowsOff_50(HandleRef pThis);

		public void ZShadowsOff()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_ZShadowsOff_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation3D_ZShadowsOn_51(HandleRef pThis);

		public void ZShadowsOn()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_ZShadowsOn_51(base.GetCppThis());
		}
	}
}

using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkWidgetRepresentation : vtkProp
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWidgetRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkWidgetRepresentation()
		{
			vtkWidgetRepresentation.MRClassNameKey = "class vtkWidgetRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWidgetRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWidgetRepresentation"));
		}

		public vtkWidgetRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_BuildRepresentation_01(HandleRef pThis);

		public virtual void BuildRepresentation()
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public virtual int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_EndWidgetInteraction_03(HandleRef pThis, IntPtr newEventPos);

		public virtual void EndWidgetInteraction(IntPtr newEventPos)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_EndWidgetInteraction_03(base.GetCppThis(), newEventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_GetActors_04(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_GetActors_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_GetActors2D_05(HandleRef pThis, HandleRef arg0);

		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_GetActors2D_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetRepresentation_GetBounds_06(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkWidgetRepresentation.vtkWidgetRepresentation_GetBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkWidgetRepresentation_GetHandleSize_07(HandleRef pThis);

		public virtual double GetHandleSize()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetHandleSize_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkWidgetRepresentation_GetHandleSizeMaxValue_08(HandleRef pThis);

		public virtual double GetHandleSizeMaxValue()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetHandleSizeMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkWidgetRepresentation_GetHandleSizeMinValue_09(HandleRef pThis);

		public virtual double GetHandleSizeMinValue()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetHandleSizeMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetRepresentation_GetInteractionState_10(HandleRef pThis);

		public virtual int GetInteractionState()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetInteractionState_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetRepresentation_GetNeedToRender_11(HandleRef pThis);

		public virtual int GetNeedToRender()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetNeedToRender_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetRepresentation_GetNeedToRenderMaxValue_12(HandleRef pThis);

		public virtual int GetNeedToRenderMaxValue()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetNeedToRenderMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetRepresentation_GetNeedToRenderMinValue_13(HandleRef pThis);

		public virtual int GetNeedToRenderMinValue()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetNeedToRenderMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkWidgetRepresentation_GetPlaceFactor_14(HandleRef pThis);

		public virtual double GetPlaceFactor()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetPlaceFactor_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkWidgetRepresentation_GetPlaceFactorMaxValue_15(HandleRef pThis);

		public virtual double GetPlaceFactorMaxValue()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetPlaceFactorMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkWidgetRepresentation_GetPlaceFactorMinValue_16(HandleRef pThis);

		public virtual double GetPlaceFactorMinValue()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_GetPlaceFactorMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetRepresentation_GetRenderer_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetRepresentation.vtkWidgetRepresentation_GetRenderer_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_GetVolumes_18(HandleRef pThis, HandleRef arg0);

		public override void GetVolumes(vtkPropCollection arg0)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_GetVolumes_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetRepresentation_HasTranslucentPolygonalGeometry_19(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_HasTranslucentPolygonalGeometry_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_Highlight_20(HandleRef pThis, int arg0);

		public virtual void Highlight(int arg0)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_Highlight_20(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetRepresentation_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetRepresentation_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_NeedToRenderOff_23(HandleRef pThis);

		public virtual void NeedToRenderOff()
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_NeedToRenderOff_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_NeedToRenderOn_24(HandleRef pThis);

		public virtual void NeedToRenderOn()
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_NeedToRenderOn_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetRepresentation_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWidgetRepresentation NewInstance()
		{
			vtkWidgetRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetRepresentation.vtkWidgetRepresentation_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_PlaceWidget_26(HandleRef pThis, IntPtr arg0);

		public virtual void PlaceWidget(IntPtr arg0)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_PlaceWidget_26(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_ReleaseGraphicsResources_27(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_ReleaseGraphicsResources_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetRepresentation_RenderOpaqueGeometry_28(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_RenderOpaqueGeometry_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetRepresentation_RenderOverlay_29(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_RenderOverlay_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetRepresentation_RenderTranslucentPolygonalGeometry_30(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_RenderTranslucentPolygonalGeometry_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkWidgetRepresentation_RenderVolumetricGeometry_31(HandleRef pThis, HandleRef arg0);

		public override int RenderVolumetricGeometry(vtkViewport arg0)
		{
			return vtkWidgetRepresentation.vtkWidgetRepresentation_RenderVolumetricGeometry_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkWidgetRepresentation_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWidgetRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkWidgetRepresentation vtkWidgetRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWidgetRepresentation.vtkWidgetRepresentation_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWidgetRepresentation = (vtkWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWidgetRepresentation.Register(null);
				}
			}
			return vtkWidgetRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_SetHandleSize_33(HandleRef pThis, double _arg);

		public virtual void SetHandleSize(double _arg)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_SetHandleSize_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_SetNeedToRender_34(HandleRef pThis, int _arg);

		public virtual void SetNeedToRender(int _arg)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_SetNeedToRender_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_SetPlaceFactor_35(HandleRef pThis, double _arg);

		public virtual void SetPlaceFactor(double _arg)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_SetPlaceFactor_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_SetRenderer_36(HandleRef pThis, HandleRef ren);

		public virtual void SetRenderer(vtkRenderer ren)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_SetRenderer_36(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_ShallowCopy_37(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_ShallowCopy_37(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_StartWidgetInteraction_38(HandleRef pThis, IntPtr eventPos);

		public virtual void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_StartWidgetInteraction_38(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkWidgetRepresentation_WidgetInteraction_39(HandleRef pThis, IntPtr newEventPos);

		public virtual void WidgetInteraction(IntPtr newEventPos)
		{
			vtkWidgetRepresentation.vtkWidgetRepresentation_WidgetInteraction_39(base.GetCppThis(), newEventPos);
		}
	}
}

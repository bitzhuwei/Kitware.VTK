using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSphereHandleRepresentation : vtkHandleRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphereHandleRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkSphereHandleRepresentation()
		{
			vtkSphereHandleRepresentation.MRClassNameKey = "class vtkSphereHandleRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphereHandleRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereHandleRepresentation"));
		}

		public vtkSphereHandleRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereHandleRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSphereHandleRepresentation New()
		{
			vtkSphereHandleRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSphereHandleRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereHandleRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_DeepCopy_03(HandleRef pThis, HandleRef prop);

		public override void DeepCopy(vtkProp prop)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_DeepCopy_03(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_GetActors_04(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetActors_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereHandleRepresentation_GetBounds_05(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSphereHandleRepresentation_GetHotSpotSize_06(HandleRef pThis);

		public virtual double GetHotSpotSize()
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetHotSpotSize_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSphereHandleRepresentation_GetHotSpotSizeMaxValue_07(HandleRef pThis);

		public virtual double GetHotSpotSizeMaxValue()
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetHotSpotSizeMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSphereHandleRepresentation_GetHotSpotSizeMinValue_08(HandleRef pThis);

		public virtual double GetHotSpotSizeMinValue()
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetHotSpotSizeMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereHandleRepresentation_GetProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetProperty_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkSphereHandleRepresentation_GetSelectedProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetSelectedProperty_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern double vtkSphereHandleRepresentation_GetSphereRadius_11(HandleRef pThis);

		public double GetSphereRadius()
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetSphereRadius_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereHandleRepresentation_GetTranslationMode_12(HandleRef pThis);

		public virtual int GetTranslationMode()
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_GetTranslationMode_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereHandleRepresentation_HasTranslucentPolygonalGeometry_13(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_HasTranslucentPolygonalGeometry_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_Highlight_14(HandleRef pThis, int highlight);

		public override void Highlight(int highlight)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_Highlight_14(base.GetCppThis(), highlight);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereHandleRepresentation_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereHandleRepresentation_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereHandleRepresentation_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSphereHandleRepresentation NewInstance()
		{
			vtkSphereHandleRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_PlaceWidget_19(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_PlaceWidget_19(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_ReleaseGraphicsResources_20(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_ReleaseGraphicsResources_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereHandleRepresentation_RenderOpaqueGeometry_21(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_RenderOpaqueGeometry_21(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereHandleRepresentation_RenderTranslucentPolygonalGeometry_22(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_RenderTranslucentPolygonalGeometry_22(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereHandleRepresentation_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSphereHandleRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkSphereHandleRepresentation vtkSphereHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphereHandleRepresentation = (vtkSphereHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphereHandleRepresentation.Register(null);
				}
			}
			return vtkSphereHandleRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_SetDisplayPosition_24(HandleRef pThis, IntPtr p);

		public override void SetDisplayPosition(IntPtr p)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetDisplayPosition_24(base.GetCppThis(), p);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_SetHandleSize_25(HandleRef pThis, double size);

		public override void SetHandleSize(double size)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetHandleSize_25(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_SetHotSpotSize_26(HandleRef pThis, double _arg);

		public virtual void SetHotSpotSize(double _arg)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetHotSpotSize_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_SetProperty_27(HandleRef pThis, HandleRef arg0);

		public void SetProperty(vtkProperty arg0)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetProperty_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_SetSelectedProperty_28(HandleRef pThis, HandleRef arg0);

		public void SetSelectedProperty(vtkProperty arg0)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetSelectedProperty_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_SetSphereRadius_29(HandleRef pThis, double arg0);

		public void SetSphereRadius(double arg0)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetSphereRadius_29(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_SetTranslationMode_30(HandleRef pThis, int _arg);

		public virtual void SetTranslationMode(int _arg)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetTranslationMode_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_SetWorldPosition_31(HandleRef pThis, IntPtr p);

		public override void SetWorldPosition(IntPtr p)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_SetWorldPosition_31(base.GetCppThis(), p);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_ShallowCopy_32(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_ShallowCopy_32(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_StartWidgetInteraction_33(HandleRef pThis, IntPtr eventPos);

		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_StartWidgetInteraction_33(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_TranslationModeOff_34(HandleRef pThis);

		public virtual void TranslationModeOff()
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_TranslationModeOff_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_TranslationModeOn_35(HandleRef pThis);

		public virtual void TranslationModeOn()
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_TranslationModeOn_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereHandleRepresentation_WidgetInteraction_36(HandleRef pThis, IntPtr eventPos);

		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkSphereHandleRepresentation.vtkSphereHandleRepresentation_WidgetInteraction_36(base.GetCppThis(), eventPos);
		}
	}
}

using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTextActor : vtkActor2D
	{
		public enum TEXT_SCALE_MODE_NONE_WrapperEnum
		{
			TEXT_SCALE_MODE_NONE,
			TEXT_SCALE_MODE_PROP,
			TEXT_SCALE_MODE_VIEWPORT
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkTextActor";

		public new static readonly string MRClassNameKey;

		static vtkTextActor()
		{
			vtkTextActor.MRClassNameKey = "class vtkTextActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextActor"));
		}

		public vtkTextActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextActor New()
		{
			vtkTextActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextActor.vtkTextActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTextActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTextActor.vtkTextActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_ComputeScaledFont_01(HandleRef pThis, HandleRef viewport);

		public virtual void ComputeScaledFont(vtkViewport viewport)
		{
			vtkTextActor.vtkTextActor_ComputeScaledFont_01(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_DisplayToSpecified_02(HandleRef pThis, IntPtr pos, HandleRef vport, int specified);

		public void DisplayToSpecified(IntPtr pos, vtkViewport vport, int specified)
		{
			vtkTextActor.vtkTextActor_DisplayToSpecified_02(base.GetCppThis(), pos, (vport == null) ? default(HandleRef) : vport.GetCppThis(), specified);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor_GetAlignmentPoint_03(HandleRef pThis);

		public int GetAlignmentPoint()
		{
			return vtkTextActor.vtkTextActor_GetAlignmentPoint_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkTextActor_GetFontScale_04(HandleRef viewport);

		public static float GetFontScale(vtkViewport viewport)
		{
			return vtkTextActor.vtkTextActor_GetFontScale_04((viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextActor_GetInput_05(HandleRef pThis);

		public string GetInput()
		{
			return Marshal.PtrToStringAnsi(vtkTextActor.vtkTextActor_GetInput_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkTextActor_GetMaximumLineHeight_06(HandleRef pThis);

		public virtual float GetMaximumLineHeight()
		{
			return vtkTextActor.vtkTextActor_GetMaximumLineHeight_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextActor_GetMinimumSize_07(HandleRef pThis);

		public virtual int[] GetMinimumSize()
		{
			IntPtr intPtr = vtkTextActor.vtkTextActor_GetMinimumSize_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_GetMinimumSize_08(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetMinimumSize(ref int _arg1, ref int _arg2)
		{
			vtkTextActor.vtkTextActor_GetMinimumSize_08(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_GetMinimumSize_09(HandleRef pThis, IntPtr _arg);

		public virtual void GetMinimumSize(IntPtr _arg)
		{
			vtkTextActor.vtkTextActor_GetMinimumSize_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkTextActor_GetOrientation_10(HandleRef pThis);

		public virtual float GetOrientation()
		{
			return vtkTextActor.vtkTextActor_GetOrientation_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextActor_GetScaledTextProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetScaledTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextActor.vtkTextActor_GetScaledTextProperty_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkTextActor_GetTextProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextActor.vtkTextActor_GetTextProperty_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkTextActor_GetTextScaleMode_13(HandleRef pThis);

		public virtual int GetTextScaleMode()
		{
			return vtkTextActor.vtkTextActor_GetTextScaleMode_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor_GetTextScaleModeMaxValue_14(HandleRef pThis);

		public virtual int GetTextScaleModeMaxValue()
		{
			return vtkTextActor.vtkTextActor_GetTextScaleModeMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor_GetTextScaleModeMinValue_15(HandleRef pThis);

		public virtual int GetTextScaleModeMinValue()
		{
			return vtkTextActor.vtkTextActor_GetTextScaleModeMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor_GetUseBorderAlign_16(HandleRef pThis);

		public virtual int GetUseBorderAlign()
		{
			return vtkTextActor.vtkTextActor_GetUseBorderAlign_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor_HasTranslucentPolygonalGeometry_17(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkTextActor.vtkTextActor_HasTranslucentPolygonalGeometry_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTextActor.vtkTextActor_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTextActor.vtkTextActor_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextActor_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTextActor NewInstance()
		{
			vtkTextActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextActor.vtkTextActor_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_ReleaseGraphicsResources_22(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTextActor.vtkTextActor_ReleaseGraphicsResources_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor_RenderOpaqueGeometry_23(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkTextActor.vtkTextActor_RenderOpaqueGeometry_23(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor_RenderOverlay_24(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkTextActor.vtkTextActor_RenderOverlay_24(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextActor_RenderTranslucentPolygonalGeometry_25(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkTextActor.vtkTextActor_RenderTranslucentPolygonalGeometry_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextActor_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextActor SafeDownCast(vtkObjectBase o)
		{
			vtkTextActor vtkTextActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextActor.vtkTextActor_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextActor = (vtkTextActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextActor.Register(null);
				}
			}
			return vtkTextActor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_SetAlignmentPoint_27(HandleRef pThis, int point);

		public void SetAlignmentPoint(int point)
		{
			vtkTextActor.vtkTextActor_SetAlignmentPoint_27(base.GetCppThis(), point);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_SetInput_28(HandleRef pThis, string inputString);

		public void SetInput(string inputString)
		{
			vtkTextActor.vtkTextActor_SetInput_28(base.GetCppThis(), inputString);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_SetMapper_29(HandleRef pThis, HandleRef mapper);

		public void SetMapper(vtkPolyDataMapper2D mapper)
		{
			vtkTextActor.vtkTextActor_SetMapper_29(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_SetMaximumLineHeight_30(HandleRef pThis, float _arg);

		public virtual void SetMaximumLineHeight(float _arg)
		{
			vtkTextActor.vtkTextActor_SetMaximumLineHeight_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_SetMinimumSize_31(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetMinimumSize(int _arg1, int _arg2)
		{
			vtkTextActor.vtkTextActor_SetMinimumSize_31(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_SetMinimumSize_32(HandleRef pThis, IntPtr _arg);

		public void SetMinimumSize(IntPtr _arg)
		{
			vtkTextActor.vtkTextActor_SetMinimumSize_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_SetNonLinearFontScale_33(HandleRef pThis, double exponent, int target);

		public virtual void SetNonLinearFontScale(double exponent, int target)
		{
			vtkTextActor.vtkTextActor_SetNonLinearFontScale_33(base.GetCppThis(), exponent, target);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_SetOrientation_34(HandleRef pThis, float orientation);

		public void SetOrientation(float orientation)
		{
			vtkTextActor.vtkTextActor_SetOrientation_34(base.GetCppThis(), orientation);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_SetTextProperty_35(HandleRef pThis, HandleRef p);

		public virtual void SetTextProperty(vtkTextProperty p)
		{
			vtkTextActor.vtkTextActor_SetTextProperty_35(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_SetTextScaleMode_36(HandleRef pThis, int _arg);

		public virtual void SetTextScaleMode(int _arg)
		{
			vtkTextActor.vtkTextActor_SetTextScaleMode_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_SetTextScaleModeToNone_37(HandleRef pThis);

		public void SetTextScaleModeToNone()
		{
			vtkTextActor.vtkTextActor_SetTextScaleModeToNone_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_SetTextScaleModeToProp_38(HandleRef pThis);

		public void SetTextScaleModeToProp()
		{
			vtkTextActor.vtkTextActor_SetTextScaleModeToProp_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_SetTextScaleModeToViewport_39(HandleRef pThis);

		public void SetTextScaleModeToViewport()
		{
			vtkTextActor.vtkTextActor_SetTextScaleModeToViewport_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_SetUseBorderAlign_40(HandleRef pThis, int _arg);

		public virtual void SetUseBorderAlign(int _arg)
		{
			vtkTextActor.vtkTextActor_SetUseBorderAlign_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_ShallowCopy_41(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkTextActor.vtkTextActor_ShallowCopy_41(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_SpecifiedToDisplay_42(HandleRef pThis, IntPtr pos, HandleRef vport, int specified);

		public void SpecifiedToDisplay(IntPtr pos, vtkViewport vport, int specified)
		{
			vtkTextActor.vtkTextActor_SpecifiedToDisplay_42(base.GetCppThis(), pos, (vport == null) ? default(HandleRef) : vport.GetCppThis(), specified);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_UseBorderAlignOff_43(HandleRef pThis);

		public virtual void UseBorderAlignOff()
		{
			vtkTextActor.vtkTextActor_UseBorderAlignOff_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextActor_UseBorderAlignOn_44(HandleRef pThis);

		public virtual void UseBorderAlignOn()
		{
			vtkTextActor.vtkTextActor_UseBorderAlignOn_44(base.GetCppThis());
		}
	}
}

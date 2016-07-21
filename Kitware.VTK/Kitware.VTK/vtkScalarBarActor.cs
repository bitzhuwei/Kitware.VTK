using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkScalarBarActor : vtkActor2D
	{
		public enum PrecedeScalarBar_WrapperEnum
		{
			PrecedeScalarBar,
			SucceedScalarBar
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkScalarBarActor";

		public new static readonly string MRClassNameKey;

		static vtkScalarBarActor()
		{
			vtkScalarBarActor.MRClassNameKey = "class vtkScalarBarActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScalarBarActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarBarActor"));
		}

		public vtkScalarBarActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkScalarBarActor New()
		{
			vtkScalarBarActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarBarActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkScalarBarActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkScalarBarActor.vtkScalarBarActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarActor_GetComponentTitle_01(HandleRef pThis);

		public virtual string GetComponentTitle()
		{
			return Marshal.PtrToStringAnsi(vtkScalarBarActor.vtkScalarBarActor_GetComponentTitle_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarActor_GetLabelFormat_02(HandleRef pThis);

		public virtual string GetLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkScalarBarActor.vtkScalarBarActor_GetLabelFormat_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarActor_GetLabelTextProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_GetLabelTextProperty_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkScalarBarActor_GetLookupTable_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_GetLookupTable_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_GetMaximumHeightInPixels_05(HandleRef pThis);

		public virtual int GetMaximumHeightInPixels()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetMaximumHeightInPixels_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_GetMaximumNumberOfColors_06(HandleRef pThis);

		public virtual int GetMaximumNumberOfColors()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetMaximumNumberOfColors_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_GetMaximumNumberOfColorsMaxValue_07(HandleRef pThis);

		public virtual int GetMaximumNumberOfColorsMaxValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetMaximumNumberOfColorsMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_GetMaximumNumberOfColorsMinValue_08(HandleRef pThis);

		public virtual int GetMaximumNumberOfColorsMinValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetMaximumNumberOfColorsMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_GetMaximumWidthInPixels_09(HandleRef pThis);

		public virtual int GetMaximumWidthInPixels()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetMaximumWidthInPixels_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_GetNumberOfLabels_10(HandleRef pThis);

		public virtual int GetNumberOfLabels()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetNumberOfLabels_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_GetNumberOfLabelsMaxValue_11(HandleRef pThis);

		public virtual int GetNumberOfLabelsMaxValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetNumberOfLabelsMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_GetNumberOfLabelsMinValue_12(HandleRef pThis);

		public virtual int GetNumberOfLabelsMinValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetNumberOfLabelsMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_GetOrientation_13(HandleRef pThis);

		public virtual int GetOrientation()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetOrientation_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_GetOrientationMaxValue_14(HandleRef pThis);

		public virtual int GetOrientationMaxValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetOrientationMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_GetOrientationMinValue_15(HandleRef pThis);

		public virtual int GetOrientationMinValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetOrientationMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_GetTextPosition_16(HandleRef pThis);

		public virtual int GetTextPosition()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetTextPosition_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_GetTextPositionMaxValue_17(HandleRef pThis);

		public virtual int GetTextPositionMaxValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetTextPositionMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_GetTextPositionMinValue_18(HandleRef pThis);

		public virtual int GetTextPositionMinValue()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetTextPositionMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarActor_GetTextureActor_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkActor2D GetTextureActor()
		{
			vtkActor2D vtkActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_GetTextureActor_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor2D = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor2D.Register(null);
				}
			}
			return vtkActor2D;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkScalarBarActor_GetTextureGridWidth_20(HandleRef pThis);

		public virtual double GetTextureGridWidth()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetTextureGridWidth_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarActor_GetTitle_21(HandleRef pThis);

		public virtual string GetTitle()
		{
			return Marshal.PtrToStringAnsi(vtkScalarBarActor.vtkScalarBarActor_GetTitle_21(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarActor_GetTitleTextProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_GetTitleTextProperty_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkScalarBarActor_GetUseOpacity_23(HandleRef pThis);

		public virtual int GetUseOpacity()
		{
			return vtkScalarBarActor.vtkScalarBarActor_GetUseOpacity_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_HasTranslucentPolygonalGeometry_24(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkScalarBarActor.vtkScalarBarActor_HasTranslucentPolygonalGeometry_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_IsA_25(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkScalarBarActor.vtkScalarBarActor_IsA_25(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_IsTypeOf_26(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkScalarBarActor.vtkScalarBarActor_IsTypeOf_26(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarActor_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkScalarBarActor NewInstance()
		{
			vtkScalarBarActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_NewInstance_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarBarActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_ReleaseGraphicsResources_29(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkScalarBarActor.vtkScalarBarActor_ReleaseGraphicsResources_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_RenderOpaqueGeometry_30(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkScalarBarActor.vtkScalarBarActor_RenderOpaqueGeometry_30(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_RenderOverlay_31(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkScalarBarActor.vtkScalarBarActor_RenderOverlay_31(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkScalarBarActor_RenderTranslucentPolygonalGeometry_32(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkScalarBarActor.vtkScalarBarActor_RenderTranslucentPolygonalGeometry_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarActor_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkScalarBarActor SafeDownCast(vtkObjectBase o)
		{
			vtkScalarBarActor vtkScalarBarActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarActor.vtkScalarBarActor_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarBarActor = (vtkScalarBarActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarBarActor.Register(null);
				}
			}
			return vtkScalarBarActor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetComponentTitle_34(HandleRef pThis, string _arg);

		public virtual void SetComponentTitle(string _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetComponentTitle_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetLabelFormat_35(HandleRef pThis, string _arg);

		public virtual void SetLabelFormat(string _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetLabelFormat_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetLabelTextProperty_36(HandleRef pThis, HandleRef p);

		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetLabelTextProperty_36(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetLookupTable_37(HandleRef pThis, HandleRef arg0);

		public virtual void SetLookupTable(vtkScalarsToColors arg0)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetLookupTable_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetMaximumHeightInPixels_38(HandleRef pThis, int _arg);

		public virtual void SetMaximumHeightInPixels(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetMaximumHeightInPixels_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetMaximumNumberOfColors_39(HandleRef pThis, int _arg);

		public virtual void SetMaximumNumberOfColors(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetMaximumNumberOfColors_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetMaximumWidthInPixels_40(HandleRef pThis, int _arg);

		public virtual void SetMaximumWidthInPixels(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetMaximumWidthInPixels_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetNumberOfLabels_41(HandleRef pThis, int _arg);

		public virtual void SetNumberOfLabels(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetNumberOfLabels_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetOrientation_42(HandleRef pThis, int _arg);

		public virtual void SetOrientation(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetOrientation_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetOrientationToHorizontal_43(HandleRef pThis);

		public void SetOrientationToHorizontal()
		{
			vtkScalarBarActor.vtkScalarBarActor_SetOrientationToHorizontal_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetOrientationToVertical_44(HandleRef pThis);

		public void SetOrientationToVertical()
		{
			vtkScalarBarActor.vtkScalarBarActor_SetOrientationToVertical_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetTextPosition_45(HandleRef pThis, int _arg);

		public virtual void SetTextPosition(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetTextPosition_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetTextPositionToPrecedeScalarBar_46(HandleRef pThis);

		public virtual void SetTextPositionToPrecedeScalarBar()
		{
			vtkScalarBarActor.vtkScalarBarActor_SetTextPositionToPrecedeScalarBar_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetTextPositionToSucceedScalarBar_47(HandleRef pThis);

		public virtual void SetTextPositionToSucceedScalarBar()
		{
			vtkScalarBarActor.vtkScalarBarActor_SetTextPositionToSucceedScalarBar_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetTextureGridWidth_48(HandleRef pThis, double _arg);

		public virtual void SetTextureGridWidth(double _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetTextureGridWidth_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetTitle_49(HandleRef pThis, string _arg);

		public virtual void SetTitle(string _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetTitle_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetTitleTextProperty_50(HandleRef pThis, HandleRef p);

		public virtual void SetTitleTextProperty(vtkTextProperty p)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetTitleTextProperty_50(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_SetUseOpacity_51(HandleRef pThis, int _arg);

		public virtual void SetUseOpacity(int _arg)
		{
			vtkScalarBarActor.vtkScalarBarActor_SetUseOpacity_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_ShallowCopy_52(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkScalarBarActor.vtkScalarBarActor_ShallowCopy_52(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_UseOpacityOff_53(HandleRef pThis);

		public virtual void UseOpacityOff()
		{
			vtkScalarBarActor.vtkScalarBarActor_UseOpacityOff_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkScalarBarActor_UseOpacityOn_54(HandleRef pThis);

		public virtual void UseOpacityOn()
		{
			vtkScalarBarActor.vtkScalarBarActor_UseOpacityOn_54(base.GetCppThis());
		}
	}
}

using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCornerAnnotation : vtkActor2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCornerAnnotation";

		public new static readonly string MRClassNameKey;

		static vtkCornerAnnotation()
		{
			vtkCornerAnnotation.MRClassNameKey = "class vtkCornerAnnotation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCornerAnnotation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCornerAnnotation"));
		}

		public vtkCornerAnnotation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCornerAnnotation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCornerAnnotation New()
		{
			vtkCornerAnnotation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCornerAnnotation.vtkCornerAnnotation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCornerAnnotation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCornerAnnotation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCornerAnnotation.vtkCornerAnnotation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_ClearAllTexts_01(HandleRef pThis);

		public void ClearAllTexts()
		{
			vtkCornerAnnotation.vtkCornerAnnotation_ClearAllTexts_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_CopyAllTextsFrom_02(HandleRef pThis, HandleRef ca);

		public void CopyAllTextsFrom(vtkCornerAnnotation ca)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_CopyAllTextsFrom_02(base.GetCppThis(), (ca == null) ? default(HandleRef) : ca.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCornerAnnotation_GetImageActor_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageActor GetImageActor()
		{
			vtkImageActor vtkImageActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCornerAnnotation.vtkCornerAnnotation_GetImageActor_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageActor = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageActor.Register(null);
				}
			}
			return vtkImageActor;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkCornerAnnotation_GetLevelScale_04(HandleRef pThis);

		public virtual double GetLevelScale()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetLevelScale_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkCornerAnnotation_GetLevelShift_05(HandleRef pThis);

		public virtual double GetLevelShift()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetLevelShift_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkCornerAnnotation_GetLinearFontScaleFactor_06(HandleRef pThis);

		public virtual double GetLinearFontScaleFactor()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetLinearFontScaleFactor_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCornerAnnotation_GetMaximumFontSize_07(HandleRef pThis);

		public virtual int GetMaximumFontSize()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetMaximumFontSize_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkCornerAnnotation_GetMaximumLineHeight_08(HandleRef pThis);

		public virtual double GetMaximumLineHeight()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetMaximumLineHeight_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCornerAnnotation_GetMinimumFontSize_09(HandleRef pThis);

		public virtual int GetMinimumFontSize()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetMinimumFontSize_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkCornerAnnotation_GetNonlinearFontScaleFactor_10(HandleRef pThis);

		public virtual double GetNonlinearFontScaleFactor()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetNonlinearFontScaleFactor_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCornerAnnotation_GetShowSliceAndImage_11(HandleRef pThis);

		public virtual int GetShowSliceAndImage()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetShowSliceAndImage_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCornerAnnotation_GetText_12(HandleRef pThis, int i);

		public string GetText(int i)
		{
			return Marshal.PtrToStringAnsi(vtkCornerAnnotation.vtkCornerAnnotation_GetText_12(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCornerAnnotation_GetTextProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCornerAnnotation.vtkCornerAnnotation_GetTextProperty_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkCornerAnnotation_GetWindowLevel_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageMapToWindowLevelColors GetWindowLevel()
		{
			vtkImageMapToWindowLevelColors vtkImageMapToWindowLevelColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCornerAnnotation.vtkCornerAnnotation_GetWindowLevel_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapToWindowLevelColors = (vtkImageMapToWindowLevelColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapToWindowLevelColors.Register(null);
				}
			}
			return vtkImageMapToWindowLevelColors;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCornerAnnotation_HasTranslucentPolygonalGeometry_15(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_HasTranslucentPolygonalGeometry_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCornerAnnotation_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCornerAnnotation_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCornerAnnotation_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCornerAnnotation NewInstance()
		{
			vtkCornerAnnotation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCornerAnnotation.vtkCornerAnnotation_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCornerAnnotation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_ReleaseGraphicsResources_20(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_ReleaseGraphicsResources_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCornerAnnotation_RenderOpaqueGeometry_21(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_RenderOpaqueGeometry_21(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCornerAnnotation_RenderOverlay_22(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_RenderOverlay_22(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkCornerAnnotation_RenderTranslucentPolygonalGeometry_23(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_RenderTranslucentPolygonalGeometry_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkCornerAnnotation_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCornerAnnotation SafeDownCast(vtkObjectBase o)
		{
			vtkCornerAnnotation vtkCornerAnnotation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCornerAnnotation.vtkCornerAnnotation_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCornerAnnotation = (vtkCornerAnnotation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCornerAnnotation.Register(null);
				}
			}
			return vtkCornerAnnotation;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_SetImageActor_25(HandleRef pThis, HandleRef arg0);

		public void SetImageActor(vtkImageActor arg0)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetImageActor_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_SetLevelScale_26(HandleRef pThis, double _arg);

		public virtual void SetLevelScale(double _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetLevelScale_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_SetLevelShift_27(HandleRef pThis, double _arg);

		public virtual void SetLevelShift(double _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetLevelShift_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_SetLinearFontScaleFactor_28(HandleRef pThis, double _arg);

		public virtual void SetLinearFontScaleFactor(double _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetLinearFontScaleFactor_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_SetMaximumFontSize_29(HandleRef pThis, int _arg);

		public virtual void SetMaximumFontSize(int _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetMaximumFontSize_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_SetMaximumLineHeight_30(HandleRef pThis, double _arg);

		public virtual void SetMaximumLineHeight(double _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetMaximumLineHeight_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_SetMinimumFontSize_31(HandleRef pThis, int _arg);

		public virtual void SetMinimumFontSize(int _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetMinimumFontSize_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_SetNonlinearFontScaleFactor_32(HandleRef pThis, double _arg);

		public virtual void SetNonlinearFontScaleFactor(double _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetNonlinearFontScaleFactor_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_SetShowSliceAndImage_33(HandleRef pThis, int _arg);

		public virtual void SetShowSliceAndImage(int _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetShowSliceAndImage_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_SetText_34(HandleRef pThis, int i, string text);

		public void SetText(int i, string text)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetText_34(base.GetCppThis(), i, text);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_SetTextProperty_35(HandleRef pThis, HandleRef p);

		public virtual void SetTextProperty(vtkTextProperty p)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetTextProperty_35(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_SetWindowLevel_36(HandleRef pThis, HandleRef arg0);

		public void SetWindowLevel(vtkImageMapToWindowLevelColors arg0)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetWindowLevel_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_ShowSliceAndImageOff_37(HandleRef pThis);

		public virtual void ShowSliceAndImageOff()
		{
			vtkCornerAnnotation.vtkCornerAnnotation_ShowSliceAndImageOff_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkCornerAnnotation_ShowSliceAndImageOn_38(HandleRef pThis);

		public virtual void ShowSliceAndImageOn()
		{
			vtkCornerAnnotation.vtkCornerAnnotation_ShowSliceAndImageOn_38(base.GetCppThis());
		}
	}
}

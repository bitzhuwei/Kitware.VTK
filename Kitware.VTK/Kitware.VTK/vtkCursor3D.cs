using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCursor3D : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCursor3D";

		public new static readonly string MRClassNameKey;

		static vtkCursor3D()
		{
			vtkCursor3D.MRClassNameKey = "class vtkCursor3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCursor3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCursor3D"));
		}

		public vtkCursor3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCursor3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCursor3D New()
		{
			vtkCursor3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCursor3D.vtkCursor3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCursor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCursor3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCursor3D.vtkCursor3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_AllOff_01(HandleRef pThis);

		public void AllOff()
		{
			vtkCursor3D.vtkCursor3D_AllOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_AllOn_02(HandleRef pThis);

		public void AllOn()
		{
			vtkCursor3D.vtkCursor3D_AllOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_AxesOff_03(HandleRef pThis);

		public virtual void AxesOff()
		{
			vtkCursor3D.vtkCursor3D_AxesOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_AxesOn_04(HandleRef pThis);

		public virtual void AxesOn()
		{
			vtkCursor3D.vtkCursor3D_AxesOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor3D_GetAxes_05(HandleRef pThis);

		public virtual int GetAxes()
		{
			return vtkCursor3D.vtkCursor3D_GetAxes_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCursor3D_GetFocalPoint_06(HandleRef pThis);

		public virtual double[] GetFocalPoint()
		{
			IntPtr intPtr = vtkCursor3D.vtkCursor3D_GetFocalPoint_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_GetFocalPoint_07(HandleRef pThis, IntPtr data);

		public virtual void GetFocalPoint(IntPtr data)
		{
			vtkCursor3D.vtkCursor3D_GetFocalPoint_07(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCursor3D_GetFocus_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetFocus()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCursor3D.vtkCursor3D_GetFocus_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCursor3D_GetModelBounds_09(HandleRef pThis);

		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkCursor3D.vtkCursor3D_GetModelBounds_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_GetModelBounds_10(HandleRef pThis, IntPtr data);

		public virtual void GetModelBounds(IntPtr data)
		{
			vtkCursor3D.vtkCursor3D_GetModelBounds_10(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor3D_GetOutline_11(HandleRef pThis);

		public virtual int GetOutline()
		{
			return vtkCursor3D.vtkCursor3D_GetOutline_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor3D_GetTranslationMode_12(HandleRef pThis);

		public virtual int GetTranslationMode()
		{
			return vtkCursor3D.vtkCursor3D_GetTranslationMode_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor3D_GetWrap_13(HandleRef pThis);

		public virtual int GetWrap()
		{
			return vtkCursor3D.vtkCursor3D_GetWrap_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor3D_GetXShadows_14(HandleRef pThis);

		public virtual int GetXShadows()
		{
			return vtkCursor3D.vtkCursor3D_GetXShadows_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor3D_GetYShadows_15(HandleRef pThis);

		public virtual int GetYShadows()
		{
			return vtkCursor3D.vtkCursor3D_GetYShadows_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor3D_GetZShadows_16(HandleRef pThis);

		public virtual int GetZShadows()
		{
			return vtkCursor3D.vtkCursor3D_GetZShadows_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor3D_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCursor3D.vtkCursor3D_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor3D_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCursor3D.vtkCursor3D_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCursor3D_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCursor3D NewInstance()
		{
			vtkCursor3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCursor3D.vtkCursor3D_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCursor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_OutlineOff_21(HandleRef pThis);

		public virtual void OutlineOff()
		{
			vtkCursor3D.vtkCursor3D_OutlineOff_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_OutlineOn_22(HandleRef pThis);

		public virtual void OutlineOn()
		{
			vtkCursor3D.vtkCursor3D_OutlineOn_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCursor3D_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCursor3D SafeDownCast(vtkObjectBase o)
		{
			vtkCursor3D vtkCursor3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCursor3D.vtkCursor3D_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCursor3D = (vtkCursor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCursor3D.Register(null);
				}
			}
			return vtkCursor3D;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_SetAxes_24(HandleRef pThis, int _arg);

		public virtual void SetAxes(int _arg)
		{
			vtkCursor3D.vtkCursor3D_SetAxes_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_SetFocalPoint_25(HandleRef pThis, IntPtr x);

		public void SetFocalPoint(IntPtr x)
		{
			vtkCursor3D.vtkCursor3D_SetFocalPoint_25(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_SetFocalPoint_26(HandleRef pThis, double x, double y, double z);

		public void SetFocalPoint(double x, double y, double z)
		{
			vtkCursor3D.vtkCursor3D_SetFocalPoint_26(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_SetModelBounds_27(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public void SetModelBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkCursor3D.vtkCursor3D_SetModelBounds_27(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_SetModelBounds_28(HandleRef pThis, IntPtr bounds);

		public void SetModelBounds(IntPtr bounds)
		{
			vtkCursor3D.vtkCursor3D_SetModelBounds_28(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_SetOutline_29(HandleRef pThis, int _arg);

		public virtual void SetOutline(int _arg)
		{
			vtkCursor3D.vtkCursor3D_SetOutline_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_SetTranslationMode_30(HandleRef pThis, int _arg);

		public virtual void SetTranslationMode(int _arg)
		{
			vtkCursor3D.vtkCursor3D_SetTranslationMode_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_SetWrap_31(HandleRef pThis, int _arg);

		public virtual void SetWrap(int _arg)
		{
			vtkCursor3D.vtkCursor3D_SetWrap_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_SetXShadows_32(HandleRef pThis, int _arg);

		public virtual void SetXShadows(int _arg)
		{
			vtkCursor3D.vtkCursor3D_SetXShadows_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_SetYShadows_33(HandleRef pThis, int _arg);

		public virtual void SetYShadows(int _arg)
		{
			vtkCursor3D.vtkCursor3D_SetYShadows_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_SetZShadows_34(HandleRef pThis, int _arg);

		public virtual void SetZShadows(int _arg)
		{
			vtkCursor3D.vtkCursor3D_SetZShadows_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_TranslationModeOff_35(HandleRef pThis);

		public virtual void TranslationModeOff()
		{
			vtkCursor3D.vtkCursor3D_TranslationModeOff_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_TranslationModeOn_36(HandleRef pThis);

		public virtual void TranslationModeOn()
		{
			vtkCursor3D.vtkCursor3D_TranslationModeOn_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_WrapOff_37(HandleRef pThis);

		public virtual void WrapOff()
		{
			vtkCursor3D.vtkCursor3D_WrapOff_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_WrapOn_38(HandleRef pThis);

		public virtual void WrapOn()
		{
			vtkCursor3D.vtkCursor3D_WrapOn_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_XShadowsOff_39(HandleRef pThis);

		public virtual void XShadowsOff()
		{
			vtkCursor3D.vtkCursor3D_XShadowsOff_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_XShadowsOn_40(HandleRef pThis);

		public virtual void XShadowsOn()
		{
			vtkCursor3D.vtkCursor3D_XShadowsOn_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_YShadowsOff_41(HandleRef pThis);

		public virtual void YShadowsOff()
		{
			vtkCursor3D.vtkCursor3D_YShadowsOff_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_YShadowsOn_42(HandleRef pThis);

		public virtual void YShadowsOn()
		{
			vtkCursor3D.vtkCursor3D_YShadowsOn_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_ZShadowsOff_43(HandleRef pThis);

		public virtual void ZShadowsOff()
		{
			vtkCursor3D.vtkCursor3D_ZShadowsOff_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor3D_ZShadowsOn_44(HandleRef pThis);

		public virtual void ZShadowsOn()
		{
			vtkCursor3D.vtkCursor3D_ZShadowsOn_44(base.GetCppThis());
		}
	}
}

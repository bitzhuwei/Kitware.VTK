using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCursor2D : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCursor2D";

		public new static readonly string MRClassNameKey;

		static vtkCursor2D()
		{
			vtkCursor2D.MRClassNameKey = "class vtkCursor2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCursor2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCursor2D"));
		}

		public vtkCursor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCursor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCursor2D New()
		{
			vtkCursor2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCursor2D.vtkCursor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCursor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCursor2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCursor2D.vtkCursor2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_AllOff_01(HandleRef pThis);

		public void AllOff()
		{
			vtkCursor2D.vtkCursor2D_AllOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_AllOn_02(HandleRef pThis);

		public void AllOn()
		{
			vtkCursor2D.vtkCursor2D_AllOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_AxesOff_03(HandleRef pThis);

		public virtual void AxesOff()
		{
			vtkCursor2D.vtkCursor2D_AxesOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_AxesOn_04(HandleRef pThis);

		public virtual void AxesOn()
		{
			vtkCursor2D.vtkCursor2D_AxesOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor2D_GetAxes_05(HandleRef pThis);

		public virtual int GetAxes()
		{
			return vtkCursor2D.vtkCursor2D_GetAxes_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCursor2D_GetFocalPoint_06(HandleRef pThis);

		public virtual double[] GetFocalPoint()
		{
			IntPtr intPtr = vtkCursor2D.vtkCursor2D_GetFocalPoint_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_GetFocalPoint_07(HandleRef pThis, IntPtr data);

		public virtual void GetFocalPoint(IntPtr data)
		{
			vtkCursor2D.vtkCursor2D_GetFocalPoint_07(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCursor2D_GetModelBounds_08(HandleRef pThis);

		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkCursor2D.vtkCursor2D_GetModelBounds_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_GetModelBounds_09(HandleRef pThis, IntPtr data);

		public virtual void GetModelBounds(IntPtr data)
		{
			vtkCursor2D.vtkCursor2D_GetModelBounds_09(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor2D_GetOutline_10(HandleRef pThis);

		public virtual int GetOutline()
		{
			return vtkCursor2D.vtkCursor2D_GetOutline_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor2D_GetPoint_11(HandleRef pThis);

		public virtual int GetPoint()
		{
			return vtkCursor2D.vtkCursor2D_GetPoint_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCursor2D_GetRadius_12(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkCursor2D.vtkCursor2D_GetRadius_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCursor2D_GetRadiusMaxValue_13(HandleRef pThis);

		public virtual double GetRadiusMaxValue()
		{
			return vtkCursor2D.vtkCursor2D_GetRadiusMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCursor2D_GetRadiusMinValue_14(HandleRef pThis);

		public virtual double GetRadiusMinValue()
		{
			return vtkCursor2D.vtkCursor2D_GetRadiusMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor2D_GetTranslationMode_15(HandleRef pThis);

		public virtual int GetTranslationMode()
		{
			return vtkCursor2D.vtkCursor2D_GetTranslationMode_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor2D_GetWrap_16(HandleRef pThis);

		public virtual int GetWrap()
		{
			return vtkCursor2D.vtkCursor2D_GetWrap_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor2D_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCursor2D.vtkCursor2D_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCursor2D_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCursor2D.vtkCursor2D_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCursor2D_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCursor2D NewInstance()
		{
			vtkCursor2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCursor2D.vtkCursor2D_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCursor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_OutlineOff_21(HandleRef pThis);

		public virtual void OutlineOff()
		{
			vtkCursor2D.vtkCursor2D_OutlineOff_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_OutlineOn_22(HandleRef pThis);

		public virtual void OutlineOn()
		{
			vtkCursor2D.vtkCursor2D_OutlineOn_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_PointOff_23(HandleRef pThis);

		public virtual void PointOff()
		{
			vtkCursor2D.vtkCursor2D_PointOff_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_PointOn_24(HandleRef pThis);

		public virtual void PointOn()
		{
			vtkCursor2D.vtkCursor2D_PointOn_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCursor2D_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCursor2D SafeDownCast(vtkObjectBase o)
		{
			vtkCursor2D vtkCursor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCursor2D.vtkCursor2D_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCursor2D = (vtkCursor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCursor2D.Register(null);
				}
			}
			return vtkCursor2D;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_SetAxes_26(HandleRef pThis, int _arg);

		public virtual void SetAxes(int _arg)
		{
			vtkCursor2D.vtkCursor2D_SetAxes_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_SetFocalPoint_27(HandleRef pThis, IntPtr x);

		public void SetFocalPoint(IntPtr x)
		{
			vtkCursor2D.vtkCursor2D_SetFocalPoint_27(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_SetFocalPoint_28(HandleRef pThis, double x, double y, double z);

		public void SetFocalPoint(double x, double y, double z)
		{
			vtkCursor2D.vtkCursor2D_SetFocalPoint_28(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_SetModelBounds_29(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public void SetModelBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkCursor2D.vtkCursor2D_SetModelBounds_29(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_SetModelBounds_30(HandleRef pThis, IntPtr bounds);

		public void SetModelBounds(IntPtr bounds)
		{
			vtkCursor2D.vtkCursor2D_SetModelBounds_30(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_SetOutline_31(HandleRef pThis, int _arg);

		public virtual void SetOutline(int _arg)
		{
			vtkCursor2D.vtkCursor2D_SetOutline_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_SetPoint_32(HandleRef pThis, int _arg);

		public virtual void SetPoint(int _arg)
		{
			vtkCursor2D.vtkCursor2D_SetPoint_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_SetRadius_33(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkCursor2D.vtkCursor2D_SetRadius_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_SetTranslationMode_34(HandleRef pThis, int _arg);

		public virtual void SetTranslationMode(int _arg)
		{
			vtkCursor2D.vtkCursor2D_SetTranslationMode_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_SetWrap_35(HandleRef pThis, int _arg);

		public virtual void SetWrap(int _arg)
		{
			vtkCursor2D.vtkCursor2D_SetWrap_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_TranslationModeOff_36(HandleRef pThis);

		public virtual void TranslationModeOff()
		{
			vtkCursor2D.vtkCursor2D_TranslationModeOff_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_TranslationModeOn_37(HandleRef pThis);

		public virtual void TranslationModeOn()
		{
			vtkCursor2D.vtkCursor2D_TranslationModeOn_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_WrapOff_38(HandleRef pThis);

		public virtual void WrapOff()
		{
			vtkCursor2D.vtkCursor2D_WrapOff_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCursor2D_WrapOn_39(HandleRef pThis);

		public virtual void WrapOn()
		{
			vtkCursor2D.vtkCursor2D_WrapOn_39(base.GetCppThis());
		}
	}
}

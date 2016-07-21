using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProperty2D : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkProperty2D";

		public new static readonly string MRClassNameKey;

		static vtkProperty2D()
		{
			vtkProperty2D.MRClassNameKey = "class vtkProperty2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProperty2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProperty2D"));
		}

		public vtkProperty2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProperty2D New()
		{
			vtkProperty2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProperty2D.vtkProperty2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProperty2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProperty2D.vtkProperty2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProperty2D_DeepCopy_01(HandleRef pThis, HandleRef p);

		public void DeepCopy(vtkProperty2D p)
		{
			vtkProperty2D.vtkProperty2D_DeepCopy_01(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty2D_GetColor_02(HandleRef pThis);

		public virtual double[] GetColor()
		{
			IntPtr intPtr = vtkProperty2D.vtkProperty2D_GetColor_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProperty2D_GetColor_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProperty2D.vtkProperty2D_GetColor_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProperty2D_GetColor_04(HandleRef pThis, IntPtr _arg);

		public virtual void GetColor(IntPtr _arg)
		{
			vtkProperty2D.vtkProperty2D_GetColor_04(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProperty2D_GetDisplayLocation_05(HandleRef pThis);

		public virtual int GetDisplayLocation()
		{
			return vtkProperty2D.vtkProperty2D_GetDisplayLocation_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProperty2D_GetDisplayLocationMaxValue_06(HandleRef pThis);

		public virtual int GetDisplayLocationMaxValue()
		{
			return vtkProperty2D.vtkProperty2D_GetDisplayLocationMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProperty2D_GetDisplayLocationMinValue_07(HandleRef pThis);

		public virtual int GetDisplayLocationMinValue()
		{
			return vtkProperty2D.vtkProperty2D_GetDisplayLocationMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProperty2D_GetLineStipplePattern_08(HandleRef pThis);

		public virtual int GetLineStipplePattern()
		{
			return vtkProperty2D.vtkProperty2D_GetLineStipplePattern_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProperty2D_GetLineStippleRepeatFactor_09(HandleRef pThis);

		public virtual int GetLineStippleRepeatFactor()
		{
			return vtkProperty2D.vtkProperty2D_GetLineStippleRepeatFactor_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProperty2D_GetLineStippleRepeatFactorMaxValue_10(HandleRef pThis);

		public virtual int GetLineStippleRepeatFactorMaxValue()
		{
			return vtkProperty2D.vtkProperty2D_GetLineStippleRepeatFactorMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProperty2D_GetLineStippleRepeatFactorMinValue_11(HandleRef pThis);

		public virtual int GetLineStippleRepeatFactorMinValue()
		{
			return vtkProperty2D.vtkProperty2D_GetLineStippleRepeatFactorMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkProperty2D_GetLineWidth_12(HandleRef pThis);

		public virtual float GetLineWidth()
		{
			return vtkProperty2D.vtkProperty2D_GetLineWidth_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkProperty2D_GetLineWidthMaxValue_13(HandleRef pThis);

		public virtual float GetLineWidthMaxValue()
		{
			return vtkProperty2D.vtkProperty2D_GetLineWidthMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkProperty2D_GetLineWidthMinValue_14(HandleRef pThis);

		public virtual float GetLineWidthMinValue()
		{
			return vtkProperty2D.vtkProperty2D_GetLineWidthMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkProperty2D_GetOpacity_15(HandleRef pThis);

		public virtual double GetOpacity()
		{
			return vtkProperty2D.vtkProperty2D_GetOpacity_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkProperty2D_GetPointSize_16(HandleRef pThis);

		public virtual float GetPointSize()
		{
			return vtkProperty2D.vtkProperty2D_GetPointSize_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkProperty2D_GetPointSizeMaxValue_17(HandleRef pThis);

		public virtual float GetPointSizeMaxValue()
		{
			return vtkProperty2D.vtkProperty2D_GetPointSizeMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkProperty2D_GetPointSizeMinValue_18(HandleRef pThis);

		public virtual float GetPointSizeMinValue()
		{
			return vtkProperty2D.vtkProperty2D_GetPointSizeMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProperty2D_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProperty2D.vtkProperty2D_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkProperty2D_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProperty2D.vtkProperty2D_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty2D_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProperty2D NewInstance()
		{
			vtkProperty2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProperty2D.vtkProperty2D_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProperty2D_Render_23(HandleRef pThis, HandleRef arg0);

		public virtual void Render(vtkViewport arg0)
		{
			vtkProperty2D.vtkProperty2D_Render_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty2D_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProperty2D SafeDownCast(vtkObjectBase o)
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProperty2D.vtkProperty2D_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProperty2D_SetColor_25(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetColor(double _arg1, double _arg2, double _arg3)
		{
			vtkProperty2D.vtkProperty2D_SetColor_25(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProperty2D_SetColor_26(HandleRef pThis, IntPtr _arg);

		public virtual void SetColor(IntPtr _arg)
		{
			vtkProperty2D.vtkProperty2D_SetColor_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProperty2D_SetDisplayLocation_27(HandleRef pThis, int _arg);

		public virtual void SetDisplayLocation(int _arg)
		{
			vtkProperty2D.vtkProperty2D_SetDisplayLocation_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProperty2D_SetDisplayLocationToBackground_28(HandleRef pThis);

		public void SetDisplayLocationToBackground()
		{
			vtkProperty2D.vtkProperty2D_SetDisplayLocationToBackground_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProperty2D_SetDisplayLocationToForeground_29(HandleRef pThis);

		public void SetDisplayLocationToForeground()
		{
			vtkProperty2D.vtkProperty2D_SetDisplayLocationToForeground_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProperty2D_SetLineStipplePattern_30(HandleRef pThis, int _arg);

		public virtual void SetLineStipplePattern(int _arg)
		{
			vtkProperty2D.vtkProperty2D_SetLineStipplePattern_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProperty2D_SetLineStippleRepeatFactor_31(HandleRef pThis, int _arg);

		public virtual void SetLineStippleRepeatFactor(int _arg)
		{
			vtkProperty2D.vtkProperty2D_SetLineStippleRepeatFactor_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProperty2D_SetLineWidth_32(HandleRef pThis, float _arg);

		public virtual void SetLineWidth(float _arg)
		{
			vtkProperty2D.vtkProperty2D_SetLineWidth_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProperty2D_SetOpacity_33(HandleRef pThis, double _arg);

		public virtual void SetOpacity(double _arg)
		{
			vtkProperty2D.vtkProperty2D_SetOpacity_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkProperty2D_SetPointSize_34(HandleRef pThis, float _arg);

		public virtual void SetPointSize(float _arg)
		{
			vtkProperty2D.vtkProperty2D_SetPointSize_34(base.GetCppThis(), _arg);
		}
	}
}

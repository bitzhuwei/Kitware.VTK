using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageGaussianSmooth : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageGaussianSmooth";

		public new static readonly string MRClassNameKey;

		static vtkImageGaussianSmooth()
		{
			vtkImageGaussianSmooth.MRClassNameKey = "class vtkImageGaussianSmooth";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageGaussianSmooth.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageGaussianSmooth"));
		}

		public vtkImageGaussianSmooth(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGaussianSmooth_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageGaussianSmooth New()
		{
			vtkImageGaussianSmooth result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageGaussianSmooth.vtkImageGaussianSmooth_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGaussianSmooth)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageGaussianSmooth() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageGaussianSmooth.vtkImageGaussianSmooth_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGaussianSmooth_GetDimensionality_01(HandleRef pThis);

		public virtual int GetDimensionality()
		{
			return vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetDimensionality_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGaussianSmooth_GetRadiusFactors_02(HandleRef pThis);

		public virtual double[] GetRadiusFactors()
		{
			IntPtr intPtr = vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetRadiusFactors_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSmooth_GetRadiusFactors_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetRadiusFactors(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetRadiusFactors_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSmooth_GetRadiusFactors_04(HandleRef pThis, IntPtr _arg);

		public virtual void GetRadiusFactors(IntPtr _arg)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetRadiusFactors_04(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGaussianSmooth_GetStandardDeviations_05(HandleRef pThis);

		public virtual double[] GetStandardDeviations()
		{
			IntPtr intPtr = vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetStandardDeviations_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSmooth_GetStandardDeviations_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetStandardDeviations(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetStandardDeviations_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSmooth_GetStandardDeviations_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetStandardDeviations(IntPtr _arg)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_GetStandardDeviations_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGaussianSmooth_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageGaussianSmooth.vtkImageGaussianSmooth_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGaussianSmooth_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageGaussianSmooth.vtkImageGaussianSmooth_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGaussianSmooth_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageGaussianSmooth NewInstance()
		{
			vtkImageGaussianSmooth result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageGaussianSmooth.vtkImageGaussianSmooth_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGaussianSmooth)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGaussianSmooth_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageGaussianSmooth SafeDownCast(vtkObjectBase o)
		{
			vtkImageGaussianSmooth vtkImageGaussianSmooth = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageGaussianSmooth.vtkImageGaussianSmooth_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageGaussianSmooth = (vtkImageGaussianSmooth)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageGaussianSmooth.Register(null);
				}
			}
			return vtkImageGaussianSmooth;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSmooth_SetDimensionality_13(HandleRef pThis, int _arg);

		public virtual void SetDimensionality(int _arg)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetDimensionality_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSmooth_SetRadiusFactor_14(HandleRef pThis, double f);

		public void SetRadiusFactor(double f)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetRadiusFactor_14(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSmooth_SetRadiusFactors_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetRadiusFactors(double _arg1, double _arg2, double _arg3)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetRadiusFactors_15(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSmooth_SetRadiusFactors_16(HandleRef pThis, IntPtr _arg);

		public virtual void SetRadiusFactors(IntPtr _arg)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetRadiusFactors_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSmooth_SetRadiusFactors_17(HandleRef pThis, double f, double f2);

		public void SetRadiusFactors(double f, double f2)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetRadiusFactors_17(base.GetCppThis(), f, f2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSmooth_SetStandardDeviation_18(HandleRef pThis, double std);

		public void SetStandardDeviation(double std)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetStandardDeviation_18(base.GetCppThis(), std);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSmooth_SetStandardDeviation_19(HandleRef pThis, double a, double b);

		public void SetStandardDeviation(double a, double b)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetStandardDeviation_19(base.GetCppThis(), a, b);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSmooth_SetStandardDeviation_20(HandleRef pThis, double a, double b, double c);

		public void SetStandardDeviation(double a, double b, double c)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetStandardDeviation_20(base.GetCppThis(), a, b, c);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSmooth_SetStandardDeviations_21(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetStandardDeviations(double _arg1, double _arg2, double _arg3)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetStandardDeviations_21(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSmooth_SetStandardDeviations_22(HandleRef pThis, IntPtr _arg);

		public virtual void SetStandardDeviations(IntPtr _arg)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetStandardDeviations_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSmooth_SetStandardDeviations_23(HandleRef pThis, double a, double b);

		public void SetStandardDeviations(double a, double b)
		{
			vtkImageGaussianSmooth.vtkImageGaussianSmooth_SetStandardDeviations_23(base.GetCppThis(), a, b);
		}
	}
}

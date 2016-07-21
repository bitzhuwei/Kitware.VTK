using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageGaussianSource : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageGaussianSource";

		public new static readonly string MRClassNameKey;

		static vtkImageGaussianSource()
		{
			vtkImageGaussianSource.MRClassNameKey = "class vtkImageGaussianSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageGaussianSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageGaussianSource"));
		}

		public vtkImageGaussianSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGaussianSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageGaussianSource New()
		{
			vtkImageGaussianSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageGaussianSource.vtkImageGaussianSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGaussianSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageGaussianSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageGaussianSource.vtkImageGaussianSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGaussianSource_GetCenter_01(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkImageGaussianSource.vtkImageGaussianSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSource_GetCenter_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageGaussianSource.vtkImageGaussianSource_GetCenter_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSource_GetCenter_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetCenter(IntPtr _arg)
		{
			vtkImageGaussianSource.vtkImageGaussianSource_GetCenter_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageGaussianSource_GetMaximum_04(HandleRef pThis);

		public virtual double GetMaximum()
		{
			return vtkImageGaussianSource.vtkImageGaussianSource_GetMaximum_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageGaussianSource_GetStandardDeviation_05(HandleRef pThis);

		public virtual double GetStandardDeviation()
		{
			return vtkImageGaussianSource.vtkImageGaussianSource_GetStandardDeviation_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGaussianSource_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageGaussianSource.vtkImageGaussianSource_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGaussianSource_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageGaussianSource.vtkImageGaussianSource_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGaussianSource_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageGaussianSource NewInstance()
		{
			vtkImageGaussianSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageGaussianSource.vtkImageGaussianSource_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGaussianSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGaussianSource_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageGaussianSource SafeDownCast(vtkObjectBase o)
		{
			vtkImageGaussianSource vtkImageGaussianSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageGaussianSource.vtkImageGaussianSource_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageGaussianSource = (vtkImageGaussianSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageGaussianSource.Register(null);
				}
			}
			return vtkImageGaussianSource;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSource_SetCenter_11(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkImageGaussianSource.vtkImageGaussianSource_SetCenter_11(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSource_SetCenter_12(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkImageGaussianSource.vtkImageGaussianSource_SetCenter_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSource_SetMaximum_13(HandleRef pThis, double _arg);

		public virtual void SetMaximum(double _arg)
		{
			vtkImageGaussianSource.vtkImageGaussianSource_SetMaximum_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSource_SetStandardDeviation_14(HandleRef pThis, double _arg);

		public virtual void SetStandardDeviation(double _arg)
		{
			vtkImageGaussianSource.vtkImageGaussianSource_SetStandardDeviation_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGaussianSource_SetWholeExtent_15(HandleRef pThis, int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax);

		public void SetWholeExtent(int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax)
		{
			vtkImageGaussianSource.vtkImageGaussianSource_SetWholeExtent_15(base.GetCppThis(), xMinx, xMax, yMin, yMax, zMin, zMax);
		}
	}
}

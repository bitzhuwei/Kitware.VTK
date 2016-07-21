using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageSinusoidSource : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSinusoidSource";

		public new static readonly string MRClassNameKey;

		static vtkImageSinusoidSource()
		{
			vtkImageSinusoidSource.MRClassNameKey = "class vtkImageSinusoidSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSinusoidSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSinusoidSource"));
		}

		public vtkImageSinusoidSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSinusoidSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageSinusoidSource New()
		{
			vtkImageSinusoidSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSinusoidSource.vtkImageSinusoidSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSinusoidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageSinusoidSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageSinusoidSource.vtkImageSinusoidSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageSinusoidSource_GetAmplitude_01(HandleRef pThis);

		public virtual double GetAmplitude()
		{
			return vtkImageSinusoidSource.vtkImageSinusoidSource_GetAmplitude_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSinusoidSource_GetDirection_02(HandleRef pThis);

		public virtual double[] GetDirection()
		{
			IntPtr intPtr = vtkImageSinusoidSource.vtkImageSinusoidSource_GetDirection_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSinusoidSource_GetDirection_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDirection(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_GetDirection_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSinusoidSource_GetDirection_04(HandleRef pThis, IntPtr _arg);

		public virtual void GetDirection(IntPtr _arg)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_GetDirection_04(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageSinusoidSource_GetPeriod_05(HandleRef pThis);

		public virtual double GetPeriod()
		{
			return vtkImageSinusoidSource.vtkImageSinusoidSource_GetPeriod_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageSinusoidSource_GetPhase_06(HandleRef pThis);

		public virtual double GetPhase()
		{
			return vtkImageSinusoidSource.vtkImageSinusoidSource_GetPhase_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSinusoidSource_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageSinusoidSource.vtkImageSinusoidSource_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSinusoidSource_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageSinusoidSource.vtkImageSinusoidSource_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSinusoidSource_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageSinusoidSource NewInstance()
		{
			vtkImageSinusoidSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSinusoidSource.vtkImageSinusoidSource_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSinusoidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSinusoidSource_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageSinusoidSource SafeDownCast(vtkObjectBase o)
		{
			vtkImageSinusoidSource vtkImageSinusoidSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSinusoidSource.vtkImageSinusoidSource_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSinusoidSource = (vtkImageSinusoidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSinusoidSource.Register(null);
				}
			}
			return vtkImageSinusoidSource;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSinusoidSource_SetAmplitude_12(HandleRef pThis, double _arg);

		public virtual void SetAmplitude(double _arg)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_SetAmplitude_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSinusoidSource_SetDirection_13(HandleRef pThis, double arg0, double arg1, double arg2);

		public void SetDirection(double arg0, double arg1, double arg2)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_SetDirection_13(base.GetCppThis(), arg0, arg1, arg2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSinusoidSource_SetDirection_14(HandleRef pThis, IntPtr dir);

		public void SetDirection(IntPtr dir)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_SetDirection_14(base.GetCppThis(), dir);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSinusoidSource_SetPeriod_15(HandleRef pThis, double _arg);

		public virtual void SetPeriod(double _arg)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_SetPeriod_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSinusoidSource_SetPhase_16(HandleRef pThis, double _arg);

		public virtual void SetPhase(double _arg)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_SetPhase_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSinusoidSource_SetWholeExtent_17(HandleRef pThis, int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax);

		public void SetWholeExtent(int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax)
		{
			vtkImageSinusoidSource.vtkImageSinusoidSource_SetWholeExtent_17(base.GetCppThis(), xMinx, xMax, yMin, yMax, zMin, zMax);
		}
	}
}

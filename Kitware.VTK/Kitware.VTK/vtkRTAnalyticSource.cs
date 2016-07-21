using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRTAnalyticSource : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRTAnalyticSource";

		public new static readonly string MRClassNameKey;

		static vtkRTAnalyticSource()
		{
			vtkRTAnalyticSource.MRClassNameKey = "class vtkRTAnalyticSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRTAnalyticSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRTAnalyticSource"));
		}

		public vtkRTAnalyticSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkRTAnalyticSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRTAnalyticSource New()
		{
			vtkRTAnalyticSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRTAnalyticSource.vtkRTAnalyticSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRTAnalyticSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRTAnalyticSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRTAnalyticSource.vtkRTAnalyticSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkRTAnalyticSource_GetCenter_01(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkRTAnalyticSource.vtkRTAnalyticSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_GetCenter_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_GetCenter_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_GetCenter_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetCenter(IntPtr _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_GetCenter_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkRTAnalyticSource_GetMaximum_04(HandleRef pThis);

		public virtual double GetMaximum()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetMaximum_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkRTAnalyticSource_GetStandardDeviation_05(HandleRef pThis);

		public virtual double GetStandardDeviation()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetStandardDeviation_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkRTAnalyticSource_GetSubsampleRate_06(HandleRef pThis);

		public virtual int GetSubsampleRate()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetSubsampleRate_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkRTAnalyticSource_GetWholeExtent_07(HandleRef pThis);

		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkRTAnalyticSource.vtkRTAnalyticSource_GetWholeExtent_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_GetWholeExtent_08(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_GetWholeExtent_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_GetWholeExtent_09(HandleRef pThis, IntPtr _arg);

		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_GetWholeExtent_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkRTAnalyticSource_GetXFreq_10(HandleRef pThis);

		public virtual double GetXFreq()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetXFreq_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkRTAnalyticSource_GetXMag_11(HandleRef pThis);

		public virtual double GetXMag()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetXMag_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkRTAnalyticSource_GetYFreq_12(HandleRef pThis);

		public virtual double GetYFreq()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetYFreq_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkRTAnalyticSource_GetYMag_13(HandleRef pThis);

		public virtual double GetYMag()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetYMag_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkRTAnalyticSource_GetZFreq_14(HandleRef pThis);

		public virtual double GetZFreq()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetZFreq_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkRTAnalyticSource_GetZMag_15(HandleRef pThis);

		public virtual double GetZMag()
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_GetZMag_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkRTAnalyticSource_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkRTAnalyticSource_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRTAnalyticSource.vtkRTAnalyticSource_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkRTAnalyticSource_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRTAnalyticSource NewInstance()
		{
			vtkRTAnalyticSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRTAnalyticSource.vtkRTAnalyticSource_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRTAnalyticSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkRTAnalyticSource_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRTAnalyticSource SafeDownCast(vtkObjectBase o)
		{
			vtkRTAnalyticSource vtkRTAnalyticSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRTAnalyticSource.vtkRTAnalyticSource_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRTAnalyticSource = (vtkRTAnalyticSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRTAnalyticSource.Register(null);
				}
			}
			return vtkRTAnalyticSource;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_SetCenter_21(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetCenter_21(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_SetCenter_22(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetCenter_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_SetMaximum_23(HandleRef pThis, double _arg);

		public virtual void SetMaximum(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetMaximum_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_SetStandardDeviation_24(HandleRef pThis, double _arg);

		public virtual void SetStandardDeviation(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetStandardDeviation_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_SetSubsampleRate_25(HandleRef pThis, int _arg);

		public virtual void SetSubsampleRate(int _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetSubsampleRate_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_SetWholeExtent_26(HandleRef pThis, int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax);

		public void SetWholeExtent(int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetWholeExtent_26(base.GetCppThis(), xMinx, xMax, yMin, yMax, zMin, zMax);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_SetXFreq_27(HandleRef pThis, double _arg);

		public virtual void SetXFreq(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetXFreq_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_SetXMag_28(HandleRef pThis, double _arg);

		public virtual void SetXMag(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetXMag_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_SetYFreq_29(HandleRef pThis, double _arg);

		public virtual void SetYFreq(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetYFreq_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_SetYMag_30(HandleRef pThis, double _arg);

		public virtual void SetYMag(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetYMag_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_SetZFreq_31(HandleRef pThis, double _arg);

		public virtual void SetZFreq(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetZFreq_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkRTAnalyticSource_SetZMag_32(HandleRef pThis, double _arg);

		public virtual void SetZMag(double _arg)
		{
			vtkRTAnalyticSource.vtkRTAnalyticSource_SetZMag_32(base.GetCppThis(), _arg);
		}
	}
}

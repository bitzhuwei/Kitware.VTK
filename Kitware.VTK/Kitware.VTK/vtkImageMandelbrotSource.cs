using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageMandelbrotSource : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMandelbrotSource";

		public new static readonly string MRClassNameKey;

		static vtkImageMandelbrotSource()
		{
			vtkImageMandelbrotSource.MRClassNameKey = "class vtkImageMandelbrotSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMandelbrotSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMandelbrotSource"));
		}

		public vtkImageMandelbrotSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMandelbrotSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMandelbrotSource New()
		{
			vtkImageMandelbrotSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMandelbrotSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageMandelbrotSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageMandelbrotSource.vtkImageMandelbrotSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_ConstantSizeOff_01(HandleRef pThis);

		public virtual void ConstantSizeOff()
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_ConstantSizeOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_ConstantSizeOn_02(HandleRef pThis);

		public virtual void ConstantSizeOn()
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_ConstantSizeOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_CopyOriginAndSample_03(HandleRef pThis, HandleRef source);

		public void CopyOriginAndSample(vtkImageMandelbrotSource source)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_CopyOriginAndSample_03(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMandelbrotSource_GetConstantSize_04(HandleRef pThis);

		public virtual int GetConstantSize()
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetConstantSize_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern ushort vtkImageMandelbrotSource_GetMaximumNumberOfIterations_05(HandleRef pThis);

		public virtual ushort GetMaximumNumberOfIterations()
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetMaximumNumberOfIterations_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern ushort vtkImageMandelbrotSource_GetMaximumNumberOfIterationsMaxValue_06(HandleRef pThis);

		public virtual ushort GetMaximumNumberOfIterationsMaxValue()
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetMaximumNumberOfIterationsMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern ushort vtkImageMandelbrotSource_GetMaximumNumberOfIterationsMinValue_07(HandleRef pThis);

		public virtual ushort GetMaximumNumberOfIterationsMinValue()
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetMaximumNumberOfIterationsMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMandelbrotSource_GetOriginCX_08(HandleRef pThis);

		public virtual double[] GetOriginCX()
		{
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetOriginCX_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_GetOriginCX_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		public virtual void GetOriginCX(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetOriginCX_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_GetOriginCX_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetOriginCX(IntPtr _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetOriginCX_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMandelbrotSource_GetProjectionAxes_11(HandleRef pThis);

		public virtual int[] GetProjectionAxes()
		{
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetProjectionAxes_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_GetProjectionAxes_12(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetProjectionAxes(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetProjectionAxes_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_GetProjectionAxes_13(HandleRef pThis, IntPtr _arg);

		public virtual void GetProjectionAxes(IntPtr _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetProjectionAxes_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMandelbrotSource_GetSampleCX_14(HandleRef pThis);

		public virtual double[] GetSampleCX()
		{
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSampleCX_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_GetSampleCX_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		public virtual void GetSampleCX(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSampleCX_15(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_GetSampleCX_16(HandleRef pThis, IntPtr _arg);

		public virtual void GetSampleCX(IntPtr _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSampleCX_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMandelbrotSource_GetSizeCX_17(HandleRef pThis);

		public double[] GetSizeCX()
		{
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSizeCX_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_GetSizeCX_18(HandleRef pThis, IntPtr s);

		public void GetSizeCX(IntPtr s)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSizeCX_18(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMandelbrotSource_GetSubsampleRate_19(HandleRef pThis);

		public virtual int GetSubsampleRate()
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSubsampleRate_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMandelbrotSource_GetSubsampleRateMaxValue_20(HandleRef pThis);

		public virtual int GetSubsampleRateMaxValue()
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSubsampleRateMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMandelbrotSource_GetSubsampleRateMinValue_21(HandleRef pThis);

		public virtual int GetSubsampleRateMinValue()
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetSubsampleRateMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMandelbrotSource_GetWholeExtent_22(HandleRef pThis);

		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetWholeExtent_22(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_GetWholeExtent_23(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetWholeExtent_23(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_GetWholeExtent_24(HandleRef pThis, IntPtr _arg);

		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_GetWholeExtent_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMandelbrotSource_IsA_25(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_IsA_25(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMandelbrotSource_IsTypeOf_26(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageMandelbrotSource.vtkImageMandelbrotSource_IsTypeOf_26(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMandelbrotSource_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageMandelbrotSource NewInstance()
		{
			vtkImageMandelbrotSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_NewInstance_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMandelbrotSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_Pan_29(HandleRef pThis, double x, double y, double z);

		public void Pan(double x, double y, double z)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_Pan_29(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMandelbrotSource_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMandelbrotSource SafeDownCast(vtkObjectBase o)
		{
			vtkImageMandelbrotSource vtkImageMandelbrotSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMandelbrotSource.vtkImageMandelbrotSource_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMandelbrotSource = (vtkImageMandelbrotSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMandelbrotSource.Register(null);
				}
			}
			return vtkImageMandelbrotSource;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_SetConstantSize_31(HandleRef pThis, int _arg);

		public virtual void SetConstantSize(int _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetConstantSize_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_SetMaximumNumberOfIterations_32(HandleRef pThis, ushort _arg);

		public virtual void SetMaximumNumberOfIterations(ushort _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetMaximumNumberOfIterations_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_SetOriginCX_33(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetOriginCX(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetOriginCX_33(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_SetOriginCX_34(HandleRef pThis, IntPtr _arg);

		public virtual void SetOriginCX(IntPtr _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetOriginCX_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_SetProjectionAxes_35(HandleRef pThis, int x, int y, int z);

		public void SetProjectionAxes(int x, int y, int z)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetProjectionAxes_35(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_SetProjectionAxes_36(HandleRef pThis, IntPtr a);

		public void SetProjectionAxes(IntPtr a)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetProjectionAxes_36(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_SetSampleCX_37(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetSampleCX(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetSampleCX_37(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_SetSampleCX_38(HandleRef pThis, IntPtr _arg);

		public virtual void SetSampleCX(IntPtr _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetSampleCX_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_SetSizeCX_39(HandleRef pThis, double cReal, double cImag, double xReal, double xImag);

		public void SetSizeCX(double cReal, double cImag, double xReal, double xImag)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetSizeCX_39(base.GetCppThis(), cReal, cImag, xReal, xImag);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_SetSubsampleRate_40(HandleRef pThis, int _arg);

		public virtual void SetSubsampleRate(int _arg)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetSubsampleRate_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_SetWholeExtent_41(HandleRef pThis, IntPtr extent);

		public void SetWholeExtent(IntPtr extent)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetWholeExtent_41(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_SetWholeExtent_42(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		public void SetWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_SetWholeExtent_42(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMandelbrotSource_Zoom_43(HandleRef pThis, double factor);

		public void Zoom(double factor)
		{
			vtkImageMandelbrotSource.vtkImageMandelbrotSource_Zoom_43(base.GetCppThis(), factor);
		}
	}
}

using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageIdealLowPass : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageIdealLowPass";

		public new static readonly string MRClassNameKey;

		static vtkImageIdealLowPass()
		{
			vtkImageIdealLowPass.MRClassNameKey = "class vtkImageIdealLowPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageIdealLowPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageIdealLowPass"));
		}

		public vtkImageIdealLowPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageIdealLowPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageIdealLowPass New()
		{
			vtkImageIdealLowPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageIdealLowPass.vtkImageIdealLowPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageIdealLowPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageIdealLowPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageIdealLowPass.vtkImageIdealLowPass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageIdealLowPass_GetCutOff_01(HandleRef pThis);

		public virtual double[] GetCutOff()
		{
			IntPtr intPtr = vtkImageIdealLowPass.vtkImageIdealLowPass_GetCutOff_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealLowPass_GetCutOff_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCutOff(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_GetCutOff_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealLowPass_GetCutOff_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetCutOff(IntPtr _arg)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_GetCutOff_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageIdealLowPass_GetXCutOff_04(HandleRef pThis);

		public double GetXCutOff()
		{
			return vtkImageIdealLowPass.vtkImageIdealLowPass_GetXCutOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageIdealLowPass_GetYCutOff_05(HandleRef pThis);

		public double GetYCutOff()
		{
			return vtkImageIdealLowPass.vtkImageIdealLowPass_GetYCutOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageIdealLowPass_GetZCutOff_06(HandleRef pThis);

		public double GetZCutOff()
		{
			return vtkImageIdealLowPass.vtkImageIdealLowPass_GetZCutOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageIdealLowPass_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageIdealLowPass.vtkImageIdealLowPass_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageIdealLowPass_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageIdealLowPass.vtkImageIdealLowPass_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageIdealLowPass_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageIdealLowPass NewInstance()
		{
			vtkImageIdealLowPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageIdealLowPass.vtkImageIdealLowPass_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageIdealLowPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageIdealLowPass_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageIdealLowPass SafeDownCast(vtkObjectBase o)
		{
			vtkImageIdealLowPass vtkImageIdealLowPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageIdealLowPass.vtkImageIdealLowPass_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageIdealLowPass = (vtkImageIdealLowPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageIdealLowPass.Register(null);
				}
			}
			return vtkImageIdealLowPass;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealLowPass_SetCutOff_12(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCutOff(double _arg1, double _arg2, double _arg3)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_SetCutOff_12(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealLowPass_SetCutOff_13(HandleRef pThis, IntPtr _arg);

		public virtual void SetCutOff(IntPtr _arg)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_SetCutOff_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealLowPass_SetCutOff_14(HandleRef pThis, double v);

		public void SetCutOff(double v)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_SetCutOff_14(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealLowPass_SetXCutOff_15(HandleRef pThis, double v);

		public void SetXCutOff(double v)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_SetXCutOff_15(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealLowPass_SetYCutOff_16(HandleRef pThis, double v);

		public void SetYCutOff(double v)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_SetYCutOff_16(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealLowPass_SetZCutOff_17(HandleRef pThis, double v);

		public void SetZCutOff(double v)
		{
			vtkImageIdealLowPass.vtkImageIdealLowPass_SetZCutOff_17(base.GetCppThis(), v);
		}
	}
}

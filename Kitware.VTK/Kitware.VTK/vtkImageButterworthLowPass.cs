using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageButterworthLowPass : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageButterworthLowPass";

		public new static readonly string MRClassNameKey;

		static vtkImageButterworthLowPass()
		{
			vtkImageButterworthLowPass.MRClassNameKey = "class vtkImageButterworthLowPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageButterworthLowPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageButterworthLowPass"));
		}

		public vtkImageButterworthLowPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageButterworthLowPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageButterworthLowPass New()
		{
			vtkImageButterworthLowPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageButterworthLowPass.vtkImageButterworthLowPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageButterworthLowPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageButterworthLowPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageButterworthLowPass.vtkImageButterworthLowPass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageButterworthLowPass_GetCutOff_01(HandleRef pThis);

		public virtual double[] GetCutOff()
		{
			IntPtr intPtr = vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetCutOff_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthLowPass_GetCutOff_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCutOff(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetCutOff_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthLowPass_GetCutOff_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetCutOff(IntPtr _arg)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetCutOff_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageButterworthLowPass_GetOrder_04(HandleRef pThis);

		public virtual int GetOrder()
		{
			return vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetOrder_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageButterworthLowPass_GetXCutOff_05(HandleRef pThis);

		public double GetXCutOff()
		{
			return vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetXCutOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageButterworthLowPass_GetYCutOff_06(HandleRef pThis);

		public double GetYCutOff()
		{
			return vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetYCutOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageButterworthLowPass_GetZCutOff_07(HandleRef pThis);

		public double GetZCutOff()
		{
			return vtkImageButterworthLowPass.vtkImageButterworthLowPass_GetZCutOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageButterworthLowPass_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageButterworthLowPass.vtkImageButterworthLowPass_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageButterworthLowPass_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageButterworthLowPass.vtkImageButterworthLowPass_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageButterworthLowPass_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageButterworthLowPass NewInstance()
		{
			vtkImageButterworthLowPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageButterworthLowPass.vtkImageButterworthLowPass_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageButterworthLowPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageButterworthLowPass_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageButterworthLowPass SafeDownCast(vtkObjectBase o)
		{
			vtkImageButterworthLowPass vtkImageButterworthLowPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageButterworthLowPass.vtkImageButterworthLowPass_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageButterworthLowPass = (vtkImageButterworthLowPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageButterworthLowPass.Register(null);
				}
			}
			return vtkImageButterworthLowPass;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthLowPass_SetCutOff_13(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCutOff(double _arg1, double _arg2, double _arg3)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_SetCutOff_13(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthLowPass_SetCutOff_14(HandleRef pThis, IntPtr _arg);

		public virtual void SetCutOff(IntPtr _arg)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_SetCutOff_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthLowPass_SetCutOff_15(HandleRef pThis, double v);

		public void SetCutOff(double v)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_SetCutOff_15(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthLowPass_SetOrder_16(HandleRef pThis, int _arg);

		public virtual void SetOrder(int _arg)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_SetOrder_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthLowPass_SetXCutOff_17(HandleRef pThis, double v);

		public void SetXCutOff(double v)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_SetXCutOff_17(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthLowPass_SetYCutOff_18(HandleRef pThis, double v);

		public void SetYCutOff(double v)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_SetYCutOff_18(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthLowPass_SetZCutOff_19(HandleRef pThis, double v);

		public void SetZCutOff(double v)
		{
			vtkImageButterworthLowPass.vtkImageButterworthLowPass_SetZCutOff_19(base.GetCppThis(), v);
		}
	}
}

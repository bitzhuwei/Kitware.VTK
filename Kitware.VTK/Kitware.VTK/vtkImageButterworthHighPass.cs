using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageButterworthHighPass : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageButterworthHighPass";

		public new static readonly string MRClassNameKey;

		static vtkImageButterworthHighPass()
		{
			vtkImageButterworthHighPass.MRClassNameKey = "class vtkImageButterworthHighPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageButterworthHighPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageButterworthHighPass"));
		}

		public vtkImageButterworthHighPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageButterworthHighPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageButterworthHighPass New()
		{
			vtkImageButterworthHighPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageButterworthHighPass.vtkImageButterworthHighPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageButterworthHighPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageButterworthHighPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageButterworthHighPass.vtkImageButterworthHighPass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageButterworthHighPass_GetCutOff_01(HandleRef pThis);

		public virtual double[] GetCutOff()
		{
			IntPtr intPtr = vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetCutOff_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthHighPass_GetCutOff_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCutOff(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetCutOff_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthHighPass_GetCutOff_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetCutOff(IntPtr _arg)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetCutOff_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageButterworthHighPass_GetOrder_04(HandleRef pThis);

		public virtual int GetOrder()
		{
			return vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetOrder_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageButterworthHighPass_GetXCutOff_05(HandleRef pThis);

		public double GetXCutOff()
		{
			return vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetXCutOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageButterworthHighPass_GetYCutOff_06(HandleRef pThis);

		public double GetYCutOff()
		{
			return vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetYCutOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageButterworthHighPass_GetZCutOff_07(HandleRef pThis);

		public double GetZCutOff()
		{
			return vtkImageButterworthHighPass.vtkImageButterworthHighPass_GetZCutOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageButterworthHighPass_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageButterworthHighPass.vtkImageButterworthHighPass_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageButterworthHighPass_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageButterworthHighPass.vtkImageButterworthHighPass_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageButterworthHighPass_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageButterworthHighPass NewInstance()
		{
			vtkImageButterworthHighPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageButterworthHighPass.vtkImageButterworthHighPass_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageButterworthHighPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageButterworthHighPass_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageButterworthHighPass SafeDownCast(vtkObjectBase o)
		{
			vtkImageButterworthHighPass vtkImageButterworthHighPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageButterworthHighPass.vtkImageButterworthHighPass_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageButterworthHighPass = (vtkImageButterworthHighPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageButterworthHighPass.Register(null);
				}
			}
			return vtkImageButterworthHighPass;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthHighPass_SetCutOff_13(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCutOff(double _arg1, double _arg2, double _arg3)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_SetCutOff_13(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthHighPass_SetCutOff_14(HandleRef pThis, IntPtr _arg);

		public virtual void SetCutOff(IntPtr _arg)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_SetCutOff_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthHighPass_SetCutOff_15(HandleRef pThis, double v);

		public void SetCutOff(double v)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_SetCutOff_15(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthHighPass_SetOrder_16(HandleRef pThis, int _arg);

		public virtual void SetOrder(int _arg)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_SetOrder_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthHighPass_SetXCutOff_17(HandleRef pThis, double v);

		public void SetXCutOff(double v)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_SetXCutOff_17(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthHighPass_SetYCutOff_18(HandleRef pThis, double v);

		public void SetYCutOff(double v)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_SetYCutOff_18(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageButterworthHighPass_SetZCutOff_19(HandleRef pThis, double v);

		public void SetZCutOff(double v)
		{
			vtkImageButterworthHighPass.vtkImageButterworthHighPass_SetZCutOff_19(base.GetCppThis(), v);
		}
	}
}

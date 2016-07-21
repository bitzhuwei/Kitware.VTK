using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageIdealHighPass : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageIdealHighPass";

		public new static readonly string MRClassNameKey;

		static vtkImageIdealHighPass()
		{
			vtkImageIdealHighPass.MRClassNameKey = "class vtkImageIdealHighPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageIdealHighPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageIdealHighPass"));
		}

		public vtkImageIdealHighPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageIdealHighPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageIdealHighPass New()
		{
			vtkImageIdealHighPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageIdealHighPass.vtkImageIdealHighPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageIdealHighPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageIdealHighPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageIdealHighPass.vtkImageIdealHighPass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageIdealHighPass_GetCutOff_01(HandleRef pThis);

		public virtual double[] GetCutOff()
		{
			IntPtr intPtr = vtkImageIdealHighPass.vtkImageIdealHighPass_GetCutOff_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealHighPass_GetCutOff_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCutOff(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_GetCutOff_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealHighPass_GetCutOff_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetCutOff(IntPtr _arg)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_GetCutOff_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageIdealHighPass_GetXCutOff_04(HandleRef pThis);

		public double GetXCutOff()
		{
			return vtkImageIdealHighPass.vtkImageIdealHighPass_GetXCutOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageIdealHighPass_GetYCutOff_05(HandleRef pThis);

		public double GetYCutOff()
		{
			return vtkImageIdealHighPass.vtkImageIdealHighPass_GetYCutOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageIdealHighPass_GetZCutOff_06(HandleRef pThis);

		public double GetZCutOff()
		{
			return vtkImageIdealHighPass.vtkImageIdealHighPass_GetZCutOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageIdealHighPass_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageIdealHighPass.vtkImageIdealHighPass_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageIdealHighPass_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageIdealHighPass.vtkImageIdealHighPass_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageIdealHighPass_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageIdealHighPass NewInstance()
		{
			vtkImageIdealHighPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageIdealHighPass.vtkImageIdealHighPass_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageIdealHighPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageIdealHighPass_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageIdealHighPass SafeDownCast(vtkObjectBase o)
		{
			vtkImageIdealHighPass vtkImageIdealHighPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageIdealHighPass.vtkImageIdealHighPass_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageIdealHighPass = (vtkImageIdealHighPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageIdealHighPass.Register(null);
				}
			}
			return vtkImageIdealHighPass;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealHighPass_SetCutOff_12(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCutOff(double _arg1, double _arg2, double _arg3)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_SetCutOff_12(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealHighPass_SetCutOff_13(HandleRef pThis, IntPtr _arg);

		public virtual void SetCutOff(IntPtr _arg)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_SetCutOff_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealHighPass_SetCutOff_14(HandleRef pThis, double v);

		public void SetCutOff(double v)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_SetCutOff_14(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealHighPass_SetXCutOff_15(HandleRef pThis, double v);

		public void SetXCutOff(double v)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_SetXCutOff_15(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealHighPass_SetYCutOff_16(HandleRef pThis, double v);

		public void SetYCutOff(double v)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_SetYCutOff_16(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageIdealHighPass_SetZCutOff_17(HandleRef pThis, double v);

		public void SetZCutOff(double v)
		{
			vtkImageIdealHighPass.vtkImageIdealHighPass_SetZCutOff_17(base.GetCppThis(), v);
		}
	}
}

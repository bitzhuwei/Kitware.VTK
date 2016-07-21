using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageSeparableConvolution : vtkImageDecomposeFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSeparableConvolution";

		public new static readonly string MRClassNameKey;

		static vtkImageSeparableConvolution()
		{
			vtkImageSeparableConvolution.MRClassNameKey = "class vtkImageSeparableConvolution";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSeparableConvolution.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSeparableConvolution"));
		}

		public vtkImageSeparableConvolution(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSeparableConvolution_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageSeparableConvolution New()
		{
			vtkImageSeparableConvolution result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSeparableConvolution.vtkImageSeparableConvolution_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSeparableConvolution)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageSeparableConvolution() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageSeparableConvolution.vtkImageSeparableConvolution_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern uint vtkImageSeparableConvolution_GetMTime_01(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkImageSeparableConvolution.vtkImageSeparableConvolution_GetMTime_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSeparableConvolution_GetXKernel_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFloatArray GetXKernel()
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSeparableConvolution.vtkImageSeparableConvolution_GetXKernel_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSeparableConvolution_GetYKernel_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFloatArray GetYKernel()
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSeparableConvolution.vtkImageSeparableConvolution_GetYKernel_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSeparableConvolution_GetZKernel_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFloatArray GetZKernel()
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSeparableConvolution.vtkImageSeparableConvolution_GetZKernel_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSeparableConvolution_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageSeparableConvolution.vtkImageSeparableConvolution_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSeparableConvolution_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageSeparableConvolution.vtkImageSeparableConvolution_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSeparableConvolution_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageSeparableConvolution NewInstance()
		{
			vtkImageSeparableConvolution result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSeparableConvolution.vtkImageSeparableConvolution_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSeparableConvolution)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSeparableConvolution_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageSeparableConvolution SafeDownCast(vtkObjectBase o)
		{
			vtkImageSeparableConvolution vtkImageSeparableConvolution = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSeparableConvolution.vtkImageSeparableConvolution_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSeparableConvolution = (vtkImageSeparableConvolution)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSeparableConvolution.Register(null);
				}
			}
			return vtkImageSeparableConvolution;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSeparableConvolution_SetXKernel_10(HandleRef pThis, HandleRef arg0);

		public virtual void SetXKernel(vtkFloatArray arg0)
		{
			vtkImageSeparableConvolution.vtkImageSeparableConvolution_SetXKernel_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSeparableConvolution_SetYKernel_11(HandleRef pThis, HandleRef arg0);

		public virtual void SetYKernel(vtkFloatArray arg0)
		{
			vtkImageSeparableConvolution.vtkImageSeparableConvolution_SetYKernel_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSeparableConvolution_SetZKernel_12(HandleRef pThis, HandleRef arg0);

		public virtual void SetZKernel(vtkFloatArray arg0)
		{
			vtkImageSeparableConvolution.vtkImageSeparableConvolution_SetZKernel_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}

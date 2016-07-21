using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageMagnify : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMagnify";

		public new static readonly string MRClassNameKey;

		static vtkImageMagnify()
		{
			vtkImageMagnify.MRClassNameKey = "class vtkImageMagnify";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMagnify.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMagnify"));
		}

		public vtkImageMagnify(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMagnify_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMagnify New()
		{
			vtkImageMagnify result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMagnify.vtkImageMagnify_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMagnify)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageMagnify() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageMagnify.vtkImageMagnify_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMagnify_GetInterpolate_01(HandleRef pThis);

		public virtual int GetInterpolate()
		{
			return vtkImageMagnify.vtkImageMagnify_GetInterpolate_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMagnify_GetMagnificationFactors_02(HandleRef pThis);

		public virtual int[] GetMagnificationFactors()
		{
			IntPtr intPtr = vtkImageMagnify.vtkImageMagnify_GetMagnificationFactors_02(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMagnify_GetMagnificationFactors_03(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetMagnificationFactors(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageMagnify.vtkImageMagnify_GetMagnificationFactors_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMagnify_GetMagnificationFactors_04(HandleRef pThis, IntPtr _arg);

		public virtual void GetMagnificationFactors(IntPtr _arg)
		{
			vtkImageMagnify.vtkImageMagnify_GetMagnificationFactors_04(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMagnify_InterpolateOff_05(HandleRef pThis);

		public virtual void InterpolateOff()
		{
			vtkImageMagnify.vtkImageMagnify_InterpolateOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMagnify_InterpolateOn_06(HandleRef pThis);

		public virtual void InterpolateOn()
		{
			vtkImageMagnify.vtkImageMagnify_InterpolateOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMagnify_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageMagnify.vtkImageMagnify_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMagnify_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageMagnify.vtkImageMagnify_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMagnify_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageMagnify NewInstance()
		{
			vtkImageMagnify result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMagnify.vtkImageMagnify_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMagnify)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMagnify_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMagnify SafeDownCast(vtkObjectBase o)
		{
			vtkImageMagnify vtkImageMagnify = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMagnify.vtkImageMagnify_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMagnify = (vtkImageMagnify)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMagnify.Register(null);
				}
			}
			return vtkImageMagnify;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMagnify_SetInterpolate_12(HandleRef pThis, int _arg);

		public virtual void SetInterpolate(int _arg)
		{
			vtkImageMagnify.vtkImageMagnify_SetInterpolate_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMagnify_SetMagnificationFactors_13(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetMagnificationFactors(int _arg1, int _arg2, int _arg3)
		{
			vtkImageMagnify.vtkImageMagnify_SetMagnificationFactors_13(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMagnify_SetMagnificationFactors_14(HandleRef pThis, IntPtr _arg);

		public virtual void SetMagnificationFactors(IntPtr _arg)
		{
			vtkImageMagnify.vtkImageMagnify_SetMagnificationFactors_14(base.GetCppThis(), _arg);
		}
	}
}

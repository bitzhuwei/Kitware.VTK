using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageLaplacian : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageLaplacian";

		public new static readonly string MRClassNameKey;

		static vtkImageLaplacian()
		{
			vtkImageLaplacian.MRClassNameKey = "class vtkImageLaplacian";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageLaplacian.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageLaplacian"));
		}

		public vtkImageLaplacian(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageLaplacian_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageLaplacian New()
		{
			vtkImageLaplacian result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageLaplacian.vtkImageLaplacian_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageLaplacian)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageLaplacian() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageLaplacian.vtkImageLaplacian_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageLaplacian_GetDimensionality_01(HandleRef pThis);

		public virtual int GetDimensionality()
		{
			return vtkImageLaplacian.vtkImageLaplacian_GetDimensionality_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageLaplacian_GetDimensionalityMaxValue_02(HandleRef pThis);

		public virtual int GetDimensionalityMaxValue()
		{
			return vtkImageLaplacian.vtkImageLaplacian_GetDimensionalityMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageLaplacian_GetDimensionalityMinValue_03(HandleRef pThis);

		public virtual int GetDimensionalityMinValue()
		{
			return vtkImageLaplacian.vtkImageLaplacian_GetDimensionalityMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageLaplacian_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageLaplacian.vtkImageLaplacian_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageLaplacian_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageLaplacian.vtkImageLaplacian_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageLaplacian_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageLaplacian NewInstance()
		{
			vtkImageLaplacian result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageLaplacian.vtkImageLaplacian_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageLaplacian)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageLaplacian_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageLaplacian SafeDownCast(vtkObjectBase o)
		{
			vtkImageLaplacian vtkImageLaplacian = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageLaplacian.vtkImageLaplacian_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageLaplacian = (vtkImageLaplacian)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageLaplacian.Register(null);
				}
			}
			return vtkImageLaplacian;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageLaplacian_SetDimensionality_09(HandleRef pThis, int _arg);

		public virtual void SetDimensionality(int _arg)
		{
			vtkImageLaplacian.vtkImageLaplacian_SetDimensionality_09(base.GetCppThis(), _arg);
		}
	}
}

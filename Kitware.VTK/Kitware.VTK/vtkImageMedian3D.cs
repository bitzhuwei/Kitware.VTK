using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageMedian3D : vtkImageSpatialAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMedian3D";

		public new static readonly string MRClassNameKey;

		static vtkImageMedian3D()
		{
			vtkImageMedian3D.MRClassNameKey = "class vtkImageMedian3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMedian3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMedian3D"));
		}

		public vtkImageMedian3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMedian3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMedian3D New()
		{
			vtkImageMedian3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMedian3D.vtkImageMedian3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMedian3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageMedian3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageMedian3D.vtkImageMedian3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMedian3D_GetNumberOfElements_01(HandleRef pThis);

		public virtual int GetNumberOfElements()
		{
			return vtkImageMedian3D.vtkImageMedian3D_GetNumberOfElements_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMedian3D_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageMedian3D.vtkImageMedian3D_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMedian3D_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageMedian3D.vtkImageMedian3D_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMedian3D_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageMedian3D NewInstance()
		{
			vtkImageMedian3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMedian3D.vtkImageMedian3D_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMedian3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMedian3D_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMedian3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageMedian3D vtkImageMedian3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMedian3D.vtkImageMedian3D_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMedian3D = (vtkImageMedian3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMedian3D.Register(null);
				}
			}
			return vtkImageMedian3D;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMedian3D_SetKernelSize_07(HandleRef pThis, int size0, int size1, int size2);

		public void SetKernelSize(int size0, int size1, int size2)
		{
			vtkImageMedian3D.vtkImageMedian3D_SetKernelSize_07(base.GetCppThis(), size0, size1, size2);
		}
	}
}

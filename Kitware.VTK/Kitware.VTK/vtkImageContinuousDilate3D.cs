using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageContinuousDilate3D : vtkImageSpatialAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageContinuousDilate3D";

		public new static readonly string MRClassNameKey;

		static vtkImageContinuousDilate3D()
		{
			vtkImageContinuousDilate3D.MRClassNameKey = "class vtkImageContinuousDilate3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageContinuousDilate3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageContinuousDilate3D"));
		}

		public vtkImageContinuousDilate3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageContinuousDilate3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageContinuousDilate3D New()
		{
			vtkImageContinuousDilate3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageContinuousDilate3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageContinuousDilate3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageContinuousDilate3D_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageContinuousDilate3D_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageContinuousDilate3D_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageContinuousDilate3D NewInstance()
		{
			vtkImageContinuousDilate3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageContinuousDilate3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageContinuousDilate3D_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageContinuousDilate3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageContinuousDilate3D vtkImageContinuousDilate3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageContinuousDilate3D = (vtkImageContinuousDilate3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageContinuousDilate3D.Register(null);
				}
			}
			return vtkImageContinuousDilate3D;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageContinuousDilate3D_SetKernelSize_06(HandleRef pThis, int size0, int size1, int size2);

		public void SetKernelSize(int size0, int size1, int size2)
		{
			vtkImageContinuousDilate3D.vtkImageContinuousDilate3D_SetKernelSize_06(base.GetCppThis(), size0, size1, size2);
		}
	}
}

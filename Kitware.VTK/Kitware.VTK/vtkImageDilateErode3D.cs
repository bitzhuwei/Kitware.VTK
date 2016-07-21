using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageDilateErode3D : vtkImageSpatialAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDilateErode3D";

		public new static readonly string MRClassNameKey;

		static vtkImageDilateErode3D()
		{
			vtkImageDilateErode3D.MRClassNameKey = "class vtkImageDilateErode3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDilateErode3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDilateErode3D"));
		}

		public vtkImageDilateErode3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDilateErode3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageDilateErode3D New()
		{
			vtkImageDilateErode3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDilateErode3D.vtkImageDilateErode3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDilateErode3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageDilateErode3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageDilateErode3D.vtkImageDilateErode3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageDilateErode3D_GetDilateValue_01(HandleRef pThis);

		public virtual double GetDilateValue()
		{
			return vtkImageDilateErode3D.vtkImageDilateErode3D_GetDilateValue_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageDilateErode3D_GetErodeValue_02(HandleRef pThis);

		public virtual double GetErodeValue()
		{
			return vtkImageDilateErode3D.vtkImageDilateErode3D_GetErodeValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageDilateErode3D_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageDilateErode3D.vtkImageDilateErode3D_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageDilateErode3D_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageDilateErode3D.vtkImageDilateErode3D_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDilateErode3D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageDilateErode3D NewInstance()
		{
			vtkImageDilateErode3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDilateErode3D.vtkImageDilateErode3D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDilateErode3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDilateErode3D_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageDilateErode3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageDilateErode3D vtkImageDilateErode3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDilateErode3D.vtkImageDilateErode3D_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDilateErode3D = (vtkImageDilateErode3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDilateErode3D.Register(null);
				}
			}
			return vtkImageDilateErode3D;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDilateErode3D_SetDilateValue_08(HandleRef pThis, double _arg);

		public virtual void SetDilateValue(double _arg)
		{
			vtkImageDilateErode3D.vtkImageDilateErode3D_SetDilateValue_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDilateErode3D_SetErodeValue_09(HandleRef pThis, double _arg);

		public virtual void SetErodeValue(double _arg)
		{
			vtkImageDilateErode3D.vtkImageDilateErode3D_SetErodeValue_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDilateErode3D_SetKernelSize_10(HandleRef pThis, int size0, int size1, int size2);

		public void SetKernelSize(int size0, int size1, int size2)
		{
			vtkImageDilateErode3D.vtkImageDilateErode3D_SetKernelSize_10(base.GetCppThis(), size0, size1, size2);
		}
	}
}

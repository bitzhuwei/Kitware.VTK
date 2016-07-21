using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageHybridMedian2D : vtkImageSpatialAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageHybridMedian2D";

		public new static readonly string MRClassNameKey;

		static vtkImageHybridMedian2D()
		{
			vtkImageHybridMedian2D.MRClassNameKey = "class vtkImageHybridMedian2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageHybridMedian2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageHybridMedian2D"));
		}

		public vtkImageHybridMedian2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageHybridMedian2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageHybridMedian2D New()
		{
			vtkImageHybridMedian2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageHybridMedian2D.vtkImageHybridMedian2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHybridMedian2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageHybridMedian2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageHybridMedian2D.vtkImageHybridMedian2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageHybridMedian2D_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageHybridMedian2D.vtkImageHybridMedian2D_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageHybridMedian2D_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageHybridMedian2D.vtkImageHybridMedian2D_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageHybridMedian2D_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageHybridMedian2D NewInstance()
		{
			vtkImageHybridMedian2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageHybridMedian2D.vtkImageHybridMedian2D_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHybridMedian2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageHybridMedian2D_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageHybridMedian2D SafeDownCast(vtkObjectBase o)
		{
			vtkImageHybridMedian2D vtkImageHybridMedian2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageHybridMedian2D.vtkImageHybridMedian2D_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageHybridMedian2D = (vtkImageHybridMedian2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageHybridMedian2D.Register(null);
				}
			}
			return vtkImageHybridMedian2D;
		}
	}
}

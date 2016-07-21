using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageSkeleton2D : vtkImageIterateFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSkeleton2D";

		public new static readonly string MRClassNameKey;

		static vtkImageSkeleton2D()
		{
			vtkImageSkeleton2D.MRClassNameKey = "class vtkImageSkeleton2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSkeleton2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSkeleton2D"));
		}

		public vtkImageSkeleton2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSkeleton2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageSkeleton2D New()
		{
			vtkImageSkeleton2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSkeleton2D.vtkImageSkeleton2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSkeleton2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageSkeleton2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageSkeleton2D.vtkImageSkeleton2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSkeleton2D_GetPrune_01(HandleRef pThis);

		public virtual int GetPrune()
		{
			return vtkImageSkeleton2D.vtkImageSkeleton2D_GetPrune_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSkeleton2D_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageSkeleton2D.vtkImageSkeleton2D_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSkeleton2D_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageSkeleton2D.vtkImageSkeleton2D_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSkeleton2D_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageSkeleton2D NewInstance()
		{
			vtkImageSkeleton2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSkeleton2D.vtkImageSkeleton2D_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSkeleton2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSkeleton2D_PruneOff_06(HandleRef pThis);

		public virtual void PruneOff()
		{
			vtkImageSkeleton2D.vtkImageSkeleton2D_PruneOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSkeleton2D_PruneOn_07(HandleRef pThis);

		public virtual void PruneOn()
		{
			vtkImageSkeleton2D.vtkImageSkeleton2D_PruneOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSkeleton2D_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageSkeleton2D SafeDownCast(vtkObjectBase o)
		{
			vtkImageSkeleton2D vtkImageSkeleton2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSkeleton2D.vtkImageSkeleton2D_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSkeleton2D = (vtkImageSkeleton2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSkeleton2D.Register(null);
				}
			}
			return vtkImageSkeleton2D;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSkeleton2D_SetNumberOfIterations_09(HandleRef pThis, int num);

		public virtual void SetNumberOfIterations(int num)
		{
			vtkImageSkeleton2D.vtkImageSkeleton2D_SetNumberOfIterations_09(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSkeleton2D_SetPrune_10(HandleRef pThis, int _arg);

		public virtual void SetPrune(int _arg)
		{
			vtkImageSkeleton2D.vtkImageSkeleton2D_SetPrune_10(base.GetCppThis(), _arg);
		}
	}
}

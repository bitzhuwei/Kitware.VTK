using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRectilinearGridOutlineFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridOutlineFilter";

		public new static readonly string MRClassNameKey;

		static vtkRectilinearGridOutlineFilter()
		{
			vtkRectilinearGridOutlineFilter.MRClassNameKey = "class vtkRectilinearGridOutlineFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearGridOutlineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridOutlineFilter"));
		}

		public vtkRectilinearGridOutlineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGridOutlineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectilinearGridOutlineFilter New()
		{
			vtkRectilinearGridOutlineFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGridOutlineFilter.vtkRectilinearGridOutlineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRectilinearGridOutlineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRectilinearGridOutlineFilter.vtkRectilinearGridOutlineFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkRectilinearGridOutlineFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRectilinearGridOutlineFilter.vtkRectilinearGridOutlineFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkRectilinearGridOutlineFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearGridOutlineFilter.vtkRectilinearGridOutlineFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGridOutlineFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRectilinearGridOutlineFilter NewInstance()
		{
			vtkRectilinearGridOutlineFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGridOutlineFilter.vtkRectilinearGridOutlineFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGridOutlineFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectilinearGridOutlineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearGridOutlineFilter vtkRectilinearGridOutlineFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGridOutlineFilter.vtkRectilinearGridOutlineFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGridOutlineFilter = (vtkRectilinearGridOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGridOutlineFilter.Register(null);
				}
			}
			return vtkRectilinearGridOutlineFilter;
		}
	}
}

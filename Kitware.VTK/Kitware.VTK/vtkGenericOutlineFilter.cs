using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericOutlineFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericOutlineFilter";

		public new static readonly string MRClassNameKey;

		static vtkGenericOutlineFilter()
		{
			vtkGenericOutlineFilter.MRClassNameKey = "class vtkGenericOutlineFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericOutlineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericOutlineFilter"));
		}

		public vtkGenericOutlineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericOutlineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericOutlineFilter New()
		{
			vtkGenericOutlineFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericOutlineFilter.vtkGenericOutlineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericOutlineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericOutlineFilter.vtkGenericOutlineFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericOutlineFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericOutlineFilter.vtkGenericOutlineFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericOutlineFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericOutlineFilter.vtkGenericOutlineFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericOutlineFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericOutlineFilter NewInstance()
		{
			vtkGenericOutlineFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericOutlineFilter.vtkGenericOutlineFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericOutlineFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericOutlineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGenericOutlineFilter vtkGenericOutlineFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericOutlineFilter.vtkGenericOutlineFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericOutlineFilter = (vtkGenericOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericOutlineFilter.Register(null);
				}
			}
			return vtkGenericOutlineFilter;
		}
	}
}

using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHierarchicalDataSetGeometryFilter : vtkCompositeDataGeometryFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalDataSetGeometryFilter";

		public new static readonly string MRClassNameKey;

		static vtkHierarchicalDataSetGeometryFilter()
		{
			vtkHierarchicalDataSetGeometryFilter.MRClassNameKey = "class vtkHierarchicalDataSetGeometryFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalDataSetGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalDataSetGeometryFilter"));
		}

		public vtkHierarchicalDataSetGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalDataSetGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalDataSetGeometryFilter New()
		{
			vtkHierarchicalDataSetGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalDataSetGeometryFilter.vtkHierarchicalDataSetGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataSetGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHierarchicalDataSetGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHierarchicalDataSetGeometryFilter.vtkHierarchicalDataSetGeometryFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHierarchicalDataSetGeometryFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHierarchicalDataSetGeometryFilter.vtkHierarchicalDataSetGeometryFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHierarchicalDataSetGeometryFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalDataSetGeometryFilter.vtkHierarchicalDataSetGeometryFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalDataSetGeometryFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHierarchicalDataSetGeometryFilter NewInstance()
		{
			vtkHierarchicalDataSetGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalDataSetGeometryFilter.vtkHierarchicalDataSetGeometryFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataSetGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalDataSetGeometryFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalDataSetGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalDataSetGeometryFilter vtkHierarchicalDataSetGeometryFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalDataSetGeometryFilter.vtkHierarchicalDataSetGeometryFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalDataSetGeometryFilter = (vtkHierarchicalDataSetGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalDataSetGeometryFilter.Register(null);
				}
			}
			return vtkHierarchicalDataSetGeometryFilter;
		}
	}
}

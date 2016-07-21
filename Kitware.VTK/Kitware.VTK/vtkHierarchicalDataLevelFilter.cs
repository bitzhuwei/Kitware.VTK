using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHierarchicalDataLevelFilter : vtkLevelIdScalars
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalDataLevelFilter";

		public new static readonly string MRClassNameKey;

		static vtkHierarchicalDataLevelFilter()
		{
			vtkHierarchicalDataLevelFilter.MRClassNameKey = "class vtkHierarchicalDataLevelFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalDataLevelFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalDataLevelFilter"));
		}

		public vtkHierarchicalDataLevelFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalDataLevelFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalDataLevelFilter New()
		{
			vtkHierarchicalDataLevelFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalDataLevelFilter.vtkHierarchicalDataLevelFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataLevelFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHierarchicalDataLevelFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHierarchicalDataLevelFilter.vtkHierarchicalDataLevelFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHierarchicalDataLevelFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHierarchicalDataLevelFilter.vtkHierarchicalDataLevelFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHierarchicalDataLevelFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalDataLevelFilter.vtkHierarchicalDataLevelFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalDataLevelFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHierarchicalDataLevelFilter NewInstance()
		{
			vtkHierarchicalDataLevelFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalDataLevelFilter.vtkHierarchicalDataLevelFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataLevelFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalDataLevelFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalDataLevelFilter SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalDataLevelFilter vtkHierarchicalDataLevelFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalDataLevelFilter.vtkHierarchicalDataLevelFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalDataLevelFilter = (vtkHierarchicalDataLevelFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalDataLevelFilter.Register(null);
				}
			}
			return vtkHierarchicalDataLevelFilter;
		}
	}
}

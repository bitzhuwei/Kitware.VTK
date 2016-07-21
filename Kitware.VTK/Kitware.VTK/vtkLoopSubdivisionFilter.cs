using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLoopSubdivisionFilter : vtkApproximatingSubdivisionFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLoopSubdivisionFilter";

		public new static readonly string MRClassNameKey;

		static vtkLoopSubdivisionFilter()
		{
			vtkLoopSubdivisionFilter.MRClassNameKey = "class vtkLoopSubdivisionFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLoopSubdivisionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLoopSubdivisionFilter"));
		}

		public vtkLoopSubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLoopSubdivisionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLoopSubdivisionFilter New()
		{
			vtkLoopSubdivisionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLoopSubdivisionFilter.vtkLoopSubdivisionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLoopSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLoopSubdivisionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLoopSubdivisionFilter.vtkLoopSubdivisionFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLoopSubdivisionFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLoopSubdivisionFilter.vtkLoopSubdivisionFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLoopSubdivisionFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLoopSubdivisionFilter.vtkLoopSubdivisionFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLoopSubdivisionFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLoopSubdivisionFilter NewInstance()
		{
			vtkLoopSubdivisionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLoopSubdivisionFilter.vtkLoopSubdivisionFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLoopSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLoopSubdivisionFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLoopSubdivisionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkLoopSubdivisionFilter vtkLoopSubdivisionFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLoopSubdivisionFilter.vtkLoopSubdivisionFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLoopSubdivisionFilter = (vtkLoopSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLoopSubdivisionFilter.Register(null);
				}
			}
			return vtkLoopSubdivisionFilter;
		}
	}
}

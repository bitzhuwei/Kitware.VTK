using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkApproximatingSubdivisionFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkApproximatingSubdivisionFilter";

		public new static readonly string MRClassNameKey;

		static vtkApproximatingSubdivisionFilter()
		{
			vtkApproximatingSubdivisionFilter.MRClassNameKey = "class vtkApproximatingSubdivisionFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkApproximatingSubdivisionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkApproximatingSubdivisionFilter"));
		}

		public vtkApproximatingSubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkApproximatingSubdivisionFilter_GetNumberOfSubdivisions_01(HandleRef pThis);

		public virtual int GetNumberOfSubdivisions()
		{
			return vtkApproximatingSubdivisionFilter.vtkApproximatingSubdivisionFilter_GetNumberOfSubdivisions_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkApproximatingSubdivisionFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkApproximatingSubdivisionFilter.vtkApproximatingSubdivisionFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkApproximatingSubdivisionFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkApproximatingSubdivisionFilter.vtkApproximatingSubdivisionFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkApproximatingSubdivisionFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkApproximatingSubdivisionFilter NewInstance()
		{
			vtkApproximatingSubdivisionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkApproximatingSubdivisionFilter.vtkApproximatingSubdivisionFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkApproximatingSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkApproximatingSubdivisionFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkApproximatingSubdivisionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkApproximatingSubdivisionFilter vtkApproximatingSubdivisionFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkApproximatingSubdivisionFilter.vtkApproximatingSubdivisionFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkApproximatingSubdivisionFilter = (vtkApproximatingSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkApproximatingSubdivisionFilter.Register(null);
				}
			}
			return vtkApproximatingSubdivisionFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkApproximatingSubdivisionFilter_SetNumberOfSubdivisions_06(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSubdivisions(int _arg)
		{
			vtkApproximatingSubdivisionFilter.vtkApproximatingSubdivisionFilter_SetNumberOfSubdivisions_06(base.GetCppThis(), _arg);
		}
	}
}

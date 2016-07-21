using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkInterpolatingSubdivisionFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInterpolatingSubdivisionFilter";

		public new static readonly string MRClassNameKey;

		static vtkInterpolatingSubdivisionFilter()
		{
			vtkInterpolatingSubdivisionFilter.MRClassNameKey = "class vtkInterpolatingSubdivisionFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInterpolatingSubdivisionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInterpolatingSubdivisionFilter"));
		}

		public vtkInterpolatingSubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkInterpolatingSubdivisionFilter_GetNumberOfSubdivisions_01(HandleRef pThis);

		public virtual int GetNumberOfSubdivisions()
		{
			return vtkInterpolatingSubdivisionFilter.vtkInterpolatingSubdivisionFilter_GetNumberOfSubdivisions_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkInterpolatingSubdivisionFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInterpolatingSubdivisionFilter.vtkInterpolatingSubdivisionFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkInterpolatingSubdivisionFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInterpolatingSubdivisionFilter.vtkInterpolatingSubdivisionFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkInterpolatingSubdivisionFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInterpolatingSubdivisionFilter NewInstance()
		{
			vtkInterpolatingSubdivisionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInterpolatingSubdivisionFilter.vtkInterpolatingSubdivisionFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInterpolatingSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkInterpolatingSubdivisionFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInterpolatingSubdivisionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkInterpolatingSubdivisionFilter vtkInterpolatingSubdivisionFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInterpolatingSubdivisionFilter.vtkInterpolatingSubdivisionFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInterpolatingSubdivisionFilter = (vtkInterpolatingSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInterpolatingSubdivisionFilter.Register(null);
				}
			}
			return vtkInterpolatingSubdivisionFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkInterpolatingSubdivisionFilter_SetNumberOfSubdivisions_06(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSubdivisions(int _arg)
		{
			vtkInterpolatingSubdivisionFilter.vtkInterpolatingSubdivisionFilter_SetNumberOfSubdivisions_06(base.GetCppThis(), _arg);
		}
	}
}

using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLinearSubdivisionFilter : vtkInterpolatingSubdivisionFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLinearSubdivisionFilter";

		public new static readonly string MRClassNameKey;

		static vtkLinearSubdivisionFilter()
		{
			vtkLinearSubdivisionFilter.MRClassNameKey = "class vtkLinearSubdivisionFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLinearSubdivisionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearSubdivisionFilter"));
		}

		public vtkLinearSubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearSubdivisionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLinearSubdivisionFilter New()
		{
			vtkLinearSubdivisionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLinearSubdivisionFilter.vtkLinearSubdivisionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLinearSubdivisionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLinearSubdivisionFilter.vtkLinearSubdivisionFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLinearSubdivisionFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLinearSubdivisionFilter.vtkLinearSubdivisionFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLinearSubdivisionFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLinearSubdivisionFilter.vtkLinearSubdivisionFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearSubdivisionFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLinearSubdivisionFilter NewInstance()
		{
			vtkLinearSubdivisionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLinearSubdivisionFilter.vtkLinearSubdivisionFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearSubdivisionFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLinearSubdivisionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkLinearSubdivisionFilter vtkLinearSubdivisionFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLinearSubdivisionFilter.vtkLinearSubdivisionFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearSubdivisionFilter = (vtkLinearSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearSubdivisionFilter.Register(null);
				}
			}
			return vtkLinearSubdivisionFilter;
		}
	}
}

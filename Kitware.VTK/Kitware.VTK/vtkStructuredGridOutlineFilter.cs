using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredGridOutlineFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridOutlineFilter";

		public new static readonly string MRClassNameKey;

		static vtkStructuredGridOutlineFilter()
		{
			vtkStructuredGridOutlineFilter.MRClassNameKey = "class vtkStructuredGridOutlineFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGridOutlineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridOutlineFilter"));
		}

		public vtkStructuredGridOutlineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridOutlineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredGridOutlineFilter New()
		{
			vtkStructuredGridOutlineFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridOutlineFilter.vtkStructuredGridOutlineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStructuredGridOutlineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStructuredGridOutlineFilter.vtkStructuredGridOutlineFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStructuredGridOutlineFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredGridOutlineFilter.vtkStructuredGridOutlineFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStructuredGridOutlineFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGridOutlineFilter.vtkStructuredGridOutlineFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridOutlineFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredGridOutlineFilter NewInstance()
		{
			vtkStructuredGridOutlineFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridOutlineFilter.vtkStructuredGridOutlineFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridOutlineFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredGridOutlineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGridOutlineFilter vtkStructuredGridOutlineFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridOutlineFilter.vtkStructuredGridOutlineFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGridOutlineFilter = (vtkStructuredGridOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGridOutlineFilter.Register(null);
				}
			}
			return vtkStructuredGridOutlineFilter;
		}
	}
}

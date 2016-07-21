using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkButterflySubdivisionFilter : vtkInterpolatingSubdivisionFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkButterflySubdivisionFilter";

		public new static readonly string MRClassNameKey;

		static vtkButterflySubdivisionFilter()
		{
			vtkButterflySubdivisionFilter.MRClassNameKey = "class vtkButterflySubdivisionFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkButterflySubdivisionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkButterflySubdivisionFilter"));
		}

		public vtkButterflySubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkButterflySubdivisionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkButterflySubdivisionFilter New()
		{
			vtkButterflySubdivisionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkButterflySubdivisionFilter.vtkButterflySubdivisionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkButterflySubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkButterflySubdivisionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkButterflySubdivisionFilter.vtkButterflySubdivisionFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkButterflySubdivisionFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkButterflySubdivisionFilter.vtkButterflySubdivisionFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkButterflySubdivisionFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkButterflySubdivisionFilter.vtkButterflySubdivisionFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkButterflySubdivisionFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkButterflySubdivisionFilter NewInstance()
		{
			vtkButterflySubdivisionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkButterflySubdivisionFilter.vtkButterflySubdivisionFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkButterflySubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkButterflySubdivisionFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkButterflySubdivisionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkButterflySubdivisionFilter vtkButterflySubdivisionFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkButterflySubdivisionFilter.vtkButterflySubdivisionFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkButterflySubdivisionFilter = (vtkButterflySubdivisionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkButterflySubdivisionFilter.Register(null);
				}
			}
			return vtkButterflySubdivisionFilter;
		}
	}
}

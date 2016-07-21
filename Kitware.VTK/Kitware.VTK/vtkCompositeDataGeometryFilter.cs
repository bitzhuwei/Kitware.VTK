using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCompositeDataGeometryFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataGeometryFilter";

		public new static readonly string MRClassNameKey;

		static vtkCompositeDataGeometryFilter()
		{
			vtkCompositeDataGeometryFilter.MRClassNameKey = "class vtkCompositeDataGeometryFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeDataGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataGeometryFilter"));
		}

		public vtkCompositeDataGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositeDataGeometryFilter New()
		{
			vtkCompositeDataGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataGeometryFilter.vtkCompositeDataGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCompositeDataGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCompositeDataGeometryFilter.vtkCompositeDataGeometryFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCompositeDataGeometryFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCompositeDataGeometryFilter.vtkCompositeDataGeometryFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCompositeDataGeometryFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCompositeDataGeometryFilter.vtkCompositeDataGeometryFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataGeometryFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCompositeDataGeometryFilter NewInstance()
		{
			vtkCompositeDataGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataGeometryFilter.vtkCompositeDataGeometryFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataGeometryFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositeDataGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeDataGeometryFilter vtkCompositeDataGeometryFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataGeometryFilter.vtkCompositeDataGeometryFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataGeometryFilter = (vtkCompositeDataGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataGeometryFilter.Register(null);
				}
			}
			return vtkCompositeDataGeometryFilter;
		}
	}
}

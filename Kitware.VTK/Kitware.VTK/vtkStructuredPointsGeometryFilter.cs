using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredPointsGeometryFilter : vtkImageDataGeometryFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredPointsGeometryFilter";

		public new static readonly string MRClassNameKey;

		static vtkStructuredPointsGeometryFilter()
		{
			vtkStructuredPointsGeometryFilter.MRClassNameKey = "class vtkStructuredPointsGeometryFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredPointsGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredPointsGeometryFilter"));
		}

		public vtkStructuredPointsGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredPointsGeometryFilter New()
		{
			vtkStructuredPointsGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsGeometryFilter.vtkStructuredPointsGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStructuredPointsGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStructuredPointsGeometryFilter.vtkStructuredPointsGeometryFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStructuredPointsGeometryFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredPointsGeometryFilter.vtkStructuredPointsGeometryFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStructuredPointsGeometryFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredPointsGeometryFilter.vtkStructuredPointsGeometryFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsGeometryFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredPointsGeometryFilter NewInstance()
		{
			vtkStructuredPointsGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsGeometryFilter.vtkStructuredPointsGeometryFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsGeometryFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredPointsGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredPointsGeometryFilter vtkStructuredPointsGeometryFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsGeometryFilter.vtkStructuredPointsGeometryFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPointsGeometryFilter = (vtkStructuredPointsGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPointsGeometryFilter.Register(null);
				}
			}
			return vtkStructuredPointsGeometryFilter;
		}
	}
}

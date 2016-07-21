using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredGridGeometryFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridGeometryFilter";

		public new static readonly string MRClassNameKey;

		static vtkStructuredGridGeometryFilter()
		{
			vtkStructuredGridGeometryFilter.MRClassNameKey = "class vtkStructuredGridGeometryFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGridGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridGeometryFilter"));
		}

		public vtkStructuredGridGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredGridGeometryFilter New()
		{
			vtkStructuredGridGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStructuredGridGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridGeometryFilter_GetExtent_01(HandleRef pThis);

		public virtual int[] GetExtent()
		{
			IntPtr intPtr = vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_GetExtent_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStructuredGridGeometryFilter_GetExtent_02(HandleRef pThis, IntPtr data);

		public virtual void GetExtent(IntPtr data)
		{
			vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_GetExtent_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStructuredGridGeometryFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStructuredGridGeometryFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridGeometryFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredGridGeometryFilter NewInstance()
		{
			vtkStructuredGridGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridGeometryFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredGridGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGridGeometryFilter vtkStructuredGridGeometryFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGridGeometryFilter = (vtkStructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGridGeometryFilter.Register(null);
				}
			}
			return vtkStructuredGridGeometryFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStructuredGridGeometryFilter_SetExtent_08(HandleRef pThis, int iMin, int iMax, int jMin, int jMax, int kMin, int kMax);

		public void SetExtent(int iMin, int iMax, int jMin, int jMax, int kMin, int kMax)
		{
			vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_SetExtent_08(base.GetCppThis(), iMin, iMax, jMin, jMax, kMin, kMax);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStructuredGridGeometryFilter_SetExtent_09(HandleRef pThis, IntPtr extent);

		public void SetExtent(IntPtr extent)
		{
			vtkStructuredGridGeometryFilter.vtkStructuredGridGeometryFilter_SetExtent_09(base.GetCppThis(), extent);
		}
	}
}

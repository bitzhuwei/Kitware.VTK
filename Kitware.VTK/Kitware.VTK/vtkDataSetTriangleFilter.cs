using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataSetTriangleFilter : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetTriangleFilter";

		public new static readonly string MRClassNameKey;

		static vtkDataSetTriangleFilter()
		{
			vtkDataSetTriangleFilter.MRClassNameKey = "class vtkDataSetTriangleFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetTriangleFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetTriangleFilter"));
		}

		public vtkDataSetTriangleFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetTriangleFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetTriangleFilter New()
		{
			vtkDataSetTriangleFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetTriangleFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataSetTriangleFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetTriangleFilter_GetTetrahedraOnly_01(HandleRef pThis);

		public virtual int GetTetrahedraOnly()
		{
			return vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_GetTetrahedraOnly_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetTriangleFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetTriangleFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetTriangleFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSetTriangleFilter NewInstance()
		{
			vtkDataSetTriangleFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetTriangleFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetTriangleFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetTriangleFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetTriangleFilter vtkDataSetTriangleFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetTriangleFilter = (vtkDataSetTriangleFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetTriangleFilter.Register(null);
				}
			}
			return vtkDataSetTriangleFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetTriangleFilter_SetTetrahedraOnly_07(HandleRef pThis, int _arg);

		public virtual void SetTetrahedraOnly(int _arg)
		{
			vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_SetTetrahedraOnly_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetTriangleFilter_TetrahedraOnlyOff_08(HandleRef pThis);

		public virtual void TetrahedraOnlyOff()
		{
			vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_TetrahedraOnlyOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetTriangleFilter_TetrahedraOnlyOn_09(HandleRef pThis);

		public virtual void TetrahedraOnlyOn()
		{
			vtkDataSetTriangleFilter.vtkDataSetTriangleFilter_TetrahedraOnlyOn_09(base.GetCppThis());
		}
	}
}

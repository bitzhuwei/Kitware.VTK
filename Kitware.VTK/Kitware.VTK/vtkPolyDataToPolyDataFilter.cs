using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolyDataToPolyDataFilter : vtkPolyDataSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataToPolyDataFilter";

		public new static readonly string MRClassNameKey;

		static vtkPolyDataToPolyDataFilter()
		{
			vtkPolyDataToPolyDataFilter.MRClassNameKey = "class vtkPolyDataToPolyDataFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataToPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataToPolyDataFilter"));
		}

		public vtkPolyDataToPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataToPolyDataFilter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataToPolyDataFilter.vtkPolyDataToPolyDataFilter_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyDataToPolyDataFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyDataToPolyDataFilter.vtkPolyDataToPolyDataFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolyDataToPolyDataFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataToPolyDataFilter.vtkPolyDataToPolyDataFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataToPolyDataFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyDataToPolyDataFilter NewInstance()
		{
			vtkPolyDataToPolyDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataToPolyDataFilter.vtkPolyDataToPolyDataFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataToPolyDataFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataToPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataToPolyDataFilter vtkPolyDataToPolyDataFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataToPolyDataFilter.vtkPolyDataToPolyDataFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataToPolyDataFilter = (vtkPolyDataToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataToPolyDataFilter.Register(null);
				}
			}
			return vtkPolyDataToPolyDataFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolyDataToPolyDataFilter_SetInput_06(HandleRef pThis, HandleRef input);

		public virtual void SetInput(vtkPolyData input)
		{
			vtkPolyDataToPolyDataFilter.vtkPolyDataToPolyDataFilter_SetInput_06(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}

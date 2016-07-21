using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCellCenterDepthSort : vtkVisibilitySort
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellCenterDepthSort";

		public new static readonly string MRClassNameKey;

		static vtkCellCenterDepthSort()
		{
			vtkCellCenterDepthSort.MRClassNameKey = "class vtkCellCenterDepthSort";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellCenterDepthSort.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellCenterDepthSort"));
		}

		public vtkCellCenterDepthSort(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellCenterDepthSort_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellCenterDepthSort New()
		{
			vtkCellCenterDepthSort result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellCenterDepthSort.vtkCellCenterDepthSort_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellCenterDepthSort)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCellCenterDepthSort() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCellCenterDepthSort.vtkCellCenterDepthSort_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellCenterDepthSort_GetNextCells_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkIdTypeArray GetNextCells()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellCenterDepthSort.vtkCellCenterDepthSort_GetNextCells_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellCenterDepthSort_InitTraversal_02(HandleRef pThis);

		public override void InitTraversal()
		{
			vtkCellCenterDepthSort.vtkCellCenterDepthSort_InitTraversal_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCellCenterDepthSort_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCellCenterDepthSort.vtkCellCenterDepthSort_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCellCenterDepthSort_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCellCenterDepthSort.vtkCellCenterDepthSort_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellCenterDepthSort_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCellCenterDepthSort NewInstance()
		{
			vtkCellCenterDepthSort result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellCenterDepthSort.vtkCellCenterDepthSort_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellCenterDepthSort)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellCenterDepthSort_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellCenterDepthSort SafeDownCast(vtkObjectBase o)
		{
			vtkCellCenterDepthSort vtkCellCenterDepthSort = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellCenterDepthSort.vtkCellCenterDepthSort_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellCenterDepthSort = (vtkCellCenterDepthSort)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellCenterDepthSort.Register(null);
				}
			}
			return vtkCellCenterDepthSort;
		}
	}
}

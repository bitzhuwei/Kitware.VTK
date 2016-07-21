using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCellArray : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellArray";

		public new static readonly string MRClassNameKey;

		static vtkCellArray()
		{
			vtkCellArray.MRClassNameKey = "class vtkCellArray";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellArray"));
		}

		public vtkCellArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellArray New()
		{
			vtkCellArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellArray.vtkCellArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCellArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCellArray.vtkCellArray_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellArray_Allocate_01(HandleRef pThis, long sz, int ext);

		public int Allocate(long sz, int ext)
		{
			return vtkCellArray.vtkCellArray_Allocate_01(base.GetCppThis(), sz, ext);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellArray_DeepCopy_02(HandleRef pThis, HandleRef ca);

		public void DeepCopy(vtkCellArray ca)
		{
			vtkCellArray.vtkCellArray_DeepCopy_02(base.GetCppThis(), (ca == null) ? default(HandleRef) : ca.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellArray_EstimateSize_03(HandleRef pThis, long numCells, int maxPtsPerCell);

		public long EstimateSize(long numCells, int maxPtsPerCell)
		{
			return vtkCellArray.vtkCellArray_EstimateSize_03(base.GetCppThis(), numCells, maxPtsPerCell);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkCellArray_GetActualMemorySize_04(HandleRef pThis);

		public uint GetActualMemorySize()
		{
			return vtkCellArray.vtkCellArray_GetActualMemorySize_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellArray_GetCell_05(HandleRef pThis, long loc, HandleRef pts);

		public void GetCell(long loc, vtkIdList pts)
		{
			vtkCellArray.vtkCellArray_GetCell_05(base.GetCppThis(), loc, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellArray_GetData_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIdTypeArray GetData()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellArray.vtkCellArray_GetData_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellArray_GetInsertLocation_07(HandleRef pThis, int npts);

		public long GetInsertLocation(int npts)
		{
			return vtkCellArray.vtkCellArray_GetInsertLocation_07(base.GetCppThis(), npts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellArray_GetMaxCellSize_08(HandleRef pThis);

		public int GetMaxCellSize()
		{
			return vtkCellArray.vtkCellArray_GetMaxCellSize_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellArray_GetNextCell_09(HandleRef pThis, HandleRef pts);

		public int GetNextCell(vtkIdList pts)
		{
			return vtkCellArray.vtkCellArray_GetNextCell_09(base.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellArray_GetNumberOfCells_10(HandleRef pThis);

		public virtual long GetNumberOfCells()
		{
			return vtkCellArray.vtkCellArray_GetNumberOfCells_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellArray_GetNumberOfConnectivityEntries_11(HandleRef pThis);

		public long GetNumberOfConnectivityEntries()
		{
			return vtkCellArray.vtkCellArray_GetNumberOfConnectivityEntries_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellArray_GetPointer_12(HandleRef pThis);

		public IntPtr GetPointer()
		{
			return vtkCellArray.vtkCellArray_GetPointer_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellArray_GetSize_13(HandleRef pThis);

		public long GetSize()
		{
			return vtkCellArray.vtkCellArray_GetSize_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellArray_GetTraversalLocation_14(HandleRef pThis);

		public long GetTraversalLocation()
		{
			return vtkCellArray.vtkCellArray_GetTraversalLocation_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellArray_GetTraversalLocation_15(HandleRef pThis, long npts);

		public long GetTraversalLocation(long npts)
		{
			return vtkCellArray.vtkCellArray_GetTraversalLocation_15(base.GetCppThis(), npts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellArray_InitTraversal_16(HandleRef pThis);

		public void InitTraversal()
		{
			vtkCellArray.vtkCellArray_InitTraversal_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellArray_Initialize_17(HandleRef pThis);

		public void Initialize()
		{
			vtkCellArray.vtkCellArray_Initialize_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellArray_InsertCellPoint_18(HandleRef pThis, long id);

		public void InsertCellPoint(long id)
		{
			vtkCellArray.vtkCellArray_InsertCellPoint_18(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellArray_InsertNextCell_19(HandleRef pThis, HandleRef cell);

		public long InsertNextCell(vtkCell cell)
		{
			return vtkCellArray.vtkCellArray_InsertNextCell_19(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellArray_InsertNextCell_20(HandleRef pThis, long npts, IntPtr pts);

		public long InsertNextCell(long npts, IntPtr pts)
		{
			return vtkCellArray.vtkCellArray_InsertNextCell_20(base.GetCppThis(), npts, pts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellArray_InsertNextCell_21(HandleRef pThis, HandleRef pts);

		public long InsertNextCell(vtkIdList pts)
		{
			return vtkCellArray.vtkCellArray_InsertNextCell_21(base.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellArray_InsertNextCell_22(HandleRef pThis, int npts);

		public long InsertNextCell(int npts)
		{
			return vtkCellArray.vtkCellArray_InsertNextCell_22(base.GetCppThis(), npts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellArray_IsA_23(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCellArray.vtkCellArray_IsA_23(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellArray_IsTypeOf_24(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCellArray.vtkCellArray_IsTypeOf_24(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellArray_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCellArray NewInstance()
		{
			vtkCellArray result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellArray.vtkCellArray_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellArray_ReplaceCell_27(HandleRef pThis, long loc, int npts, IntPtr pts);

		public void ReplaceCell(long loc, int npts, IntPtr pts)
		{
			vtkCellArray.vtkCellArray_ReplaceCell_27(base.GetCppThis(), loc, npts, pts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellArray_Reset_28(HandleRef pThis);

		public void Reset()
		{
			vtkCellArray.vtkCellArray_Reset_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellArray_ReverseCell_29(HandleRef pThis, long loc);

		public void ReverseCell(long loc)
		{
			vtkCellArray.vtkCellArray_ReverseCell_29(base.GetCppThis(), loc);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellArray_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellArray SafeDownCast(vtkObjectBase o)
		{
			vtkCellArray vtkCellArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellArray.vtkCellArray_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellArray = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellArray.Register(null);
				}
			}
			return vtkCellArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellArray_SetCells_31(HandleRef pThis, long ncells, HandleRef cells);

		public void SetCells(long ncells, vtkIdTypeArray cells)
		{
			vtkCellArray.vtkCellArray_SetCells_31(base.GetCppThis(), ncells, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellArray_SetNumberOfCells_32(HandleRef pThis, long _arg);

		public virtual void SetNumberOfCells(long _arg)
		{
			vtkCellArray.vtkCellArray_SetNumberOfCells_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellArray_SetTraversalLocation_33(HandleRef pThis, long loc);

		public void SetTraversalLocation(long loc)
		{
			vtkCellArray.vtkCellArray_SetTraversalLocation_33(base.GetCppThis(), loc);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellArray_Squeeze_34(HandleRef pThis);

		public void Squeeze()
		{
			vtkCellArray.vtkCellArray_Squeeze_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellArray_UpdateCellCount_35(HandleRef pThis, int npts);

		public void UpdateCellCount(int npts)
		{
			vtkCellArray.vtkCellArray_UpdateCellCount_35(base.GetCppThis(), npts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellArray_WritePointer_36(HandleRef pThis, long ncells, long size);

		public IntPtr WritePointer(long ncells, long size)
		{
			return vtkCellArray.vtkCellArray_WritePointer_36(base.GetCppThis(), ncells, size);
		}
	}
}

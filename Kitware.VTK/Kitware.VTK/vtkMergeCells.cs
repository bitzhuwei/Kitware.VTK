using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMergeCells : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeCells";

		public new static readonly string MRClassNameKey;

		static vtkMergeCells()
		{
			vtkMergeCells.MRClassNameKey = "class vtkMergeCells";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeCells.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeCells"));
		}

		public vtkMergeCells(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeCells_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMergeCells New()
		{
			vtkMergeCells result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeCells.vtkMergeCells_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeCells)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMergeCells() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMergeCells.vtkMergeCells_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeCells_Finish_01(HandleRef pThis);

		public void Finish()
		{
			vtkMergeCells.vtkMergeCells_Finish_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMergeCells_GetMergeDuplicatePoints_02(HandleRef pThis);

		public virtual int GetMergeDuplicatePoints()
		{
			return vtkMergeCells.vtkMergeCells_GetMergeDuplicatePoints_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern float vtkMergeCells_GetPointMergeTolerance_03(HandleRef pThis);

		public virtual float GetPointMergeTolerance()
		{
			return vtkMergeCells.vtkMergeCells_GetPointMergeTolerance_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern float vtkMergeCells_GetPointMergeToleranceMaxValue_04(HandleRef pThis);

		public virtual float GetPointMergeToleranceMaxValue()
		{
			return vtkMergeCells.vtkMergeCells_GetPointMergeToleranceMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern float vtkMergeCells_GetPointMergeToleranceMinValue_05(HandleRef pThis);

		public virtual float GetPointMergeToleranceMinValue()
		{
			return vtkMergeCells.vtkMergeCells_GetPointMergeToleranceMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkMergeCells_GetTotalNumberOfCells_06(HandleRef pThis);

		public virtual long GetTotalNumberOfCells()
		{
			return vtkMergeCells.vtkMergeCells_GetTotalNumberOfCells_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMergeCells_GetTotalNumberOfDataSets_07(HandleRef pThis);

		public virtual int GetTotalNumberOfDataSets()
		{
			return vtkMergeCells.vtkMergeCells_GetTotalNumberOfDataSets_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkMergeCells_GetTotalNumberOfPoints_08(HandleRef pThis);

		public virtual long GetTotalNumberOfPoints()
		{
			return vtkMergeCells.vtkMergeCells_GetTotalNumberOfPoints_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeCells_GetUnstructuredGrid_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkUnstructuredGrid GetUnstructuredGrid()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeCells.vtkMergeCells_GetUnstructuredGrid_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMergeCells_GetUseGlobalCellIds_10(HandleRef pThis);

		public virtual int GetUseGlobalCellIds()
		{
			return vtkMergeCells.vtkMergeCells_GetUseGlobalCellIds_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMergeCells_GetUseGlobalIds_11(HandleRef pThis);

		public virtual int GetUseGlobalIds()
		{
			return vtkMergeCells.vtkMergeCells_GetUseGlobalIds_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMergeCells_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMergeCells.vtkMergeCells_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMergeCells_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMergeCells.vtkMergeCells_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMergeCells_MergeDataSet_14(HandleRef pThis, HandleRef set);

		public int MergeDataSet(vtkDataSet set)
		{
			return vtkMergeCells.vtkMergeCells_MergeDataSet_14(base.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeCells_MergeDuplicatePointsOff_15(HandleRef pThis);

		public virtual void MergeDuplicatePointsOff()
		{
			vtkMergeCells.vtkMergeCells_MergeDuplicatePointsOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeCells_MergeDuplicatePointsOn_16(HandleRef pThis);

		public virtual void MergeDuplicatePointsOn()
		{
			vtkMergeCells.vtkMergeCells_MergeDuplicatePointsOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeCells_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMergeCells NewInstance()
		{
			vtkMergeCells result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeCells.vtkMergeCells_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeCells)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeCells_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMergeCells SafeDownCast(vtkObjectBase o)
		{
			vtkMergeCells vtkMergeCells = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeCells.vtkMergeCells_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeCells = (vtkMergeCells)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeCells.Register(null);
				}
			}
			return vtkMergeCells;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeCells_SetMergeDuplicatePoints_20(HandleRef pThis, int _arg);

		public virtual void SetMergeDuplicatePoints(int _arg)
		{
			vtkMergeCells.vtkMergeCells_SetMergeDuplicatePoints_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeCells_SetPointMergeTolerance_21(HandleRef pThis, float _arg);

		public virtual void SetPointMergeTolerance(float _arg)
		{
			vtkMergeCells.vtkMergeCells_SetPointMergeTolerance_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeCells_SetTotalNumberOfCells_22(HandleRef pThis, long _arg);

		public virtual void SetTotalNumberOfCells(long _arg)
		{
			vtkMergeCells.vtkMergeCells_SetTotalNumberOfCells_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeCells_SetTotalNumberOfDataSets_23(HandleRef pThis, int _arg);

		public virtual void SetTotalNumberOfDataSets(int _arg)
		{
			vtkMergeCells.vtkMergeCells_SetTotalNumberOfDataSets_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeCells_SetTotalNumberOfPoints_24(HandleRef pThis, long _arg);

		public virtual void SetTotalNumberOfPoints(long _arg)
		{
			vtkMergeCells.vtkMergeCells_SetTotalNumberOfPoints_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeCells_SetUnstructuredGrid_25(HandleRef pThis, HandleRef arg0);

		public virtual void SetUnstructuredGrid(vtkUnstructuredGrid arg0)
		{
			vtkMergeCells.vtkMergeCells_SetUnstructuredGrid_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeCells_SetUseGlobalCellIds_26(HandleRef pThis, int _arg);

		public virtual void SetUseGlobalCellIds(int _arg)
		{
			vtkMergeCells.vtkMergeCells_SetUseGlobalCellIds_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeCells_SetUseGlobalIds_27(HandleRef pThis, int _arg);

		public virtual void SetUseGlobalIds(int _arg)
		{
			vtkMergeCells.vtkMergeCells_SetUseGlobalIds_27(base.GetCppThis(), _arg);
		}
	}
}

using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericEdgeTable : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericEdgeTable";

		public new static readonly string MRClassNameKey;

		static vtkGenericEdgeTable()
		{
			vtkGenericEdgeTable.MRClassNameKey = "class vtkGenericEdgeTable";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericEdgeTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericEdgeTable"));
		}

		public vtkGenericEdgeTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEdgeTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericEdgeTable New()
		{
			vtkGenericEdgeTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericEdgeTable.vtkGenericEdgeTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericEdgeTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericEdgeTable.vtkGenericEdgeTable_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericEdgeTable_CheckEdge_01(HandleRef pThis, long e1, long e2, ref long ptId);

		public int CheckEdge(long e1, long e2, ref long ptId)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_CheckEdge_01(base.GetCppThis(), e1, e2, ref ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericEdgeTable_CheckEdgeReferenceCount_02(HandleRef pThis, long e1, long e2);

		public int CheckEdgeReferenceCount(long e1, long e2)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_CheckEdgeReferenceCount_02(base.GetCppThis(), e1, e2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericEdgeTable_CheckPoint_03(HandleRef pThis, long ptId);

		public int CheckPoint(long ptId)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_CheckPoint_03(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericEdgeTable_CheckPoint_04(HandleRef pThis, long ptId, IntPtr point, IntPtr scalar);

		public int CheckPoint(long ptId, IntPtr point, IntPtr scalar)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_CheckPoint_04(base.GetCppThis(), ptId, point, scalar);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericEdgeTable_DumpTable_05(HandleRef pThis);

		public void DumpTable()
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_DumpTable_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericEdgeTable_GetNumberOfComponents_06(HandleRef pThis);

		public int GetNumberOfComponents()
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_GetNumberOfComponents_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericEdgeTable_IncrementEdgeReferenceCount_07(HandleRef pThis, long e1, long e2, long cellId);

		public int IncrementEdgeReferenceCount(long e1, long e2, long cellId)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_IncrementEdgeReferenceCount_07(base.GetCppThis(), e1, e2, cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericEdgeTable_IncrementPointReferenceCount_08(HandleRef pThis, long ptId);

		public void IncrementPointReferenceCount(long ptId)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_IncrementPointReferenceCount_08(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericEdgeTable_Initialize_09(HandleRef pThis, long start);

		public void Initialize(long start)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_Initialize_09(base.GetCppThis(), start);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericEdgeTable_InsertEdge_10(HandleRef pThis, long e1, long e2, long cellId, int arg3, ref long ptId);

		public void InsertEdge(long e1, long e2, long cellId, int arg3, ref long ptId)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_InsertEdge_10(base.GetCppThis(), e1, e2, cellId, arg3, ref ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericEdgeTable_InsertEdge_11(HandleRef pThis, long e1, long e2, long cellId, int arg3);

		public void InsertEdge(long e1, long e2, long cellId, int arg3)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_InsertEdge_11(base.GetCppThis(), e1, e2, cellId, arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericEdgeTable_InsertPoint_12(HandleRef pThis, long ptId, IntPtr point);

		public void InsertPoint(long ptId, IntPtr point)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_InsertPoint_12(base.GetCppThis(), ptId, point);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericEdgeTable_InsertPointAndScalar_13(HandleRef pThis, long ptId, IntPtr pt, IntPtr s);

		public void InsertPointAndScalar(long ptId, IntPtr pt, IntPtr s)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_InsertPointAndScalar_13(base.GetCppThis(), ptId, pt, s);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericEdgeTable_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericEdgeTable_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericEdgeTable_LoadFactor_16(HandleRef pThis);

		public void LoadFactor()
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_LoadFactor_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEdgeTable_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericEdgeTable NewInstance()
		{
			vtkGenericEdgeTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericEdgeTable.vtkGenericEdgeTable_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericEdgeTable_RemoveEdge_19(HandleRef pThis, long e1, long e2);

		public int RemoveEdge(long e1, long e2)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_RemoveEdge_19(base.GetCppThis(), e1, e2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericEdgeTable_RemovePoint_20(HandleRef pThis, long ptId);

		public void RemovePoint(long ptId)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_RemovePoint_20(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericEdgeTable_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericEdgeTable SafeDownCast(vtkObjectBase o)
		{
			vtkGenericEdgeTable vtkGenericEdgeTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericEdgeTable.vtkGenericEdgeTable_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericEdgeTable = (vtkGenericEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericEdgeTable.Register(null);
				}
			}
			return vtkGenericEdgeTable;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericEdgeTable_SetNumberOfComponents_22(HandleRef pThis, int count);

		public void SetNumberOfComponents(int count)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_SetNumberOfComponents_22(base.GetCppThis(), count);
		}
	}
}

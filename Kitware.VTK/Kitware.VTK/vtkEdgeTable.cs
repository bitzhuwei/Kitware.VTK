using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkEdgeTable : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEdgeTable";

		public new static readonly string MRClassNameKey;

		static vtkEdgeTable()
		{
			vtkEdgeTable.MRClassNameKey = "class vtkEdgeTable";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEdgeTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgeTable"));
		}

		public vtkEdgeTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEdgeTable New()
		{
			vtkEdgeTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgeTable.vtkEdgeTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkEdgeTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkEdgeTable.vtkEdgeTable_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkEdgeTable_GetNextEdge_01(HandleRef pThis, ref long p1, ref long p2);

		public long GetNextEdge(ref long p1, ref long p2)
		{
			return vtkEdgeTable.vtkEdgeTable_GetNextEdge_01(base.GetCppThis(), ref p1, ref p2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkEdgeTable_GetNumberOfEdges_02(HandleRef pThis);

		public virtual long GetNumberOfEdges()
		{
			return vtkEdgeTable.vtkEdgeTable_GetNumberOfEdges_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkEdgeTable_InitEdgeInsertion_03(HandleRef pThis, long numPoints, int storeAttributes);

		public int InitEdgeInsertion(long numPoints, int storeAttributes)
		{
			return vtkEdgeTable.vtkEdgeTable_InitEdgeInsertion_03(base.GetCppThis(), numPoints, storeAttributes);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkEdgeTable_InitPointInsertion_04(HandleRef pThis, HandleRef newPts, long estSize);

		public int InitPointInsertion(vtkPoints newPts, long estSize)
		{
			return vtkEdgeTable.vtkEdgeTable_InitPointInsertion_04(base.GetCppThis(), (newPts == null) ? default(HandleRef) : newPts.GetCppThis(), estSize);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkEdgeTable_InitTraversal_05(HandleRef pThis);

		public void InitTraversal()
		{
			vtkEdgeTable.vtkEdgeTable_InitTraversal_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkEdgeTable_Initialize_06(HandleRef pThis);

		public void Initialize()
		{
			vtkEdgeTable.vtkEdgeTable_Initialize_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkEdgeTable_InsertEdge_07(HandleRef pThis, long p1, long p2);

		public long InsertEdge(long p1, long p2)
		{
			return vtkEdgeTable.vtkEdgeTable_InsertEdge_07(base.GetCppThis(), p1, p2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkEdgeTable_InsertEdge_08(HandleRef pThis, long p1, long p2, long attributeId);

		public void InsertEdge(long p1, long p2, long attributeId)
		{
			vtkEdgeTable.vtkEdgeTable_InsertEdge_08(base.GetCppThis(), p1, p2, attributeId);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkEdgeTable_InsertEdge_09(HandleRef pThis, long p1, long p2, IntPtr ptr);

		public void InsertEdge(long p1, long p2, IntPtr ptr)
		{
			vtkEdgeTable.vtkEdgeTable_InsertEdge_09(base.GetCppThis(), p1, p2, ptr);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkEdgeTable_InsertUniquePoint_10(HandleRef pThis, long p1, long p2, IntPtr x, ref long ptId);

		public int InsertUniquePoint(long p1, long p2, IntPtr x, ref long ptId)
		{
			return vtkEdgeTable.vtkEdgeTable_InsertUniquePoint_10(base.GetCppThis(), p1, p2, x, ref ptId);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkEdgeTable_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEdgeTable.vtkEdgeTable_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkEdgeTable_IsEdge_12(HandleRef pThis, long p1, long p2);

		public long IsEdge(long p1, long p2)
		{
			return vtkEdgeTable.vtkEdgeTable_IsEdge_12(base.GetCppThis(), p1, p2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkEdgeTable_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEdgeTable.vtkEdgeTable_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeTable_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEdgeTable NewInstance()
		{
			vtkEdgeTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgeTable.vtkEdgeTable_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkEdgeTable_Reset_16(HandleRef pThis);

		public void Reset()
		{
			vtkEdgeTable.vtkEdgeTable_Reset_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeTable_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEdgeTable SafeDownCast(vtkObjectBase o)
		{
			vtkEdgeTable vtkEdgeTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgeTable.vtkEdgeTable_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgeTable = (vtkEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgeTable.Register(null);
				}
			}
			return vtkEdgeTable;
		}
	}
}

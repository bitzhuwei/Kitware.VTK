using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredData : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredData";

		public new static readonly string MRClassNameKey;

		static vtkStructuredData()
		{
			vtkStructuredData.MRClassNameKey = "class vtkStructuredData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredData"));
		}

		public vtkStructuredData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkStructuredData_ComputeCellId_01(IntPtr dim, IntPtr ijk);

		public static long ComputeCellId(IntPtr dim, IntPtr ijk)
		{
			return vtkStructuredData.vtkStructuredData_ComputeCellId_01(dim, ijk);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkStructuredData_ComputeCellIdForExtent_02(IntPtr extent, IntPtr ijk);

		public static long ComputeCellIdForExtent(IntPtr extent, IntPtr ijk)
		{
			return vtkStructuredData.vtkStructuredData_ComputeCellIdForExtent_02(extent, ijk);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkStructuredData_ComputePointId_03(IntPtr dim, IntPtr ijk);

		public static long ComputePointId(IntPtr dim, IntPtr ijk)
		{
			return vtkStructuredData.vtkStructuredData_ComputePointId_03(dim, ijk);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkStructuredData_ComputePointIdForExtent_04(IntPtr extent, IntPtr ijk);

		public static long ComputePointIdForExtent(IntPtr extent, IntPtr ijk)
		{
			return vtkStructuredData.vtkStructuredData_ComputePointIdForExtent_04(extent, ijk);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStructuredData_GetCellNeighbors_05(long cellId, HandleRef ptIds, HandleRef cellIds, IntPtr dim);

		public static void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds, IntPtr dim)
		{
			vtkStructuredData.vtkStructuredData_GetCellNeighbors_05(cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStructuredData_GetCellPoints_06(long cellId, HandleRef ptIds, int dataDescription, IntPtr dim);

		public static void GetCellPoints(long cellId, vtkIdList ptIds, int dataDescription, IntPtr dim)
		{
			vtkStructuredData.vtkStructuredData_GetCellPoints_06(cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), dataDescription, dim);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStructuredData_GetDataDescription_07(IntPtr dims);

		public static int GetDataDescription(IntPtr dims)
		{
			return vtkStructuredData.vtkStructuredData_GetDataDescription_07(dims);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStructuredData_GetDataDimension_08(int dataDescription);

		public static int GetDataDimension(int dataDescription)
		{
			return vtkStructuredData.vtkStructuredData_GetDataDimension_08(dataDescription);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStructuredData_GetPointCells_09(long ptId, HandleRef cellIds, IntPtr dim);

		public static void GetPointCells(long ptId, vtkIdList cellIds, IntPtr dim)
		{
			vtkStructuredData.vtkStructuredData_GetPointCells_09(ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStructuredData_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredData.vtkStructuredData_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStructuredData_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredData.vtkStructuredData_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredData_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredData NewInstance()
		{
			vtkStructuredData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredData.vtkStructuredData_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredData_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredData SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredData vtkStructuredData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredData.vtkStructuredData_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredData = (vtkStructuredData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredData.Register(null);
				}
			}
			return vtkStructuredData;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStructuredData_SetDimensions_14(IntPtr inDim, IntPtr dim);

		public static int SetDimensions(IntPtr inDim, IntPtr dim)
		{
			return vtkStructuredData.vtkStructuredData_SetDimensions_14(inDim, dim);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStructuredData_SetExtent_15(IntPtr inExt, IntPtr ext);

		public static int SetExtent(IntPtr inExt, IntPtr ext)
		{
			return vtkStructuredData.vtkStructuredData_SetExtent_15(inExt, ext);
		}
	}
}

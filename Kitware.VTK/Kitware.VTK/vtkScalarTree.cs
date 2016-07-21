using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkScalarTree : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkScalarTree";

		public new static readonly string MRClassNameKey;

		static vtkScalarTree()
		{
			vtkScalarTree.MRClassNameKey = "class vtkScalarTree";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScalarTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarTree"));
		}

		public vtkScalarTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkScalarTree_BuildTree_01(HandleRef pThis);

		public virtual void BuildTree()
		{
			vtkScalarTree.vtkScalarTree_BuildTree_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarTree_GetDataSet_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSet GetDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarTree.vtkScalarTree_GetDataSet_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarTree_GetNextCell_03(HandleRef pThis, ref long cellId, HandleRef ptIds, HandleRef cellScalars, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCell GetNextCell(ref long cellId, vtkIdList ptIds, vtkDataArray cellScalars)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarTree.vtkScalarTree_GetNextCell_03(base.GetCppThis(), ref cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkScalarTree_InitTraversal_04(HandleRef pThis, double scalarValue);

		public virtual void InitTraversal(double scalarValue)
		{
			vtkScalarTree.vtkScalarTree_InitTraversal_04(base.GetCppThis(), scalarValue);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkScalarTree_Initialize_05(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkScalarTree.vtkScalarTree_Initialize_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkScalarTree_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkScalarTree.vtkScalarTree_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkScalarTree_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkScalarTree.vtkScalarTree_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarTree_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkScalarTree NewInstance()
		{
			vtkScalarTree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarTree.vtkScalarTree_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarTree_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkScalarTree SafeDownCast(vtkObjectBase o)
		{
			vtkScalarTree vtkScalarTree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarTree.vtkScalarTree_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarTree = (vtkScalarTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarTree.Register(null);
				}
			}
			return vtkScalarTree;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkScalarTree_SetDataSet_10(HandleRef pThis, HandleRef arg0);

		public virtual void SetDataSet(vtkDataSet arg0)
		{
			vtkScalarTree.vtkScalarTree_SetDataSet_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}

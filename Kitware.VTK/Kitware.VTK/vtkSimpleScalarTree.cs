using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSimpleScalarTree : vtkScalarTree
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleScalarTree";

		public new static readonly string MRClassNameKey;

		static vtkSimpleScalarTree()
		{
			vtkSimpleScalarTree.MRClassNameKey = "class vtkSimpleScalarTree";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimpleScalarTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleScalarTree"));
		}

		public vtkSimpleScalarTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleScalarTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSimpleScalarTree New()
		{
			vtkSimpleScalarTree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleScalarTree.vtkSimpleScalarTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleScalarTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSimpleScalarTree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSimpleScalarTree.vtkSimpleScalarTree_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSimpleScalarTree_BuildTree_01(HandleRef pThis);

		public override void BuildTree()
		{
			vtkSimpleScalarTree.vtkSimpleScalarTree_BuildTree_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleScalarTree_GetBranchingFactor_02(HandleRef pThis);

		public virtual int GetBranchingFactor()
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetBranchingFactor_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleScalarTree_GetBranchingFactorMaxValue_03(HandleRef pThis);

		public virtual int GetBranchingFactorMaxValue()
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetBranchingFactorMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleScalarTree_GetBranchingFactorMinValue_04(HandleRef pThis);

		public virtual int GetBranchingFactorMinValue()
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetBranchingFactorMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleScalarTree_GetLevel_05(HandleRef pThis);

		public virtual int GetLevel()
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetLevel_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleScalarTree_GetMaxLevel_06(HandleRef pThis);

		public virtual int GetMaxLevel()
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetMaxLevel_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleScalarTree_GetMaxLevelMaxValue_07(HandleRef pThis);

		public virtual int GetMaxLevelMaxValue()
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetMaxLevelMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleScalarTree_GetMaxLevelMinValue_08(HandleRef pThis);

		public virtual int GetMaxLevelMinValue()
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_GetMaxLevelMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleScalarTree_GetNextCell_09(HandleRef pThis, ref long cellId, HandleRef ptIds, HandleRef cellScalars, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetNextCell(ref long cellId, vtkIdList ptIds, vtkDataArray cellScalars)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleScalarTree.vtkSimpleScalarTree_GetNextCell_09(base.GetCppThis(), ref cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkSimpleScalarTree_InitTraversal_10(HandleRef pThis, double scalarValue);

		public override void InitTraversal(double scalarValue)
		{
			vtkSimpleScalarTree.vtkSimpleScalarTree_InitTraversal_10(base.GetCppThis(), scalarValue);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSimpleScalarTree_Initialize_11(HandleRef pThis);

		public override void Initialize()
		{
			vtkSimpleScalarTree.vtkSimpleScalarTree_Initialize_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleScalarTree_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleScalarTree_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSimpleScalarTree.vtkSimpleScalarTree_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleScalarTree_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSimpleScalarTree NewInstance()
		{
			vtkSimpleScalarTree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleScalarTree.vtkSimpleScalarTree_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleScalarTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleScalarTree_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSimpleScalarTree SafeDownCast(vtkObjectBase o)
		{
			vtkSimpleScalarTree vtkSimpleScalarTree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleScalarTree.vtkSimpleScalarTree_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimpleScalarTree = (vtkSimpleScalarTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimpleScalarTree.Register(null);
				}
			}
			return vtkSimpleScalarTree;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSimpleScalarTree_SetBranchingFactor_17(HandleRef pThis, int _arg);

		public virtual void SetBranchingFactor(int _arg)
		{
			vtkSimpleScalarTree.vtkSimpleScalarTree_SetBranchingFactor_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSimpleScalarTree_SetMaxLevel_18(HandleRef pThis, int _arg);

		public virtual void SetMaxLevel(int _arg)
		{
			vtkSimpleScalarTree.vtkSimpleScalarTree_SetMaxLevel_18(base.GetCppThis(), _arg);
		}
	}
}

using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHierarchicalBoxDataSet : vtkCompositeDataSet
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalBoxDataSet";

		public new static readonly string MRClassNameKey;

		static vtkHierarchicalBoxDataSet()
		{
			vtkHierarchicalBoxDataSet.MRClassNameKey = "class vtkHierarchicalBoxDataSet";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalBoxDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalBoxDataSet"));
		}

		public vtkHierarchicalBoxDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalBoxDataSet New()
		{
			vtkHierarchicalBoxDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHierarchicalBoxDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_BOX_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerVectorKey BOX()
		{
			vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_BOX_01(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerVectorKey = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerVectorKey.Register(null);
				}
			}
			return vtkInformationIntegerVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_BOX_DIMENSIONALITY_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey BOX_DIMENSIONALITY()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_BOX_DIMENSIONALITY_02(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHierarchicalBoxDataSet_GenerateVisibilityArrays_03(HandleRef pThis);

		public void GenerateVisibilityArrays()
		{
			vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GenerateVisibilityArrays_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_GetData_04(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalBoxDataSet GetData(vtkInformation info)
		{
			vtkHierarchicalBoxDataSet vtkHierarchicalBoxDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetData_04((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBoxDataSet = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBoxDataSet.Register(null);
				}
			}
			return vtkHierarchicalBoxDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_GetData_05(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalBoxDataSet GetData(vtkInformationVector v, int i)
		{
			vtkHierarchicalBoxDataSet vtkHierarchicalBoxDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetData_05((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBoxDataSet = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBoxDataSet.Register(null);
				}
			}
			return vtkHierarchicalBoxDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHierarchicalBoxDataSet_GetDataObjectType_06(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetDataObjectType_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_GetDataSet_07(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkDataObject GetDataSet(vtkCompositeDataIterator iter)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetDataSet_07(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkHierarchicalBoxDataSet_GetFlatIndex_08(HandleRef pThis, uint level, uint index);

		public uint GetFlatIndex(uint level, uint index)
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetFlatIndex_08(base.GetCppThis(), level, index);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_GetLevelMetaData_09(HandleRef pThis, uint level, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformation GetLevelMetaData(uint level)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetLevelMetaData_09(base.GetCppThis(), level, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_GetMetaData_10(HandleRef pThis, uint level, uint index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformation GetMetaData(uint level, uint index)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetMetaData_10(base.GetCppThis(), level, index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_GetMetaData_11(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkInformation GetMetaData(vtkCompositeDataIterator iter)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetMetaData_11(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkHierarchicalBoxDataSet_GetNumberOfDataSets_12(HandleRef pThis, uint level);

		public uint GetNumberOfDataSets(uint level)
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetNumberOfDataSets_12(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkHierarchicalBoxDataSet_GetNumberOfLevels_13(HandleRef pThis);

		public uint GetNumberOfLevels()
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetNumberOfLevels_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHierarchicalBoxDataSet_GetRefinementRatio_14(HandleRef pThis, uint level);

		public int GetRefinementRatio(uint level)
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetRefinementRatio_14(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHierarchicalBoxDataSet_GetRefinementRatio_15(HandleRef pThis, HandleRef iter);

		public int GetRefinementRatio(vtkCompositeDataIterator iter)
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetRefinementRatio_15(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHierarchicalBoxDataSet_GetScalarRange_16(HandleRef pThis, IntPtr range);

		public virtual void GetScalarRange(IntPtr range)
		{
			vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetScalarRange_16(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_GetScalarRange_17(HandleRef pThis);

		public virtual IntPtr GetScalarRange()
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_GetScalarRange_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHierarchicalBoxDataSet_HasLevelMetaData_18(HandleRef pThis, uint level);

		public int HasLevelMetaData(uint level)
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_HasLevelMetaData_18(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHierarchicalBoxDataSet_HasMetaData_19(HandleRef pThis, uint level, uint index);

		public int HasMetaData(uint level, uint index)
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_HasMetaData_19(base.GetCppThis(), level, index);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHierarchicalBoxDataSet_HasMetaData_20(HandleRef pThis, HandleRef iter);

		public override int HasMetaData(vtkCompositeDataIterator iter)
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_HasMetaData_20(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHierarchicalBoxDataSet_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHierarchicalBoxDataSet_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_NUMBER_OF_BLANKED_POINTS_23(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIdTypeKey NUMBER_OF_BLANKED_POINTS()
		{
			vtkInformationIdTypeKey vtkInformationIdTypeKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_NUMBER_OF_BLANKED_POINTS_23(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIdTypeKey = (vtkInformationIdTypeKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIdTypeKey.Register(null);
				}
			}
			return vtkInformationIdTypeKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHierarchicalBoxDataSet NewInstance()
		{
			vtkHierarchicalBoxDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_NewIterator_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCompositeDataIterator NewIterator()
		{
			vtkCompositeDataIterator vtkCompositeDataIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_NewIterator_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataIterator = (vtkCompositeDataIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataIterator.Register(null);
				}
			}
			return vtkCompositeDataIterator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_REFINEMENT_RATIO_27(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey REFINEMENT_RATIO()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_REFINEMENT_RATIO_27(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalBoxDataSet_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalBoxDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalBoxDataSet vtkHierarchicalBoxDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBoxDataSet = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBoxDataSet.Register(null);
				}
			}
			return vtkHierarchicalBoxDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHierarchicalBoxDataSet_SetDataSet_29(HandleRef pThis, HandleRef iter, HandleRef dataObj);

		public override void SetDataSet(vtkCompositeDataIterator iter, vtkDataObject dataObj)
		{
			vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_SetDataSet_29(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), (dataObj == null) ? default(HandleRef) : dataObj.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHierarchicalBoxDataSet_SetDataSet_30(HandleRef pThis, uint level, uint id, IntPtr LoCorner, IntPtr HiCorner, HandleRef dataSet);

		public void SetDataSet(uint level, uint id, IntPtr LoCorner, IntPtr HiCorner, vtkUniformGrid dataSet)
		{
			vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_SetDataSet_30(base.GetCppThis(), level, id, LoCorner, HiCorner, (dataSet == null) ? default(HandleRef) : dataSet.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHierarchicalBoxDataSet_SetNumberOfDataSets_31(HandleRef pThis, uint level, uint numdatasets);

		public void SetNumberOfDataSets(uint level, uint numdatasets)
		{
			vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_SetNumberOfDataSets_31(base.GetCppThis(), level, numdatasets);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHierarchicalBoxDataSet_SetNumberOfLevels_32(HandleRef pThis, uint numLevels);

		public void SetNumberOfLevels(uint numLevels)
		{
			vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_SetNumberOfLevels_32(base.GetCppThis(), numLevels);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHierarchicalBoxDataSet_SetRefinementRatio_33(HandleRef pThis, uint level, int refRatio);

		public void SetRefinementRatio(uint level, int refRatio)
		{
			vtkHierarchicalBoxDataSet.vtkHierarchicalBoxDataSet_SetRefinementRatio_33(base.GetCppThis(), level, refRatio);
		}
	}
}

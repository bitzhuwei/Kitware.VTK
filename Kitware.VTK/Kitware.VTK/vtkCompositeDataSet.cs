using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCompositeDataSet : vtkDataObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataSet";

		public new static readonly string MRClassNameKey;

		static vtkCompositeDataSet()
		{
			vtkCompositeDataSet.MRClassNameKey = "class vtkCompositeDataSet";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataSet"));
		}

		public vtkCompositeDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataSet_CopyStructure_01(HandleRef pThis, HandleRef input);

		public virtual void CopyStructure(vtkCompositeDataSet input)
		{
			vtkCompositeDataSet.vtkCompositeDataSet_CopyStructure_01(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataSet_DeepCopy_02(HandleRef pThis, HandleRef src);

		public override void DeepCopy(vtkDataObject src)
		{
			vtkCompositeDataSet.vtkCompositeDataSet_DeepCopy_02(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkCompositeDataSet_GetActualMemorySize_03(HandleRef pThis);

		public override uint GetActualMemorySize()
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_GetActualMemorySize_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataSet_GetData_04(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositeDataSet GetData(vtkInformation info)
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_GetData_04((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataSet_GetData_05(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositeDataSet GetData(vtkInformationVector v, int i)
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_GetData_05((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCompositeDataSet_GetDataObjectType_06(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_GetDataObjectType_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataSet_GetDataSet_07(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataObject GetDataSet(vtkCompositeDataIterator iter)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_GetDataSet_07(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkCompositeDataSet_GetMetaData_08(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInformation GetMetaData(vtkCompositeDataIterator iter)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_GetMetaData_08(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern long vtkCompositeDataSet_GetNumberOfPoints_09(HandleRef pThis);

		public virtual long GetNumberOfPoints()
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_GetNumberOfPoints_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataSet_GetProducerPort_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAlgorithmOutput GetProducerPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_GetProducerPort_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCompositeDataSet_HasMetaData_11(HandleRef pThis, HandleRef iter);

		public virtual int HasMetaData(vtkCompositeDataIterator iter)
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_HasMetaData_11(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataSet_Initialize_12(HandleRef pThis);

		public override void Initialize()
		{
			vtkCompositeDataSet.vtkCompositeDataSet_Initialize_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCompositeDataSet_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCompositeDataSet_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCompositeDataSet.vtkCompositeDataSet_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataSet_NAME_15(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationStringKey NAME()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_NAME_15(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataSet_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCompositeDataSet NewInstance()
		{
			vtkCompositeDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataSet_NewIterator_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCompositeDataIterator NewIterator()
		{
			vtkCompositeDataIterator vtkCompositeDataIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_NewIterator_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkCompositeDataSet_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositeDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataSet.vtkCompositeDataSet_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataSet_SetDataSet_19(HandleRef pThis, HandleRef iter, HandleRef dataObj);

		public virtual void SetDataSet(vtkCompositeDataIterator iter, vtkDataObject dataObj)
		{
			vtkCompositeDataSet.vtkCompositeDataSet_SetDataSet_19(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), (dataObj == null) ? default(HandleRef) : dataObj.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataSet_ShallowCopy_20(HandleRef pThis, HandleRef src);

		public override void ShallowCopy(vtkDataObject src)
		{
			vtkCompositeDataSet.vtkCompositeDataSet_ShallowCopy_20(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}
	}
}

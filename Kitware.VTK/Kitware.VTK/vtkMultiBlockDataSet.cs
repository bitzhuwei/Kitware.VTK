using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMultiBlockDataSet : vtkCompositeDataSet
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiBlockDataSet";

		public new static readonly string MRClassNameKey;

		static vtkMultiBlockDataSet()
		{
			vtkMultiBlockDataSet.MRClassNameKey = "class vtkMultiBlockDataSet";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiBlockDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiBlockDataSet"));
		}

		public vtkMultiBlockDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiBlockDataSet New()
		{
			vtkMultiBlockDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMultiBlockDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMultiBlockDataSet.vtkMultiBlockDataSet_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockDataSet_GetBlock_01(HandleRef pThis, uint blockno, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetBlock(uint blockno)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetBlock_01(base.GetCppThis(), blockno, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkMultiBlockDataSet_GetData_02(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiBlockDataSet GetData(vtkInformation info)
		{
			vtkMultiBlockDataSet vtkMultiBlockDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetData_02((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockDataSet = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockDataSet.Register(null);
				}
			}
			return vtkMultiBlockDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockDataSet_GetData_03(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiBlockDataSet GetData(vtkInformationVector v, int i)
		{
			vtkMultiBlockDataSet vtkMultiBlockDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetData_03((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockDataSet = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockDataSet.Register(null);
				}
			}
			return vtkMultiBlockDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMultiBlockDataSet_GetDataObjectType_04(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetDataObjectType_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockDataSet_GetMetaData_05(HandleRef pThis, uint blockno, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformation GetMetaData(uint blockno)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetMetaData_05(base.GetCppThis(), blockno, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkMultiBlockDataSet_GetMetaData_06(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkInformation GetMetaData(vtkCompositeDataIterator iter)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetMetaData_06(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkMultiBlockDataSet_GetNumberOfBlocks_07(HandleRef pThis);

		public uint GetNumberOfBlocks()
		{
			return vtkMultiBlockDataSet.vtkMultiBlockDataSet_GetNumberOfBlocks_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMultiBlockDataSet_HasMetaData_08(HandleRef pThis, uint blockno);

		public int HasMetaData(uint blockno)
		{
			return vtkMultiBlockDataSet.vtkMultiBlockDataSet_HasMetaData_08(base.GetCppThis(), blockno);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMultiBlockDataSet_HasMetaData_09(HandleRef pThis, HandleRef iter);

		public override int HasMetaData(vtkCompositeDataIterator iter)
		{
			return vtkMultiBlockDataSet.vtkMultiBlockDataSet_HasMetaData_09(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMultiBlockDataSet_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMultiBlockDataSet.vtkMultiBlockDataSet_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMultiBlockDataSet_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMultiBlockDataSet.vtkMultiBlockDataSet_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockDataSet_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMultiBlockDataSet NewInstance()
		{
			vtkMultiBlockDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMultiBlockDataSet_RemoveBlock_14(HandleRef pThis, uint blockno);

		public void RemoveBlock(uint blockno)
		{
			vtkMultiBlockDataSet.vtkMultiBlockDataSet_RemoveBlock_14(base.GetCppThis(), blockno);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockDataSet_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiBlockDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkMultiBlockDataSet vtkMultiBlockDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockDataSet.vtkMultiBlockDataSet_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockDataSet = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockDataSet.Register(null);
				}
			}
			return vtkMultiBlockDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMultiBlockDataSet_SetBlock_16(HandleRef pThis, uint blockno, HandleRef block);

		public void SetBlock(uint blockno, vtkDataObject block)
		{
			vtkMultiBlockDataSet.vtkMultiBlockDataSet_SetBlock_16(base.GetCppThis(), blockno, (block == null) ? default(HandleRef) : block.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMultiBlockDataSet_SetNumberOfBlocks_17(HandleRef pThis, uint numBlocks);

		public void SetNumberOfBlocks(uint numBlocks)
		{
			vtkMultiBlockDataSet.vtkMultiBlockDataSet_SetNumberOfBlocks_17(base.GetCppThis(), numBlocks);
		}
	}
}

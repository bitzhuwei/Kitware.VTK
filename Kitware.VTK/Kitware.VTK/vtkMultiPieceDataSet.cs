using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMultiPieceDataSet : vtkCompositeDataSet
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiPieceDataSet";

		public new static readonly string MRClassNameKey;

		static vtkMultiPieceDataSet()
		{
			vtkMultiPieceDataSet.MRClassNameKey = "class vtkMultiPieceDataSet";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiPieceDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiPieceDataSet"));
		}

		public vtkMultiPieceDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiPieceDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiPieceDataSet New()
		{
			vtkMultiPieceDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiPieceDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMultiPieceDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMultiPieceDataSet.vtkMultiPieceDataSet_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiPieceDataSet_GetData_01(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiPieceDataSet GetData(vtkInformation info)
		{
			vtkMultiPieceDataSet vtkMultiPieceDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetData_01((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiPieceDataSet = (vtkMultiPieceDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiPieceDataSet.Register(null);
				}
			}
			return vtkMultiPieceDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiPieceDataSet_GetData_02(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiPieceDataSet GetData(vtkInformationVector v, int i)
		{
			vtkMultiPieceDataSet vtkMultiPieceDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetData_02((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiPieceDataSet = (vtkMultiPieceDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiPieceDataSet.Register(null);
				}
			}
			return vtkMultiPieceDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMultiPieceDataSet_GetDataObjectType_03(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetDataObjectType_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiPieceDataSet_GetMetaData_04(HandleRef pThis, uint pieceno, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformation GetMetaData(uint pieceno)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetMetaData_04(base.GetCppThis(), pieceno, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkMultiPieceDataSet_GetMetaData_05(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkInformation GetMetaData(vtkCompositeDataIterator iter)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetMetaData_05(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkMultiPieceDataSet_GetNumberOfPieces_06(HandleRef pThis);

		public uint GetNumberOfPieces()
		{
			return vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetNumberOfPieces_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiPieceDataSet_GetPiece_07(HandleRef pThis, uint pieceno, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetPiece(uint pieceno)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetPiece_07(base.GetCppThis(), pieceno, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkMultiPieceDataSet_GetPieceAsDataObject_08(HandleRef pThis, uint pieceno, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetPieceAsDataObject(uint pieceno)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_GetPieceAsDataObject_08(base.GetCppThis(), pieceno, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkMultiPieceDataSet_HasMetaData_09(HandleRef pThis, uint piece);

		public int HasMetaData(uint piece)
		{
			return vtkMultiPieceDataSet.vtkMultiPieceDataSet_HasMetaData_09(base.GetCppThis(), piece);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMultiPieceDataSet_HasMetaData_10(HandleRef pThis, HandleRef iter);

		public override int HasMetaData(vtkCompositeDataIterator iter)
		{
			return vtkMultiPieceDataSet.vtkMultiPieceDataSet_HasMetaData_10(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMultiPieceDataSet_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMultiPieceDataSet.vtkMultiPieceDataSet_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMultiPieceDataSet_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMultiPieceDataSet.vtkMultiPieceDataSet_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiPieceDataSet_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMultiPieceDataSet NewInstance()
		{
			vtkMultiPieceDataSet result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiPieceDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiPieceDataSet_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiPieceDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkMultiPieceDataSet vtkMultiPieceDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiPieceDataSet.vtkMultiPieceDataSet_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiPieceDataSet = (vtkMultiPieceDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiPieceDataSet.Register(null);
				}
			}
			return vtkMultiPieceDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMultiPieceDataSet_SetNumberOfPieces_16(HandleRef pThis, uint numpieces);

		public void SetNumberOfPieces(uint numpieces)
		{
			vtkMultiPieceDataSet.vtkMultiPieceDataSet_SetNumberOfPieces_16(base.GetCppThis(), numpieces);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMultiPieceDataSet_SetPiece_17(HandleRef pThis, uint pieceno, HandleRef piece);

		public void SetPiece(uint pieceno, vtkDataObject piece)
		{
			vtkMultiPieceDataSet.vtkMultiPieceDataSet_SetPiece_17(base.GetCppThis(), pieceno, (piece == null) ? default(HandleRef) : piece.GetCppThis());
		}
	}
}

using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAVSucdReader : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAVSucdReader";

		public new static readonly string MRClassNameKey;

		static vtkAVSucdReader()
		{
			vtkAVSucdReader.MRClassNameKey = "class vtkAVSucdReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAVSucdReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAVSucdReader"));
		}

		public vtkAVSucdReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkAVSucdReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAVSucdReader New()
		{
			vtkAVSucdReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAVSucdReader.vtkAVSucdReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAVSucdReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAVSucdReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAVSucdReader.vtkAVSucdReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVSucdReader_BinaryFileOff_01(HandleRef pThis);

		public virtual void BinaryFileOff()
		{
			vtkAVSucdReader.vtkAVSucdReader_BinaryFileOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVSucdReader_BinaryFileOn_02(HandleRef pThis);

		public virtual void BinaryFileOn()
		{
			vtkAVSucdReader.vtkAVSucdReader_BinaryFileOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVSucdReader_DisableAllCellArrays_03(HandleRef pThis);

		public void DisableAllCellArrays()
		{
			vtkAVSucdReader.vtkAVSucdReader_DisableAllCellArrays_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVSucdReader_DisableAllPointArrays_04(HandleRef pThis);

		public void DisableAllPointArrays()
		{
			vtkAVSucdReader.vtkAVSucdReader_DisableAllPointArrays_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVSucdReader_EnableAllCellArrays_05(HandleRef pThis);

		public void EnableAllCellArrays()
		{
			vtkAVSucdReader.vtkAVSucdReader_EnableAllCellArrays_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVSucdReader_EnableAllPointArrays_06(HandleRef pThis);

		public void EnableAllPointArrays()
		{
			vtkAVSucdReader.vtkAVSucdReader_EnableAllPointArrays_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVSucdReader_GetBinaryFile_07(HandleRef pThis);

		public virtual int GetBinaryFile()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetBinaryFile_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVSucdReader_GetByteOrder_08(HandleRef pThis);

		public virtual int GetByteOrder()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetByteOrder_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkAVSucdReader_GetByteOrderAsString_09(HandleRef pThis);

		public string GetByteOrderAsString()
		{
			return Marshal.PtrToStringAnsi(vtkAVSucdReader.vtkAVSucdReader_GetByteOrderAsString_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkAVSucdReader_GetCellArrayName_10(HandleRef pThis, int index);

		public string GetCellArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkAVSucdReader.vtkAVSucdReader_GetCellArrayName_10(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVSucdReader_GetCellArrayStatus_11(HandleRef pThis, string name);

		public int GetCellArrayStatus(string name)
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetCellArrayStatus_11(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVSucdReader_GetCellDataRange_12(HandleRef pThis, int cellComp, int index, IntPtr min, IntPtr max);

		public void GetCellDataRange(int cellComp, int index, IntPtr min, IntPtr max)
		{
			vtkAVSucdReader.vtkAVSucdReader_GetCellDataRange_12(base.GetCppThis(), cellComp, index, min, max);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkAVSucdReader_GetFileName_13(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkAVSucdReader.vtkAVSucdReader_GetFileName_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVSucdReader_GetNodeDataRange_14(HandleRef pThis, int nodeComp, int index, IntPtr min, IntPtr max);

		public void GetNodeDataRange(int nodeComp, int index, IntPtr min, IntPtr max)
		{
			vtkAVSucdReader.vtkAVSucdReader_GetNodeDataRange_14(base.GetCppThis(), nodeComp, index, min, max);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVSucdReader_GetNumberOfCellArrays_15(HandleRef pThis);

		public int GetNumberOfCellArrays()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfCellArrays_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVSucdReader_GetNumberOfCellComponents_16(HandleRef pThis);

		public virtual int GetNumberOfCellComponents()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfCellComponents_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVSucdReader_GetNumberOfCellFields_17(HandleRef pThis);

		public virtual int GetNumberOfCellFields()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfCellFields_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVSucdReader_GetNumberOfCells_18(HandleRef pThis);

		public virtual int GetNumberOfCells()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfCells_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVSucdReader_GetNumberOfFields_19(HandleRef pThis);

		public virtual int GetNumberOfFields()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfFields_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVSucdReader_GetNumberOfNodeComponents_20(HandleRef pThis);

		public virtual int GetNumberOfNodeComponents()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfNodeComponents_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVSucdReader_GetNumberOfNodeFields_21(HandleRef pThis);

		public virtual int GetNumberOfNodeFields()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfNodeFields_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVSucdReader_GetNumberOfNodes_22(HandleRef pThis);

		public virtual int GetNumberOfNodes()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfNodes_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVSucdReader_GetNumberOfPointArrays_23(HandleRef pThis);

		public int GetNumberOfPointArrays()
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetNumberOfPointArrays_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkAVSucdReader_GetPointArrayName_24(HandleRef pThis, int index);

		public string GetPointArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkAVSucdReader.vtkAVSucdReader_GetPointArrayName_24(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVSucdReader_GetPointArrayStatus_25(HandleRef pThis, string name);

		public int GetPointArrayStatus(string name)
		{
			return vtkAVSucdReader.vtkAVSucdReader_GetPointArrayStatus_25(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVSucdReader_IsA_26(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAVSucdReader.vtkAVSucdReader_IsA_26(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkAVSucdReader_IsTypeOf_27(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAVSucdReader.vtkAVSucdReader_IsTypeOf_27(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkAVSucdReader_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAVSucdReader NewInstance()
		{
			vtkAVSucdReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAVSucdReader.vtkAVSucdReader_NewInstance_29(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAVSucdReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkAVSucdReader_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAVSucdReader SafeDownCast(vtkObjectBase o)
		{
			vtkAVSucdReader vtkAVSucdReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAVSucdReader.vtkAVSucdReader_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAVSucdReader = (vtkAVSucdReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAVSucdReader.Register(null);
				}
			}
			return vtkAVSucdReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVSucdReader_SetBinaryFile_31(HandleRef pThis, int _arg);

		public virtual void SetBinaryFile(int _arg)
		{
			vtkAVSucdReader.vtkAVSucdReader_SetBinaryFile_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVSucdReader_SetByteOrder_32(HandleRef pThis, int _arg);

		public virtual void SetByteOrder(int _arg)
		{
			vtkAVSucdReader.vtkAVSucdReader_SetByteOrder_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVSucdReader_SetByteOrderToBigEndian_33(HandleRef pThis);

		public void SetByteOrderToBigEndian()
		{
			vtkAVSucdReader.vtkAVSucdReader_SetByteOrderToBigEndian_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVSucdReader_SetByteOrderToLittleEndian_34(HandleRef pThis);

		public void SetByteOrderToLittleEndian()
		{
			vtkAVSucdReader.vtkAVSucdReader_SetByteOrderToLittleEndian_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVSucdReader_SetCellArrayStatus_35(HandleRef pThis, string name, int status);

		public void SetCellArrayStatus(string name, int status)
		{
			vtkAVSucdReader.vtkAVSucdReader_SetCellArrayStatus_35(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVSucdReader_SetFileName_36(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkAVSucdReader.vtkAVSucdReader_SetFileName_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkAVSucdReader_SetPointArrayStatus_37(HandleRef pThis, string name, int status);

		public void SetPointArrayStatus(string name, int status)
		{
			vtkAVSucdReader.vtkAVSucdReader_SetPointArrayStatus_37(base.GetCppThis(), name, status);
		}
	}
}

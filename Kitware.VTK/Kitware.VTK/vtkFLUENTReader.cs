using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFLUENTReader : vtkMultiBlockDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFLUENTReader";

		public new static readonly string MRClassNameKey;

		static vtkFLUENTReader()
		{
			vtkFLUENTReader.MRClassNameKey = "class vtkFLUENTReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFLUENTReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFLUENTReader"));
		}

		public vtkFLUENTReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkFLUENTReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFLUENTReader New()
		{
			vtkFLUENTReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFLUENTReader.vtkFLUENTReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFLUENTReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFLUENTReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFLUENTReader.vtkFLUENTReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkFLUENTReader_DisableAllCellArrays_01(HandleRef pThis);

		public void DisableAllCellArrays()
		{
			vtkFLUENTReader.vtkFLUENTReader_DisableAllCellArrays_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkFLUENTReader_EnableAllCellArrays_02(HandleRef pThis);

		public void EnableAllCellArrays()
		{
			vtkFLUENTReader.vtkFLUENTReader_EnableAllCellArrays_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkFLUENTReader_GetCellArrayName_03(HandleRef pThis, int index);

		public string GetCellArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkFLUENTReader.vtkFLUENTReader_GetCellArrayName_03(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkFLUENTReader_GetCellArrayStatus_04(HandleRef pThis, string name);

		public int GetCellArrayStatus(string name)
		{
			return vtkFLUENTReader.vtkFLUENTReader_GetCellArrayStatus_04(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkFLUENTReader_GetDataByteOrder_05(HandleRef pThis);

		public int GetDataByteOrder()
		{
			return vtkFLUENTReader.vtkFLUENTReader_GetDataByteOrder_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkFLUENTReader_GetDataByteOrderAsString_06(HandleRef pThis);

		public string GetDataByteOrderAsString()
		{
			return Marshal.PtrToStringAnsi(vtkFLUENTReader.vtkFLUENTReader_GetDataByteOrderAsString_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkFLUENTReader_GetFileName_07(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkFLUENTReader.vtkFLUENTReader_GetFileName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkFLUENTReader_GetNumberOfCellArrays_08(HandleRef pThis);

		public int GetNumberOfCellArrays()
		{
			return vtkFLUENTReader.vtkFLUENTReader_GetNumberOfCellArrays_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkFLUENTReader_GetNumberOfCells_09(HandleRef pThis);

		public virtual int GetNumberOfCells()
		{
			return vtkFLUENTReader.vtkFLUENTReader_GetNumberOfCells_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkFLUENTReader_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFLUENTReader.vtkFLUENTReader_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkFLUENTReader_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFLUENTReader.vtkFLUENTReader_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkFLUENTReader_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFLUENTReader NewInstance()
		{
			vtkFLUENTReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFLUENTReader.vtkFLUENTReader_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFLUENTReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkFLUENTReader_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFLUENTReader SafeDownCast(vtkObjectBase o)
		{
			vtkFLUENTReader vtkFLUENTReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFLUENTReader.vtkFLUENTReader_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFLUENTReader = (vtkFLUENTReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFLUENTReader.Register(null);
				}
			}
			return vtkFLUENTReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkFLUENTReader_SetCellArrayStatus_15(HandleRef pThis, string name, int status);

		public void SetCellArrayStatus(string name, int status)
		{
			vtkFLUENTReader.vtkFLUENTReader_SetCellArrayStatus_15(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkFLUENTReader_SetDataByteOrder_16(HandleRef pThis, int arg0);

		public void SetDataByteOrder(int arg0)
		{
			vtkFLUENTReader.vtkFLUENTReader_SetDataByteOrder_16(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkFLUENTReader_SetDataByteOrderToBigEndian_17(HandleRef pThis);

		public void SetDataByteOrderToBigEndian()
		{
			vtkFLUENTReader.vtkFLUENTReader_SetDataByteOrderToBigEndian_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkFLUENTReader_SetDataByteOrderToLittleEndian_18(HandleRef pThis);

		public void SetDataByteOrderToLittleEndian()
		{
			vtkFLUENTReader.vtkFLUENTReader_SetDataByteOrderToLittleEndian_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkFLUENTReader_SetFileName_19(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkFLUENTReader.vtkFLUENTReader_SetFileName_19(base.GetCppThis(), _arg);
		}
	}
}

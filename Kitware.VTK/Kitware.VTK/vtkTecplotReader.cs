using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTecplotReader : vtkMultiBlockDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTecplotReader";

		public new static readonly string MRClassNameKey;

		static vtkTecplotReader()
		{
			vtkTecplotReader.MRClassNameKey = "class vtkTecplotReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTecplotReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTecplotReader"));
		}

		public vtkTecplotReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTecplotReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTecplotReader New()
		{
			vtkTecplotReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTecplotReader.vtkTecplotReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTecplotReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTecplotReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTecplotReader.vtkTecplotReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTecplotReader_GetBlockName_01(HandleRef pThis, int blockIdx);

		public string GetBlockName(int blockIdx)
		{
			return Marshal.PtrToStringAnsi(vtkTecplotReader.vtkTecplotReader_GetBlockName_01(base.GetCppThis(), blockIdx));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTecplotReader_GetDataArrayName_02(HandleRef pThis, int arrayIdx);

		public string GetDataArrayName(int arrayIdx)
		{
			return Marshal.PtrToStringAnsi(vtkTecplotReader.vtkTecplotReader_GetDataArrayName_02(base.GetCppThis(), arrayIdx));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTecplotReader_GetDataArrayStatus_03(HandleRef pThis, string arayName);

		public int GetDataArrayStatus(string arayName)
		{
			return vtkTecplotReader.vtkTecplotReader_GetDataArrayStatus_03(base.GetCppThis(), arayName);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTecplotReader_GetDataAttributeName_04(HandleRef pThis, int attrIndx);

		public string GetDataAttributeName(int attrIndx)
		{
			return Marshal.PtrToStringAnsi(vtkTecplotReader.vtkTecplotReader_GetDataAttributeName_04(base.GetCppThis(), attrIndx));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTecplotReader_GetDataTitle_05(HandleRef pThis);

		public string GetDataTitle()
		{
			return Marshal.PtrToStringAnsi(vtkTecplotReader.vtkTecplotReader_GetDataTitle_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTecplotReader_GetNumberOfBlocks_06(HandleRef pThis);

		public int GetNumberOfBlocks()
		{
			return vtkTecplotReader.vtkTecplotReader_GetNumberOfBlocks_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTecplotReader_GetNumberOfDataArrays_07(HandleRef pThis);

		public int GetNumberOfDataArrays()
		{
			return vtkTecplotReader.vtkTecplotReader_GetNumberOfDataArrays_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTecplotReader_GetNumberOfDataAttributes_08(HandleRef pThis);

		public int GetNumberOfDataAttributes()
		{
			return vtkTecplotReader.vtkTecplotReader_GetNumberOfDataAttributes_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTecplotReader_GetNumberOfVariables_09(HandleRef pThis);

		public virtual int GetNumberOfVariables()
		{
			return vtkTecplotReader.vtkTecplotReader_GetNumberOfVariables_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTecplotReader_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTecplotReader.vtkTecplotReader_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTecplotReader_IsDataAttributeCellBased_11(HandleRef pThis, string attrName);

		public int IsDataAttributeCellBased(string attrName)
		{
			return vtkTecplotReader.vtkTecplotReader_IsDataAttributeCellBased_11(base.GetCppThis(), attrName);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTecplotReader_IsDataAttributeCellBased_12(HandleRef pThis, int attrIndx);

		public int IsDataAttributeCellBased(int attrIndx)
		{
			return vtkTecplotReader.vtkTecplotReader_IsDataAttributeCellBased_12(base.GetCppThis(), attrIndx);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTecplotReader_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTecplotReader.vtkTecplotReader_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTecplotReader_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTecplotReader NewInstance()
		{
			vtkTecplotReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTecplotReader.vtkTecplotReader_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTecplotReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTecplotReader_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTecplotReader SafeDownCast(vtkObjectBase o)
		{
			vtkTecplotReader vtkTecplotReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTecplotReader.vtkTecplotReader_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTecplotReader = (vtkTecplotReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTecplotReader.Register(null);
				}
			}
			return vtkTecplotReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTecplotReader_SetDataArrayStatus_17(HandleRef pThis, string arayName, int bChecked);

		public void SetDataArrayStatus(string arayName, int bChecked)
		{
			vtkTecplotReader.vtkTecplotReader_SetDataArrayStatus_17(base.GetCppThis(), arayName, bChecked);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTecplotReader_SetFileName_18(HandleRef pThis, string fileName);

		public void SetFileName(string fileName)
		{
			vtkTecplotReader.vtkTecplotReader_SetFileName_18(base.GetCppThis(), fileName);
		}
	}
}

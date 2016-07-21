using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSESAMEReader : vtkRectilinearGridSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSESAMEReader";

		public new static readonly string MRClassNameKey;

		static vtkSESAMEReader()
		{
			vtkSESAMEReader.MRClassNameKey = "class vtkSESAMEReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSESAMEReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSESAMEReader"));
		}

		public vtkSESAMEReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSESAMEReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSESAMEReader New()
		{
			vtkSESAMEReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSESAMEReader.vtkSESAMEReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSESAMEReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSESAMEReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSESAMEReader.vtkSESAMEReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSESAMEReader_GetFileName_01(HandleRef pThis);

		public string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkSESAMEReader.vtkSESAMEReader_GetFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSESAMEReader_GetNumberOfTableArrayNames_02(HandleRef pThis);

		public int GetNumberOfTableArrayNames()
		{
			return vtkSESAMEReader.vtkSESAMEReader_GetNumberOfTableArrayNames_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSESAMEReader_GetNumberOfTableArrays_03(HandleRef pThis);

		public int GetNumberOfTableArrays()
		{
			return vtkSESAMEReader.vtkSESAMEReader_GetNumberOfTableArrays_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSESAMEReader_GetNumberOfTableIds_04(HandleRef pThis);

		public int GetNumberOfTableIds()
		{
			return vtkSESAMEReader.vtkSESAMEReader_GetNumberOfTableIds_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSESAMEReader_GetTable_05(HandleRef pThis);

		public int GetTable()
		{
			return vtkSESAMEReader.vtkSESAMEReader_GetTable_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSESAMEReader_GetTableArrayName_06(HandleRef pThis, int index);

		public string GetTableArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkSESAMEReader.vtkSESAMEReader_GetTableArrayName_06(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSESAMEReader_GetTableArrayStatus_07(HandleRef pThis, string name);

		public int GetTableArrayStatus(string name)
		{
			return vtkSESAMEReader.vtkSESAMEReader_GetTableArrayStatus_07(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSESAMEReader_GetTableIds_08(HandleRef pThis);

		public IntPtr GetTableIds()
		{
			return vtkSESAMEReader.vtkSESAMEReader_GetTableIds_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSESAMEReader_GetTableIdsAsArray_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIntArray GetTableIdsAsArray()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSESAMEReader.vtkSESAMEReader_GetTableIdsAsArray_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSESAMEReader_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSESAMEReader.vtkSESAMEReader_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSESAMEReader_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSESAMEReader.vtkSESAMEReader_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSESAMEReader_IsValidFile_12(HandleRef pThis);

		public int IsValidFile()
		{
			return vtkSESAMEReader.vtkSESAMEReader_IsValidFile_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSESAMEReader_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSESAMEReader NewInstance()
		{
			vtkSESAMEReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSESAMEReader.vtkSESAMEReader_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSESAMEReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSESAMEReader_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSESAMEReader SafeDownCast(vtkObjectBase o)
		{
			vtkSESAMEReader vtkSESAMEReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSESAMEReader.vtkSESAMEReader_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSESAMEReader = (vtkSESAMEReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSESAMEReader.Register(null);
				}
			}
			return vtkSESAMEReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSESAMEReader_SetFileName_16(HandleRef pThis, string file);

		public void SetFileName(string file)
		{
			vtkSESAMEReader.vtkSESAMEReader_SetFileName_16(base.GetCppThis(), file);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSESAMEReader_SetTable_17(HandleRef pThis, int tableId);

		public void SetTable(int tableId)
		{
			vtkSESAMEReader.vtkSESAMEReader_SetTable_17(base.GetCppThis(), tableId);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSESAMEReader_SetTableArrayStatus_18(HandleRef pThis, string name, int flag);

		public void SetTableArrayStatus(string name, int flag)
		{
			vtkSESAMEReader.vtkSESAMEReader_SetTableArrayStatus_18(base.GetCppThis(), name, flag);
		}
	}
}

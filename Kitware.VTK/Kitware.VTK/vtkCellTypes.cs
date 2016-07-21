using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCellTypes : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellTypes";

		public new static readonly string MRClassNameKey;

		static vtkCellTypes()
		{
			vtkCellTypes.MRClassNameKey = "class vtkCellTypes";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellTypes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellTypes"));
		}

		public vtkCellTypes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellTypes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellTypes New()
		{
			vtkCellTypes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellTypes.vtkCellTypes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellTypes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCellTypes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCellTypes.vtkCellTypes_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellTypes_Allocate_01(HandleRef pThis, int sz, int ext);

		public int Allocate(int sz, int ext)
		{
			return vtkCellTypes.vtkCellTypes_Allocate_01(base.GetCppThis(), sz, ext);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellTypes_DeepCopy_02(HandleRef pThis, HandleRef src);

		public void DeepCopy(vtkCellTypes src)
		{
			vtkCellTypes.vtkCellTypes_DeepCopy_02(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellTypes_DeleteCell_03(HandleRef pThis, long cellId);

		public void DeleteCell(long cellId)
		{
			vtkCellTypes.vtkCellTypes_DeleteCell_03(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkCellTypes_GetActualMemorySize_04(HandleRef pThis);

		public uint GetActualMemorySize()
		{
			return vtkCellTypes.vtkCellTypes_GetActualMemorySize_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellTypes_GetCellLocation_05(HandleRef pThis, int cellId);

		public int GetCellLocation(int cellId)
		{
			return vtkCellTypes.vtkCellTypes_GetCellLocation_05(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkCellTypes_GetCellType_06(HandleRef pThis, int cellId);

		public byte GetCellType(int cellId)
		{
			return vtkCellTypes.vtkCellTypes_GetCellType_06(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellTypes_GetClassNameFromTypeId_07(int typeId);

		public static string GetClassNameFromTypeId(int typeId)
		{
			return Marshal.PtrToStringAnsi(vtkCellTypes.vtkCellTypes_GetClassNameFromTypeId_07(typeId));
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellTypes_GetNumberOfTypes_08(HandleRef pThis);

		public int GetNumberOfTypes()
		{
			return vtkCellTypes.vtkCellTypes_GetNumberOfTypes_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellTypes_GetTypeIdFromClassName_09(string classname);

		public static int GetTypeIdFromClassName(string classname)
		{
			return vtkCellTypes.vtkCellTypes_GetTypeIdFromClassName_09(classname);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellTypes_InsertCell_10(HandleRef pThis, int id, byte type, int loc);

		public void InsertCell(int id, byte type, int loc)
		{
			vtkCellTypes.vtkCellTypes_InsertCell_10(base.GetCppThis(), id, type, loc);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellTypes_InsertNextCell_11(HandleRef pThis, byte type, int loc);

		public int InsertNextCell(byte type, int loc)
		{
			return vtkCellTypes.vtkCellTypes_InsertNextCell_11(base.GetCppThis(), type, loc);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellTypes_InsertNextType_12(HandleRef pThis, byte type);

		public int InsertNextType(byte type)
		{
			return vtkCellTypes.vtkCellTypes_InsertNextType_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellTypes_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCellTypes.vtkCellTypes_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellTypes_IsLinear_14(byte type);

		public static int IsLinear(byte type)
		{
			return vtkCellTypes.vtkCellTypes_IsLinear_14(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellTypes_IsType_15(HandleRef pThis, byte type);

		public int IsType(byte type)
		{
			return vtkCellTypes.vtkCellTypes_IsType_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellTypes_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCellTypes.vtkCellTypes_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellTypes_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCellTypes NewInstance()
		{
			vtkCellTypes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellTypes.vtkCellTypes_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellTypes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellTypes_Reset_19(HandleRef pThis);

		public void Reset()
		{
			vtkCellTypes.vtkCellTypes_Reset_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellTypes_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellTypes SafeDownCast(vtkObjectBase o)
		{
			vtkCellTypes vtkCellTypes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellTypes.vtkCellTypes_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellTypes = (vtkCellTypes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellTypes.Register(null);
				}
			}
			return vtkCellTypes;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellTypes_SetCellTypes_21(HandleRef pThis, int ncells, HandleRef cellTypes, HandleRef cellLocations);

		public void SetCellTypes(int ncells, vtkUnsignedCharArray cellTypes, vtkIntArray cellLocations)
		{
			vtkCellTypes.vtkCellTypes_SetCellTypes_21(base.GetCppThis(), ncells, (cellTypes == null) ? default(HandleRef) : cellTypes.GetCppThis(), (cellLocations == null) ? default(HandleRef) : cellLocations.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellTypes_Squeeze_22(HandleRef pThis);

		public void Squeeze()
		{
			vtkCellTypes.vtkCellTypes_Squeeze_22(base.GetCppThis());
		}
	}
}

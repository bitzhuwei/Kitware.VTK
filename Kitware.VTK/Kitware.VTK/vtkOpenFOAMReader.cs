using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenFOAMReader : vtkMultiBlockDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenFOAMReader";

		public new static readonly string MRClassNameKey;

		static vtkOpenFOAMReader()
		{
			vtkOpenFOAMReader.MRClassNameKey = "class vtkOpenFOAMReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenFOAMReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenFOAMReader"));
		}

		public vtkOpenFOAMReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenFOAMReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenFOAMReader New()
		{
			vtkOpenFOAMReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenFOAMReader.vtkOpenFOAMReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenFOAMReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenFOAMReader.vtkOpenFOAMReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_AddDimensionsToArrayNamesOff_01(HandleRef pThis);

		public virtual void AddDimensionsToArrayNamesOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_AddDimensionsToArrayNamesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_AddDimensionsToArrayNamesOn_02(HandleRef pThis);

		public virtual void AddDimensionsToArrayNamesOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_AddDimensionsToArrayNamesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_CacheMeshOff_03(HandleRef pThis);

		public virtual void CacheMeshOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_CacheMeshOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_CacheMeshOn_04(HandleRef pThis);

		public virtual void CacheMeshOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_CacheMeshOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_CanReadFile_05(HandleRef pThis, string arg0);

		public int CanReadFile(string arg0)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_CanReadFile_05(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_CreateCellToPointOff_06(HandleRef pThis);

		public virtual void CreateCellToPointOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_CreateCellToPointOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_CreateCellToPointOn_07(HandleRef pThis);

		public virtual void CreateCellToPointOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_CreateCellToPointOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_DecomposePolyhedraOff_08(HandleRef pThis);

		public virtual void DecomposePolyhedraOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_DecomposePolyhedraOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_DecomposePolyhedraOn_09(HandleRef pThis);

		public virtual void DecomposePolyhedraOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_DecomposePolyhedraOn_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_DisableAllCellArrays_10(HandleRef pThis);

		public void DisableAllCellArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_DisableAllCellArrays_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_DisableAllLagrangianArrays_11(HandleRef pThis);

		public void DisableAllLagrangianArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_DisableAllLagrangianArrays_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_DisableAllPatchArrays_12(HandleRef pThis);

		public void DisableAllPatchArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_DisableAllPatchArrays_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_DisableAllPointArrays_13(HandleRef pThis);

		public void DisableAllPointArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_DisableAllPointArrays_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_EnableAllCellArrays_14(HandleRef pThis);

		public void EnableAllCellArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_EnableAllCellArrays_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_EnableAllLagrangianArrays_15(HandleRef pThis);

		public void EnableAllLagrangianArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_EnableAllLagrangianArrays_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_EnableAllPatchArrays_16(HandleRef pThis);

		public void EnableAllPatchArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_EnableAllPatchArrays_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_EnableAllPointArrays_17(HandleRef pThis);

		public void EnableAllPointArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_EnableAllPointArrays_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_GetAddDimensionsToArrayNames_18(HandleRef pThis);

		public virtual int GetAddDimensionsToArrayNames()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetAddDimensionsToArrayNames_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_GetCacheMesh_19(HandleRef pThis);

		public virtual int GetCacheMesh()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetCacheMesh_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenFOAMReader_GetCellArrayName_20(HandleRef pThis, int index);

		public string GetCellArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkOpenFOAMReader.vtkOpenFOAMReader_GetCellArrayName_20(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_GetCellArrayStatus_21(HandleRef pThis, string name);

		public int GetCellArrayStatus(string name)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetCellArrayStatus_21(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_GetCreateCellToPoint_22(HandleRef pThis);

		public virtual int GetCreateCellToPoint()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetCreateCellToPoint_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_GetDecomposePolyhedra_23(HandleRef pThis);

		public virtual int GetDecomposePolyhedra()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetDecomposePolyhedra_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenFOAMReader_GetFileName_24(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkOpenFOAMReader.vtkOpenFOAMReader_GetFileName_24(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenFOAMReader_GetLagrangianArrayName_25(HandleRef pThis, int index);

		public string GetLagrangianArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkOpenFOAMReader.vtkOpenFOAMReader_GetLagrangianArrayName_25(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_GetLagrangianArrayStatus_26(HandleRef pThis, string name);

		public int GetLagrangianArrayStatus(string name)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetLagrangianArrayStatus_26(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_GetListTimeStepsByControlDict_27(HandleRef pThis);

		public virtual int GetListTimeStepsByControlDict()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetListTimeStepsByControlDict_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_GetNumberOfCellArrays_28(HandleRef pThis);

		public int GetNumberOfCellArrays()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetNumberOfCellArrays_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_GetNumberOfLagrangianArrays_29(HandleRef pThis);

		public int GetNumberOfLagrangianArrays()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetNumberOfLagrangianArrays_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_GetNumberOfPatchArrays_30(HandleRef pThis);

		public int GetNumberOfPatchArrays()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetNumberOfPatchArrays_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_GetNumberOfPointArrays_31(HandleRef pThis);

		public int GetNumberOfPointArrays()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetNumberOfPointArrays_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenFOAMReader_GetPatchArrayName_32(HandleRef pThis, int index);

		public string GetPatchArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkOpenFOAMReader.vtkOpenFOAMReader_GetPatchArrayName_32(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_GetPatchArrayStatus_33(HandleRef pThis, string name);

		public int GetPatchArrayStatus(string name)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetPatchArrayStatus_33(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenFOAMReader_GetPointArrayName_34(HandleRef pThis, int index);

		public string GetPointArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkOpenFOAMReader.vtkOpenFOAMReader_GetPointArrayName_34(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_GetPointArrayStatus_35(HandleRef pThis, string name);

		public int GetPointArrayStatus(string name)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetPointArrayStatus_35(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_GetPositionsIsIn13Format_36(HandleRef pThis);

		public virtual int GetPositionsIsIn13Format()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetPositionsIsIn13Format_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_GetReadZones_37(HandleRef pThis);

		public virtual int GetReadZones()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetReadZones_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenFOAMReader_GetTimeValues_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDoubleArray GetTimeValues()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenFOAMReader.vtkOpenFOAMReader_GetTimeValues_38(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_IsA_39(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_IsA_39(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_IsTypeOf_40(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_IsTypeOf_40(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_ListTimeStepsByControlDictOff_41(HandleRef pThis);

		public virtual void ListTimeStepsByControlDictOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_ListTimeStepsByControlDictOff_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_ListTimeStepsByControlDictOn_42(HandleRef pThis);

		public virtual void ListTimeStepsByControlDictOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_ListTimeStepsByControlDictOn_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOpenFOAMReader_MakeMetaDataAtTimeStep_43(HandleRef pThis, byte arg0);

		public int MakeMetaDataAtTimeStep(bool arg0)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_MakeMetaDataAtTimeStep_43(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenFOAMReader_NewInstance_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenFOAMReader NewInstance()
		{
			vtkOpenFOAMReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenFOAMReader.vtkOpenFOAMReader_NewInstance_45(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_PositionsIsIn13FormatOff_46(HandleRef pThis);

		public virtual void PositionsIsIn13FormatOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_PositionsIsIn13FormatOff_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_PositionsIsIn13FormatOn_47(HandleRef pThis);

		public virtual void PositionsIsIn13FormatOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_PositionsIsIn13FormatOn_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_ReadZonesOff_48(HandleRef pThis);

		public virtual void ReadZonesOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_ReadZonesOff_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_ReadZonesOn_49(HandleRef pThis);

		public virtual void ReadZonesOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_ReadZonesOn_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenFOAMReader_SafeDownCast_50(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenFOAMReader SafeDownCast(vtkObjectBase o)
		{
			vtkOpenFOAMReader vtkOpenFOAMReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenFOAMReader.vtkOpenFOAMReader_SafeDownCast_50((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenFOAMReader = (vtkOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenFOAMReader.Register(null);
				}
			}
			return vtkOpenFOAMReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_SetAddDimensionsToArrayNames_51(HandleRef pThis, int _arg);

		public virtual void SetAddDimensionsToArrayNames(int _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetAddDimensionsToArrayNames_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_SetCacheMesh_52(HandleRef pThis, int _arg);

		public virtual void SetCacheMesh(int _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetCacheMesh_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_SetCellArrayStatus_53(HandleRef pThis, string name, int status);

		public void SetCellArrayStatus(string name, int status)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetCellArrayStatus_53(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_SetCreateCellToPoint_54(HandleRef pThis, int _arg);

		public virtual void SetCreateCellToPoint(int _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetCreateCellToPoint_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_SetDecomposePolyhedra_55(HandleRef pThis, int _arg);

		public virtual void SetDecomposePolyhedra(int _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetDecomposePolyhedra_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_SetFileName_56(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetFileName_56(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_SetLagrangianArrayStatus_57(HandleRef pThis, string name, int status);

		public void SetLagrangianArrayStatus(string name, int status)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetLagrangianArrayStatus_57(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_SetListTimeStepsByControlDict_58(HandleRef pThis, int _arg);

		public virtual void SetListTimeStepsByControlDict(int _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetListTimeStepsByControlDict_58(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_SetParent_59(HandleRef pThis, HandleRef parent);

		public void SetParent(vtkOpenFOAMReader parent)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetParent_59(base.GetCppThis(), (parent == null) ? default(HandleRef) : parent.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_SetPatchArrayStatus_60(HandleRef pThis, string name, int status);

		public void SetPatchArrayStatus(string name, int status)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetPatchArrayStatus_60(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_SetPointArrayStatus_61(HandleRef pThis, string name, int status);

		public void SetPointArrayStatus(string name, int status)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetPointArrayStatus_61(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_SetPositionsIsIn13Format_62(HandleRef pThis, int _arg);

		public virtual void SetPositionsIsIn13Format(int _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetPositionsIsIn13Format_62(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_SetReadZones_63(HandleRef pThis, int _arg);

		public virtual void SetReadZones(int _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetReadZones_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkOpenFOAMReader_SetRefresh_64(HandleRef pThis);

		public void SetRefresh()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetRefresh_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkOpenFOAMReader_SetTimeValue_65(HandleRef pThis, double arg0);

		public bool SetTimeValue(double arg0)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_SetTimeValue_65(base.GetCppThis(), arg0) != 0;
		}
	}
}

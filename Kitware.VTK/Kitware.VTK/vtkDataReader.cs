using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataReader : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataReader";

		public new static readonly string MRClassNameKey;

		static vtkDataReader()
		{
			vtkDataReader.MRClassNameKey = "class vtkDataReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataReader"));
		}

		public vtkDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataReader New()
		{
			vtkDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataReader.vtkDataReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataReader.vtkDataReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_CloseVTKFile_01(HandleRef pThis);

		public void CloseVTKFile()
		{
			vtkDataReader.vtkDataReader_CloseVTKFile_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetFieldDataName_02(HandleRef pThis);

		public virtual string GetFieldDataName()
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetFieldDataName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetFieldDataNameInFile_03(HandleRef pThis, int i);

		public string GetFieldDataNameInFile(int i)
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetFieldDataNameInFile_03(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetFileName_04(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetFileName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetFileType_05(HandleRef pThis);

		public virtual int GetFileType()
		{
			return vtkDataReader.vtkDataReader_GetFileType_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetHeader_06(HandleRef pThis);

		public virtual string GetHeader()
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetHeader_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetInputArray_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCharArray GetInputArray()
		{
			vtkCharArray vtkCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataReader.vtkDataReader_GetInputArray_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCharArray = (vtkCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCharArray.Register(null);
				}
			}
			return vtkCharArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetInputString_08(HandleRef pThis);

		public virtual string GetInputString()
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetInputString_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetInputStringLength_09(HandleRef pThis);

		public virtual int GetInputStringLength()
		{
			return vtkDataReader.vtkDataReader_GetInputStringLength_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetLookupTableName_10(HandleRef pThis);

		public virtual string GetLookupTableName()
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetLookupTableName_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetNormalsName_11(HandleRef pThis);

		public virtual string GetNormalsName()
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetNormalsName_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetNormalsNameInFile_12(HandleRef pThis, int i);

		public string GetNormalsNameInFile(int i)
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetNormalsNameInFile_12(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetNumberOfFieldDataInFile_13(HandleRef pThis);

		public int GetNumberOfFieldDataInFile()
		{
			return vtkDataReader.vtkDataReader_GetNumberOfFieldDataInFile_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetNumberOfNormalsInFile_14(HandleRef pThis);

		public int GetNumberOfNormalsInFile()
		{
			return vtkDataReader.vtkDataReader_GetNumberOfNormalsInFile_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetNumberOfScalarsInFile_15(HandleRef pThis);

		public int GetNumberOfScalarsInFile()
		{
			return vtkDataReader.vtkDataReader_GetNumberOfScalarsInFile_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetNumberOfTCoordsInFile_16(HandleRef pThis);

		public int GetNumberOfTCoordsInFile()
		{
			return vtkDataReader.vtkDataReader_GetNumberOfTCoordsInFile_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetNumberOfTensorsInFile_17(HandleRef pThis);

		public int GetNumberOfTensorsInFile()
		{
			return vtkDataReader.vtkDataReader_GetNumberOfTensorsInFile_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetNumberOfVectorsInFile_18(HandleRef pThis);

		public int GetNumberOfVectorsInFile()
		{
			return vtkDataReader.vtkDataReader_GetNumberOfVectorsInFile_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetReadAllColorScalars_19(HandleRef pThis);

		public virtual int GetReadAllColorScalars()
		{
			return vtkDataReader.vtkDataReader_GetReadAllColorScalars_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetReadAllFields_20(HandleRef pThis);

		public virtual int GetReadAllFields()
		{
			return vtkDataReader.vtkDataReader_GetReadAllFields_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetReadAllNormals_21(HandleRef pThis);

		public virtual int GetReadAllNormals()
		{
			return vtkDataReader.vtkDataReader_GetReadAllNormals_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetReadAllScalars_22(HandleRef pThis);

		public virtual int GetReadAllScalars()
		{
			return vtkDataReader.vtkDataReader_GetReadAllScalars_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetReadAllTCoords_23(HandleRef pThis);

		public virtual int GetReadAllTCoords()
		{
			return vtkDataReader.vtkDataReader_GetReadAllTCoords_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetReadAllTensors_24(HandleRef pThis);

		public virtual int GetReadAllTensors()
		{
			return vtkDataReader.vtkDataReader_GetReadAllTensors_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetReadAllVectors_25(HandleRef pThis);

		public virtual int GetReadAllVectors()
		{
			return vtkDataReader.vtkDataReader_GetReadAllVectors_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_GetReadFromInputString_26(HandleRef pThis);

		public virtual int GetReadFromInputString()
		{
			return vtkDataReader.vtkDataReader_GetReadFromInputString_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetScalarsName_27(HandleRef pThis);

		public virtual string GetScalarsName()
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetScalarsName_27(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetScalarsNameInFile_28(HandleRef pThis, int i);

		public string GetScalarsNameInFile(int i)
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetScalarsNameInFile_28(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetTCoordsName_29(HandleRef pThis);

		public virtual string GetTCoordsName()
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetTCoordsName_29(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetTCoordsNameInFile_30(HandleRef pThis, int i);

		public string GetTCoordsNameInFile(int i)
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetTCoordsNameInFile_30(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetTensorsName_31(HandleRef pThis);

		public virtual string GetTensorsName()
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetTensorsName_31(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetTensorsNameInFile_32(HandleRef pThis, int i);

		public string GetTensorsNameInFile(int i)
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetTensorsNameInFile_32(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetVectorsName_33(HandleRef pThis);

		public virtual string GetVectorsName()
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetVectorsName_33(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_GetVectorsNameInFile_34(HandleRef pThis, int i);

		public string GetVectorsNameInFile(int i)
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_GetVectorsNameInFile_34(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_IsA_35(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataReader.vtkDataReader_IsA_35(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_IsFilePolyData_36(HandleRef pThis);

		public int IsFilePolyData()
		{
			return vtkDataReader.vtkDataReader_IsFilePolyData_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_IsFileRectilinearGrid_37(HandleRef pThis);

		public int IsFileRectilinearGrid()
		{
			return vtkDataReader.vtkDataReader_IsFileRectilinearGrid_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_IsFileStructuredGrid_38(HandleRef pThis);

		public int IsFileStructuredGrid()
		{
			return vtkDataReader.vtkDataReader_IsFileStructuredGrid_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_IsFileStructuredPoints_39(HandleRef pThis);

		public int IsFileStructuredPoints()
		{
			return vtkDataReader.vtkDataReader_IsFileStructuredPoints_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_IsFileUnstructuredGrid_40(HandleRef pThis);

		public int IsFileUnstructuredGrid()
		{
			return vtkDataReader.vtkDataReader_IsFileUnstructuredGrid_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_IsFileValid_41(HandleRef pThis, string dstype);

		public int IsFileValid(string dstype)
		{
			return vtkDataReader.vtkDataReader_IsFileValid_41(base.GetCppThis(), dstype);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_IsTypeOf_42(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataReader.vtkDataReader_IsTypeOf_42(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_LowerCase_43(HandleRef pThis, string str, uint len);

		public string LowerCase(string str, uint len)
		{
			return Marshal.PtrToStringAnsi(vtkDataReader.vtkDataReader_LowerCase_43(base.GetCppThis(), str, len));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_NewInstance_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataReader NewInstance()
		{
			vtkDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataReader.vtkDataReader_NewInstance_45(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_OpenVTKFile_46(HandleRef pThis);

		public int OpenVTKFile()
		{
			return vtkDataReader.vtkDataReader_OpenVTKFile_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_Read_47(HandleRef pThis, string arg0);

		public int Read(string arg0)
		{
			return vtkDataReader.vtkDataReader_Read_47(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_Read_48(HandleRef pThis, IntPtr arg0);

		public int Read(IntPtr arg0)
		{
			return vtkDataReader.vtkDataReader_Read_48(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadAllColorScalarsOff_49(HandleRef pThis);

		public virtual void ReadAllColorScalarsOff()
		{
			vtkDataReader.vtkDataReader_ReadAllColorScalarsOff_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadAllColorScalarsOn_50(HandleRef pThis);

		public virtual void ReadAllColorScalarsOn()
		{
			vtkDataReader.vtkDataReader_ReadAllColorScalarsOn_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadAllFieldsOff_51(HandleRef pThis);

		public virtual void ReadAllFieldsOff()
		{
			vtkDataReader.vtkDataReader_ReadAllFieldsOff_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadAllFieldsOn_52(HandleRef pThis);

		public virtual void ReadAllFieldsOn()
		{
			vtkDataReader.vtkDataReader_ReadAllFieldsOn_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadAllNormalsOff_53(HandleRef pThis);

		public virtual void ReadAllNormalsOff()
		{
			vtkDataReader.vtkDataReader_ReadAllNormalsOff_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadAllNormalsOn_54(HandleRef pThis);

		public virtual void ReadAllNormalsOn()
		{
			vtkDataReader.vtkDataReader_ReadAllNormalsOn_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadAllScalarsOff_55(HandleRef pThis);

		public virtual void ReadAllScalarsOff()
		{
			vtkDataReader.vtkDataReader_ReadAllScalarsOff_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadAllScalarsOn_56(HandleRef pThis);

		public virtual void ReadAllScalarsOn()
		{
			vtkDataReader.vtkDataReader_ReadAllScalarsOn_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadAllTCoordsOff_57(HandleRef pThis);

		public virtual void ReadAllTCoordsOff()
		{
			vtkDataReader.vtkDataReader_ReadAllTCoordsOff_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadAllTCoordsOn_58(HandleRef pThis);

		public virtual void ReadAllTCoordsOn()
		{
			vtkDataReader.vtkDataReader_ReadAllTCoordsOn_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadAllTensorsOff_59(HandleRef pThis);

		public virtual void ReadAllTensorsOff()
		{
			vtkDataReader.vtkDataReader_ReadAllTensorsOff_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadAllTensorsOn_60(HandleRef pThis);

		public virtual void ReadAllTensorsOn()
		{
			vtkDataReader.vtkDataReader_ReadAllTensorsOn_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadAllVectorsOff_61(HandleRef pThis);

		public virtual void ReadAllVectorsOff()
		{
			vtkDataReader.vtkDataReader_ReadAllVectorsOff_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadAllVectorsOn_62(HandleRef pThis);

		public virtual void ReadAllVectorsOn()
		{
			vtkDataReader.vtkDataReader_ReadAllVectorsOn_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_ReadArray_63(HandleRef pThis, string dataType, int numTuples, int numComp, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractArray ReadArray(string dataType, int numTuples, int numComp)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataReader.vtkDataReader_ReadArray_63(base.GetCppThis(), dataType, numTuples, numComp, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_ReadCellData_64(HandleRef pThis, HandleRef ds, int numCells);

		public int ReadCellData(vtkDataSet ds, int numCells)
		{
			return vtkDataReader.vtkDataReader_ReadCellData_64(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis(), numCells);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_ReadCells_65(HandleRef pThis, int size, IntPtr data);

		public int ReadCells(int size, IntPtr data)
		{
			return vtkDataReader.vtkDataReader_ReadCells_65(base.GetCppThis(), size, data);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_ReadCells_66(HandleRef pThis, int size, IntPtr data, int skip1, int read2, int skip3);

		public int ReadCells(int size, IntPtr data, int skip1, int read2, int skip3)
		{
			return vtkDataReader.vtkDataReader_ReadCells_66(base.GetCppThis(), size, data, skip1, read2, skip3);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_ReadCoordinates_67(HandleRef pThis, HandleRef rg, int axes, int numCoords);

		public int ReadCoordinates(vtkRectilinearGrid rg, int axes, int numCoords)
		{
			return vtkDataReader.vtkDataReader_ReadCoordinates_67(base.GetCppThis(), (rg == null) ? default(HandleRef) : rg.GetCppThis(), axes, numCoords);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_ReadEdgeData_68(HandleRef pThis, HandleRef g, int numEdges);

		public int ReadEdgeData(vtkGraph g, int numEdges)
		{
			return vtkDataReader.vtkDataReader_ReadEdgeData_68(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis(), numEdges);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_ReadFieldData_69(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkFieldData ReadFieldData()
		{
			vtkFieldData vtkFieldData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataReader.vtkDataReader_ReadFieldData_69(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldData = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldData.Register(null);
				}
			}
			return vtkFieldData;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadFromInputStringOff_70(HandleRef pThis);

		public virtual void ReadFromInputStringOff()
		{
			vtkDataReader.vtkDataReader_ReadFromInputStringOff_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_ReadFromInputStringOn_71(HandleRef pThis);

		public virtual void ReadFromInputStringOn()
		{
			vtkDataReader.vtkDataReader_ReadFromInputStringOn_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_ReadHeader_72(HandleRef pThis);

		public int ReadHeader()
		{
			return vtkDataReader.vtkDataReader_ReadHeader_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_ReadLine_73(HandleRef pThis, string result);

		public int ReadLine(string result)
		{
			return vtkDataReader.vtkDataReader_ReadLine_73(base.GetCppThis(), result);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_ReadMetaData_74(HandleRef pThis, HandleRef arg0);

		public virtual int ReadMetaData(vtkInformation arg0)
		{
			return vtkDataReader.vtkDataReader_ReadMetaData_74(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_ReadPointData_75(HandleRef pThis, HandleRef ds, int numPts);

		public int ReadPointData(vtkDataSet ds, int numPts)
		{
			return vtkDataReader.vtkDataReader_ReadPointData_75(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis(), numPts);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_ReadPoints_76(HandleRef pThis, HandleRef ps, int numPts);

		public int ReadPoints(vtkPointSet ps, int numPts)
		{
			return vtkDataReader.vtkDataReader_ReadPoints_76(base.GetCppThis(), (ps == null) ? default(HandleRef) : ps.GetCppThis(), numPts);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_ReadPoints_77(HandleRef pThis, HandleRef g, int numPts);

		public int ReadPoints(vtkGraph g, int numPts)
		{
			return vtkDataReader.vtkDataReader_ReadPoints_77(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis(), numPts);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_ReadRowData_78(HandleRef pThis, HandleRef t, int numEdges);

		public int ReadRowData(vtkTable t, int numEdges)
		{
			return vtkDataReader.vtkDataReader_ReadRowData_78(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis(), numEdges);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_ReadString_79(HandleRef pThis, string result);

		public int ReadString(string result)
		{
			return vtkDataReader.vtkDataReader_ReadString_79(base.GetCppThis(), result);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataReader_ReadVertexData_80(HandleRef pThis, HandleRef g, int numVertices);

		public int ReadVertexData(vtkGraph g, int numVertices)
		{
			return vtkDataReader.vtkDataReader_ReadVertexData_80(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis(), numVertices);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataReader_SafeDownCast_81(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkDataReader vtkDataReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataReader.vtkDataReader_SafeDownCast_81((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataReader = (vtkDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataReader.Register(null);
				}
			}
			return vtkDataReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetBinaryInputString_82(HandleRef pThis, string arg0, int len);

		public void SetBinaryInputString(string arg0, int len)
		{
			vtkDataReader.vtkDataReader_SetBinaryInputString_82(base.GetCppThis(), arg0, len);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetFieldDataName_83(HandleRef pThis, string _arg);

		public virtual void SetFieldDataName(string _arg)
		{
			vtkDataReader.vtkDataReader_SetFieldDataName_83(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetFileName_84(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkDataReader.vtkDataReader_SetFileName_84(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetInputArray_85(HandleRef pThis, HandleRef arg0);

		public virtual void SetInputArray(vtkCharArray arg0)
		{
			vtkDataReader.vtkDataReader_SetInputArray_85(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetInputString_86(HandleRef pThis, string arg0);

		public void SetInputString(string arg0)
		{
			vtkDataReader.vtkDataReader_SetInputString_86(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetInputString_87(HandleRef pThis, string arg0, int len);

		public void SetInputString(string arg0, int len)
		{
			vtkDataReader.vtkDataReader_SetInputString_87(base.GetCppThis(), arg0, len);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetLookupTableName_88(HandleRef pThis, string _arg);

		public virtual void SetLookupTableName(string _arg)
		{
			vtkDataReader.vtkDataReader_SetLookupTableName_88(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetNormalsName_89(HandleRef pThis, string _arg);

		public virtual void SetNormalsName(string _arg)
		{
			vtkDataReader.vtkDataReader_SetNormalsName_89(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetReadAllColorScalars_90(HandleRef pThis, int _arg);

		public virtual void SetReadAllColorScalars(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadAllColorScalars_90(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetReadAllFields_91(HandleRef pThis, int _arg);

		public virtual void SetReadAllFields(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadAllFields_91(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetReadAllNormals_92(HandleRef pThis, int _arg);

		public virtual void SetReadAllNormals(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadAllNormals_92(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetReadAllScalars_93(HandleRef pThis, int _arg);

		public virtual void SetReadAllScalars(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadAllScalars_93(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetReadAllTCoords_94(HandleRef pThis, int _arg);

		public virtual void SetReadAllTCoords(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadAllTCoords_94(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetReadAllTensors_95(HandleRef pThis, int _arg);

		public virtual void SetReadAllTensors(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadAllTensors_95(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetReadAllVectors_96(HandleRef pThis, int _arg);

		public virtual void SetReadAllVectors(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadAllVectors_96(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetReadFromInputString_97(HandleRef pThis, int _arg);

		public virtual void SetReadFromInputString(int _arg)
		{
			vtkDataReader.vtkDataReader_SetReadFromInputString_97(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetScalarsName_98(HandleRef pThis, string _arg);

		public virtual void SetScalarsName(string _arg)
		{
			vtkDataReader.vtkDataReader_SetScalarsName_98(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetTCoordsName_99(HandleRef pThis, string _arg);

		public virtual void SetTCoordsName(string _arg)
		{
			vtkDataReader.vtkDataReader_SetTCoordsName_99(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetTensorsName_100(HandleRef pThis, string _arg);

		public virtual void SetTensorsName(string _arg)
		{
			vtkDataReader.vtkDataReader_SetTensorsName_100(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataReader_SetVectorsName_101(HandleRef pThis, string _arg);

		public virtual void SetVectorsName(string _arg)
		{
			vtkDataReader.vtkDataReader_SetVectorsName_101(base.GetCppThis(), _arg);
		}
	}
}

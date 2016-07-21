using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLSDynaReader : vtkMultiBlockDataSetAlgorithm
	{
		public enum BEAM_WrapperEnum
		{
			BEAM = 1,
			NUM_CELL_TYPES = 7,
			PARTICLE = 0,
			RIGID_BODY = 5,
			ROAD_SURFACE,
			SHELL = 2,
			SOLID = 4,
			THICK_SHELL = 3
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkLSDynaReader";

		public new static readonly string MRClassNameKey;

		static vtkLSDynaReader()
		{
			vtkLSDynaReader.MRClassNameKey = "class vtkLSDynaReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLSDynaReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLSDynaReader"));
		}

		public vtkLSDynaReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLSDynaReader New()
		{
			vtkLSDynaReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLSDynaReader.vtkLSDynaReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLSDynaReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLSDynaReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLSDynaReader.vtkLSDynaReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_CanReadFile_01(HandleRef pThis, string fname);

		public int CanReadFile(string fname)
		{
			return vtkLSDynaReader.vtkLSDynaReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_DebugDump_02(HandleRef pThis);

		public void DebugDump()
		{
			vtkLSDynaReader.vtkLSDynaReader_DebugDump_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_DeformedMeshOff_03(HandleRef pThis);

		public virtual void DeformedMeshOff()
		{
			vtkLSDynaReader.vtkLSDynaReader_DeformedMeshOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_DeformedMeshOn_04(HandleRef pThis);

		public virtual void DeformedMeshOn()
		{
			vtkLSDynaReader.vtkLSDynaReader_DeformedMeshOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_GetBeamArrayName_05(HandleRef pThis, int arg0);

		public string GetBeamArrayName(int arg0)
		{
			return Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetBeamArrayName_05(base.GetCppThis(), arg0));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetBeamArrayStatus_06(HandleRef pThis, int arr);

		public int GetBeamArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetBeamArrayStatus_06(base.GetCppThis(), arr);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetBeamArrayStatus_07(HandleRef pThis, string arrName);

		public int GetBeamArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetBeamArrayStatus_07(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_GetCellArrayName_08(HandleRef pThis, int cellType, int arr);

		public string GetCellArrayName(int cellType, int arr)
		{
			return Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetCellArrayName_08(base.GetCppThis(), cellType, arr));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetCellArrayStatus_09(HandleRef pThis, int cellType, int arr);

		public int GetCellArrayStatus(int cellType, int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetCellArrayStatus_09(base.GetCppThis(), cellType, arr);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetCellArrayStatus_10(HandleRef pThis, int cellType, string arrName);

		public int GetCellArrayStatus(int cellType, string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetCellArrayStatus_10(base.GetCppThis(), cellType, arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_GetDatabaseDirectory_11(HandleRef pThis);

		public string GetDatabaseDirectory()
		{
			return Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetDatabaseDirectory_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetDeformedMesh_12(HandleRef pThis);

		public virtual int GetDeformedMesh()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetDeformedMesh_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetDimensionality_13(HandleRef pThis);

		public int GetDimensionality()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetDimensionality_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_GetFileName_14(HandleRef pThis);

		public string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetFileName_14(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_GetInputDeck_15(HandleRef pThis);

		public virtual string GetInputDeck()
		{
			return Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetInputDeck_15(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfBeamArrays_16(HandleRef pThis);

		public int GetNumberOfBeamArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfBeamArrays_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkLSDynaReader_GetNumberOfBeamCells_17(HandleRef pThis);

		public long GetNumberOfBeamCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfBeamCells_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfCellArrays_18(HandleRef pThis, int cellType);

		public int GetNumberOfCellArrays(int cellType)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfCellArrays_18(base.GetCppThis(), cellType);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkLSDynaReader_GetNumberOfCells_19(HandleRef pThis);

		public long GetNumberOfCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfCells_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInBeamArray_20(HandleRef pThis, int a);

		public int GetNumberOfComponentsInBeamArray(int a)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInBeamArray_20(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInBeamArray_21(HandleRef pThis, string arrName);

		public int GetNumberOfComponentsInBeamArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInBeamArray_21(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInCellArray_22(HandleRef pThis, int cellType, int arr);

		public int GetNumberOfComponentsInCellArray(int cellType, int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInCellArray_22(base.GetCppThis(), cellType, arr);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInCellArray_23(HandleRef pThis, int cellType, string arrName);

		public int GetNumberOfComponentsInCellArray(int cellType, string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInCellArray_23(base.GetCppThis(), cellType, arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInParticleArray_24(HandleRef pThis, int a);

		public int GetNumberOfComponentsInParticleArray(int a)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInParticleArray_24(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInParticleArray_25(HandleRef pThis, string arrName);

		public int GetNumberOfComponentsInParticleArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInParticleArray_25(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInPointArray_26(HandleRef pThis, int arr);

		public int GetNumberOfComponentsInPointArray(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInPointArray_26(base.GetCppThis(), arr);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInPointArray_27(HandleRef pThis, string arrName);

		public int GetNumberOfComponentsInPointArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInPointArray_27(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInRigidBodyArray_28(HandleRef pThis, int a);

		public int GetNumberOfComponentsInRigidBodyArray(int a)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInRigidBodyArray_28(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInRigidBodyArray_29(HandleRef pThis, string arrName);

		public int GetNumberOfComponentsInRigidBodyArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInRigidBodyArray_29(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInRoadSurfaceArray_30(HandleRef pThis, int a);

		public int GetNumberOfComponentsInRoadSurfaceArray(int a)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInRoadSurfaceArray_30(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInRoadSurfaceArray_31(HandleRef pThis, string arrName);

		public int GetNumberOfComponentsInRoadSurfaceArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInRoadSurfaceArray_31(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInShellArray_32(HandleRef pThis, int a);

		public int GetNumberOfComponentsInShellArray(int a)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInShellArray_32(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInShellArray_33(HandleRef pThis, string arrName);

		public int GetNumberOfComponentsInShellArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInShellArray_33(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInSolidArray_34(HandleRef pThis, int a);

		public int GetNumberOfComponentsInSolidArray(int a)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInSolidArray_34(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInSolidArray_35(HandleRef pThis, string arrName);

		public int GetNumberOfComponentsInSolidArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInSolidArray_35(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInThickShellArray_36(HandleRef pThis, int a);

		public int GetNumberOfComponentsInThickShellArray(int a)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInThickShellArray_36(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInThickShellArray_37(HandleRef pThis, string arrName);

		public int GetNumberOfComponentsInThickShellArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInThickShellArray_37(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkLSDynaReader_GetNumberOfContinuumCells_38(HandleRef pThis);

		public long GetNumberOfContinuumCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfContinuumCells_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkLSDynaReader_GetNumberOfNodes_39(HandleRef pThis);

		public long GetNumberOfNodes()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfNodes_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfPartArrays_40(HandleRef pThis);

		public int GetNumberOfPartArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfPartArrays_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfParticleArrays_41(HandleRef pThis);

		public int GetNumberOfParticleArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfParticleArrays_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkLSDynaReader_GetNumberOfParticleCells_42(HandleRef pThis);

		public long GetNumberOfParticleCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfParticleCells_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfPointArrays_43(HandleRef pThis);

		public int GetNumberOfPointArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfPointArrays_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfRigidBodyArrays_44(HandleRef pThis);

		public int GetNumberOfRigidBodyArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfRigidBodyArrays_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkLSDynaReader_GetNumberOfRigidBodyCells_45(HandleRef pThis);

		public long GetNumberOfRigidBodyCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfRigidBodyCells_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfRoadSurfaceArrays_46(HandleRef pThis);

		public int GetNumberOfRoadSurfaceArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfRoadSurfaceArrays_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkLSDynaReader_GetNumberOfRoadSurfaceCells_47(HandleRef pThis);

		public long GetNumberOfRoadSurfaceCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfRoadSurfaceCells_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfShellArrays_48(HandleRef pThis);

		public int GetNumberOfShellArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfShellArrays_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkLSDynaReader_GetNumberOfShellCells_49(HandleRef pThis);

		public long GetNumberOfShellCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfShellCells_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfSolidArrays_50(HandleRef pThis);

		public int GetNumberOfSolidArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfSolidArrays_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkLSDynaReader_GetNumberOfSolidCells_51(HandleRef pThis);

		public long GetNumberOfSolidCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfSolidCells_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetNumberOfThickShellArrays_52(HandleRef pThis);

		public int GetNumberOfThickShellArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfThickShellArrays_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkLSDynaReader_GetNumberOfThickShellCells_53(HandleRef pThis);

		public long GetNumberOfThickShellCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfThickShellCells_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkLSDynaReader_GetNumberOfTimeSteps_54(HandleRef pThis);

		public long GetNumberOfTimeSteps()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfTimeSteps_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_GetPartArrayName_55(HandleRef pThis, int arg0);

		public string GetPartArrayName(int arg0)
		{
			return Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetPartArrayName_55(base.GetCppThis(), arg0));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetPartArrayStatus_56(HandleRef pThis, int arr);

		public int GetPartArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetPartArrayStatus_56(base.GetCppThis(), arr);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetPartArrayStatus_57(HandleRef pThis, string partName);

		public int GetPartArrayStatus(string partName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetPartArrayStatus_57(base.GetCppThis(), partName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_GetParticleArrayName_58(HandleRef pThis, int arg0);

		public string GetParticleArrayName(int arg0)
		{
			return Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetParticleArrayName_58(base.GetCppThis(), arg0));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetParticleArrayStatus_59(HandleRef pThis, int arr);

		public int GetParticleArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetParticleArrayStatus_59(base.GetCppThis(), arr);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetParticleArrayStatus_60(HandleRef pThis, string arrName);

		public int GetParticleArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetParticleArrayStatus_60(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_GetPointArrayName_61(HandleRef pThis, int arg0);

		public string GetPointArrayName(int arg0)
		{
			return Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetPointArrayName_61(base.GetCppThis(), arg0));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetPointArrayStatus_62(HandleRef pThis, int arr);

		public int GetPointArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetPointArrayStatus_62(base.GetCppThis(), arr);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetPointArrayStatus_63(HandleRef pThis, string arrName);

		public int GetPointArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetPointArrayStatus_63(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetRemoveDeletedCells_64(HandleRef pThis);

		public virtual int GetRemoveDeletedCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetRemoveDeletedCells_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_GetRigidBodyArrayName_65(HandleRef pThis, int arg0);

		public string GetRigidBodyArrayName(int arg0)
		{
			return Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetRigidBodyArrayName_65(base.GetCppThis(), arg0));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetRigidBodyArrayStatus_66(HandleRef pThis, int arr);

		public int GetRigidBodyArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetRigidBodyArrayStatus_66(base.GetCppThis(), arr);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetRigidBodyArrayStatus_67(HandleRef pThis, string arrName);

		public int GetRigidBodyArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetRigidBodyArrayStatus_67(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_GetRoadSurfaceArrayName_68(HandleRef pThis, int arg0);

		public string GetRoadSurfaceArrayName(int arg0)
		{
			return Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetRoadSurfaceArrayName_68(base.GetCppThis(), arg0));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetRoadSurfaceArrayStatus_69(HandleRef pThis, int arr);

		public int GetRoadSurfaceArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetRoadSurfaceArrayStatus_69(base.GetCppThis(), arr);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetRoadSurfaceArrayStatus_70(HandleRef pThis, string arrName);

		public int GetRoadSurfaceArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetRoadSurfaceArrayStatus_70(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_GetShellArrayName_71(HandleRef pThis, int arg0);

		public string GetShellArrayName(int arg0)
		{
			return Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetShellArrayName_71(base.GetCppThis(), arg0));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetShellArrayStatus_72(HandleRef pThis, int arr);

		public int GetShellArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetShellArrayStatus_72(base.GetCppThis(), arr);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetShellArrayStatus_73(HandleRef pThis, string arrName);

		public int GetShellArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetShellArrayStatus_73(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_GetSolidArrayName_74(HandleRef pThis, int arg0);

		public string GetSolidArrayName(int arg0)
		{
			return Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetSolidArrayName_74(base.GetCppThis(), arg0));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetSolidArrayStatus_75(HandleRef pThis, int arr);

		public int GetSolidArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetSolidArrayStatus_75(base.GetCppThis(), arr);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetSolidArrayStatus_76(HandleRef pThis, string arrName);

		public int GetSolidArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetSolidArrayStatus_76(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetSplitByMaterialId_77(HandleRef pThis);

		public virtual int GetSplitByMaterialId()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetSplitByMaterialId_77(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_GetThickShellArrayName_78(HandleRef pThis, int arg0);

		public string GetThickShellArrayName(int arg0)
		{
			return Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetThickShellArrayName_78(base.GetCppThis(), arg0));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetThickShellArrayStatus_79(HandleRef pThis, int arr);

		public int GetThickShellArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetThickShellArrayStatus_79(base.GetCppThis(), arr);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_GetThickShellArrayStatus_80(HandleRef pThis, string arrName);

		public int GetThickShellArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetThickShellArrayStatus_80(base.GetCppThis(), arrName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkLSDynaReader_GetTimeStep_81(HandleRef pThis);

		public long GetTimeStep()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetTimeStep_81(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_GetTimeStepRange_82(HandleRef pThis);

		public virtual int[] GetTimeStepRange()
		{
			IntPtr intPtr = vtkLSDynaReader.vtkLSDynaReader_GetTimeStepRange_82(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_GetTimeStepRange_83(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
		{
			vtkLSDynaReader.vtkLSDynaReader_GetTimeStepRange_83(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_GetTimeStepRange_84(HandleRef pThis, IntPtr _arg);

		public virtual void GetTimeStepRange(IntPtr _arg)
		{
			vtkLSDynaReader.vtkLSDynaReader_GetTimeStepRange_84(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkLSDynaReader_GetTimeValue_85(HandleRef pThis, long arg0);

		public double GetTimeValue(long arg0)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetTimeValue_85(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_GetTitle_86(HandleRef pThis);

		public string GetTitle()
		{
			return Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetTitle_86(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_IsA_87(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLSDynaReader.vtkLSDynaReader_IsA_87(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_IsDatabaseValid_88(HandleRef pThis);

		public int IsDatabaseValid()
		{
			return vtkLSDynaReader.vtkLSDynaReader_IsDatabaseValid_88(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkLSDynaReader_IsTypeOf_89(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLSDynaReader.vtkLSDynaReader_IsTypeOf_89(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_NewInstance_91(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLSDynaReader NewInstance()
		{
			vtkLSDynaReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLSDynaReader.vtkLSDynaReader_NewInstance_91(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLSDynaReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_RemoveDeletedCellsOff_92(HandleRef pThis);

		public virtual void RemoveDeletedCellsOff()
		{
			vtkLSDynaReader.vtkLSDynaReader_RemoveDeletedCellsOff_92(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_RemoveDeletedCellsOn_93(HandleRef pThis);

		public virtual void RemoveDeletedCellsOn()
		{
			vtkLSDynaReader.vtkLSDynaReader_RemoveDeletedCellsOn_93(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkLSDynaReader_SafeDownCast_94(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLSDynaReader SafeDownCast(vtkObjectBase o)
		{
			vtkLSDynaReader vtkLSDynaReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLSDynaReader.vtkLSDynaReader_SafeDownCast_94((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLSDynaReader = (vtkLSDynaReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLSDynaReader.Register(null);
				}
			}
			return vtkLSDynaReader;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetBeamArrayStatus_95(HandleRef pThis, int arr, int status);

		public virtual void SetBeamArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetBeamArrayStatus_95(base.GetCppThis(), arr, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetBeamArrayStatus_96(HandleRef pThis, string arrName, int status);

		public virtual void SetBeamArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetBeamArrayStatus_96(base.GetCppThis(), arrName, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetCellArrayStatus_97(HandleRef pThis, int cellType, int arr, int status);

		public virtual void SetCellArrayStatus(int cellType, int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetCellArrayStatus_97(base.GetCppThis(), cellType, arr, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetCellArrayStatus_98(HandleRef pThis, int cellType, string arrName, int status);

		public virtual void SetCellArrayStatus(int cellType, string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetCellArrayStatus_98(base.GetCppThis(), cellType, arrName, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetDatabaseDirectory_99(HandleRef pThis, string arg0);

		public virtual void SetDatabaseDirectory(string arg0)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetDatabaseDirectory_99(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetDeformedMesh_100(HandleRef pThis, int _arg);

		public virtual void SetDeformedMesh(int _arg)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetDeformedMesh_100(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetFileName_101(HandleRef pThis, string arg0);

		public virtual void SetFileName(string arg0)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetFileName_101(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetInputDeck_102(HandleRef pThis, string _arg);

		public virtual void SetInputDeck(string _arg)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetInputDeck_102(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetPartArrayStatus_103(HandleRef pThis, int arr, int status);

		public virtual void SetPartArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetPartArrayStatus_103(base.GetCppThis(), arr, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetPartArrayStatus_104(HandleRef pThis, string arrName, int status);

		public virtual void SetPartArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetPartArrayStatus_104(base.GetCppThis(), arrName, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetParticleArrayStatus_105(HandleRef pThis, int arr, int status);

		public virtual void SetParticleArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetParticleArrayStatus_105(base.GetCppThis(), arr, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetParticleArrayStatus_106(HandleRef pThis, string arrName, int status);

		public virtual void SetParticleArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetParticleArrayStatus_106(base.GetCppThis(), arrName, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetPointArrayStatus_107(HandleRef pThis, int arr, int status);

		public virtual void SetPointArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetPointArrayStatus_107(base.GetCppThis(), arr, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetPointArrayStatus_108(HandleRef pThis, string arrName, int status);

		public virtual void SetPointArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetPointArrayStatus_108(base.GetCppThis(), arrName, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetRemoveDeletedCells_109(HandleRef pThis, int _arg);

		public virtual void SetRemoveDeletedCells(int _arg)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetRemoveDeletedCells_109(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetRigidBodyArrayStatus_110(HandleRef pThis, int arr, int status);

		public virtual void SetRigidBodyArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetRigidBodyArrayStatus_110(base.GetCppThis(), arr, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetRigidBodyArrayStatus_111(HandleRef pThis, string arrName, int status);

		public virtual void SetRigidBodyArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetRigidBodyArrayStatus_111(base.GetCppThis(), arrName, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetRoadSurfaceArrayStatus_112(HandleRef pThis, int arr, int status);

		public virtual void SetRoadSurfaceArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetRoadSurfaceArrayStatus_112(base.GetCppThis(), arr, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetRoadSurfaceArrayStatus_113(HandleRef pThis, string arrName, int status);

		public virtual void SetRoadSurfaceArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetRoadSurfaceArrayStatus_113(base.GetCppThis(), arrName, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetShellArrayStatus_114(HandleRef pThis, int arr, int status);

		public virtual void SetShellArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetShellArrayStatus_114(base.GetCppThis(), arr, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetShellArrayStatus_115(HandleRef pThis, string arrName, int status);

		public virtual void SetShellArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetShellArrayStatus_115(base.GetCppThis(), arrName, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetSolidArrayStatus_116(HandleRef pThis, int arr, int status);

		public virtual void SetSolidArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetSolidArrayStatus_116(base.GetCppThis(), arr, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetSolidArrayStatus_117(HandleRef pThis, string arrName, int status);

		public virtual void SetSolidArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetSolidArrayStatus_117(base.GetCppThis(), arrName, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetSplitByMaterialId_118(HandleRef pThis, int _arg);

		public virtual void SetSplitByMaterialId(int _arg)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetSplitByMaterialId_118(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetThickShellArrayStatus_119(HandleRef pThis, int arr, int status);

		public virtual void SetThickShellArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetThickShellArrayStatus_119(base.GetCppThis(), arr, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetThickShellArrayStatus_120(HandleRef pThis, string arrName, int status);

		public virtual void SetThickShellArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetThickShellArrayStatus_120(base.GetCppThis(), arrName, status);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetTimeStep_121(HandleRef pThis, long arg0);

		public virtual void SetTimeStep(long arg0)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetTimeStep_121(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetTimeStepRange_122(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetTimeStepRange(int _arg1, int _arg2)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetTimeStepRange_122(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SetTimeStepRange_123(HandleRef pThis, IntPtr _arg);

		public void SetTimeStepRange(IntPtr _arg)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetTimeStepRange_123(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SplitByMaterialIdOff_124(HandleRef pThis);

		public virtual void SplitByMaterialIdOff()
		{
			vtkLSDynaReader.vtkLSDynaReader_SplitByMaterialIdOff_124(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkLSDynaReader_SplitByMaterialIdOn_125(HandleRef pThis);

		public virtual void SplitByMaterialIdOn()
		{
			vtkLSDynaReader.vtkLSDynaReader_SplitByMaterialIdOn_125(base.GetCppThis());
		}
	}
}

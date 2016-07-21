using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMPASReader : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMPASReader";

		public new static readonly string MRClassNameKey;

		static vtkMPASReader()
		{
			vtkMPASReader.MRClassNameKey = "class vtkMPASReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMPASReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMPASReader"));
		}

		public vtkMPASReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMPASReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMPASReader New()
		{
			vtkMPASReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMPASReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMPASReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMPASReader.vtkMPASReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMPASReader_CanReadFile_01(string filename);

		public static int CanReadFile(string filename)
		{
			return vtkMPASReader.vtkMPASReader_CanReadFile_01(filename);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_DisableAllCellArrays_02(HandleRef pThis);

		public void DisableAllCellArrays()
		{
			vtkMPASReader.vtkMPASReader_DisableAllCellArrays_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_DisableAllPointArrays_03(HandleRef pThis);

		public void DisableAllPointArrays()
		{
			vtkMPASReader.vtkMPASReader_DisableAllPointArrays_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_EnableAllCellArrays_04(HandleRef pThis);

		public void EnableAllCellArrays()
		{
			vtkMPASReader.vtkMPASReader_EnableAllCellArrays_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_EnableAllPointArrays_05(HandleRef pThis);

		public void EnableAllPointArrays()
		{
			vtkMPASReader.vtkMPASReader_EnableAllPointArrays_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMPASReader_GetCellArrayName_06(HandleRef pThis, int index);

		public string GetCellArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkMPASReader.vtkMPASReader_GetCellArrayName_06(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMPASReader_GetCellArrayStatus_07(HandleRef pThis, string name);

		public int GetCellArrayStatus(string name)
		{
			return vtkMPASReader.vtkMPASReader_GetCellArrayStatus_07(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMPASReader_GetCenterLonRange_08(HandleRef pThis);

		public virtual int[] GetCenterLonRange()
		{
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_GetCenterLonRange_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_GetCenterLonRange_09(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetCenterLonRange(ref int _arg1, ref int _arg2)
		{
			vtkMPASReader.vtkMPASReader_GetCenterLonRange_09(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_GetCenterLonRange_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetCenterLonRange(IntPtr _arg)
		{
			vtkMPASReader.vtkMPASReader_GetCenterLonRange_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMPASReader_GetFileName_11(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkMPASReader.vtkMPASReader_GetFileName_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkMPASReader_GetIsAtmosphere_12(HandleRef pThis);

		public virtual bool GetIsAtmosphere()
		{
			return vtkMPASReader.vtkMPASReader_GetIsAtmosphere_12(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkMPASReader_GetIsZeroCentered_13(HandleRef pThis);

		public virtual bool GetIsZeroCentered()
		{
			return vtkMPASReader.vtkMPASReader_GetIsZeroCentered_13(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMPASReader_GetLayerThicknessRange_14(HandleRef pThis);

		public virtual int[] GetLayerThicknessRange()
		{
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_GetLayerThicknessRange_14(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_GetLayerThicknessRange_15(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetLayerThicknessRange(ref int _arg1, ref int _arg2)
		{
			vtkMPASReader.vtkMPASReader_GetLayerThicknessRange_15(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_GetLayerThicknessRange_16(HandleRef pThis, IntPtr _arg);

		public virtual void GetLayerThicknessRange(IntPtr _arg)
		{
			vtkMPASReader.vtkMPASReader_GetLayerThicknessRange_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMPASReader_GetNumberOfCellArrays_17(HandleRef pThis);

		public int GetNumberOfCellArrays()
		{
			return vtkMPASReader.vtkMPASReader_GetNumberOfCellArrays_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMPASReader_GetNumberOfPointArrays_18(HandleRef pThis);

		public int GetNumberOfPointArrays()
		{
			return vtkMPASReader.vtkMPASReader_GetNumberOfPointArrays_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMPASReader_GetOutput_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGrid GetOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_GetOutput_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMPASReader_GetOutput_20(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGrid GetOutput(int index)
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_GetOutput_20(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMPASReader_GetPointArrayName_21(HandleRef pThis, int index);

		public string GetPointArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkMPASReader.vtkMPASReader_GetPointArrayName_21(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMPASReader_GetPointArrayStatus_22(HandleRef pThis, string name);

		public int GetPointArrayStatus(string name)
		{
			return vtkMPASReader.vtkMPASReader_GetPointArrayStatus_22(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkMPASReader_GetProjectLatLon_23(HandleRef pThis);

		public virtual bool GetProjectLatLon()
		{
			return vtkMPASReader.vtkMPASReader_GetProjectLatLon_23(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkMPASReader_GetShowMultilayerView_24(HandleRef pThis);

		public virtual bool GetShowMultilayerView()
		{
			return vtkMPASReader.vtkMPASReader_GetShowMultilayerView_24(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMPASReader_GetVerticalLevelRange_25(HandleRef pThis);

		public virtual int[] GetVerticalLevelRange()
		{
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_GetVerticalLevelRange_25(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_GetVerticalLevelRange_26(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetVerticalLevelRange(ref int _arg1, ref int _arg2)
		{
			vtkMPASReader.vtkMPASReader_GetVerticalLevelRange_26(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_GetVerticalLevelRange_27(HandleRef pThis, IntPtr _arg);

		public virtual void GetVerticalLevelRange(IntPtr _arg)
		{
			vtkMPASReader.vtkMPASReader_GetVerticalLevelRange_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMPASReader_GetmaxCells_28(HandleRef pThis);

		public virtual int GetmaxCells()
		{
			return vtkMPASReader.vtkMPASReader_GetmaxCells_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMPASReader_GetmaxPoints_29(HandleRef pThis);

		public virtual int GetmaxPoints()
		{
			return vtkMPASReader.vtkMPASReader_GetmaxPoints_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMPASReader_GetnumCellVars_30(HandleRef pThis);

		public virtual int GetnumCellVars()
		{
			return vtkMPASReader.vtkMPASReader_GetnumCellVars_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMPASReader_GetnumPointVars_31(HandleRef pThis);

		public virtual int GetnumPointVars()
		{
			return vtkMPASReader.vtkMPASReader_GetnumPointVars_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMPASReader_IsA_32(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMPASReader.vtkMPASReader_IsA_32(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMPASReader_IsTypeOf_33(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMPASReader.vtkMPASReader_IsTypeOf_33(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMPASReader_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMPASReader NewInstance()
		{
			vtkMPASReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_NewInstance_35(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMPASReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMPASReader_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMPASReader SafeDownCast(vtkObjectBase o)
		{
			vtkMPASReader vtkMPASReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMPASReader.vtkMPASReader_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMPASReader = (vtkMPASReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMPASReader.Register(null);
				}
			}
			return vtkMPASReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_SetCellArrayStatus_37(HandleRef pThis, string name, int status);

		public void SetCellArrayStatus(string name, int status)
		{
			vtkMPASReader.vtkMPASReader_SetCellArrayStatus_37(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_SetCenterLon_38(HandleRef pThis, int val);

		public void SetCenterLon(int val)
		{
			vtkMPASReader.vtkMPASReader_SetCenterLon_38(base.GetCppThis(), val);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_SetFileName_39(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkMPASReader.vtkMPASReader_SetFileName_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_SetIsAtmosphere_40(HandleRef pThis, byte val);

		public void SetIsAtmosphere(bool val)
		{
			vtkMPASReader.vtkMPASReader_SetIsAtmosphere_40(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_SetIsZeroCentered_41(HandleRef pThis, byte val);

		public void SetIsZeroCentered(bool val)
		{
			vtkMPASReader.vtkMPASReader_SetIsZeroCentered_41(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_SetLayerThickness_42(HandleRef pThis, int val);

		public void SetLayerThickness(int val)
		{
			vtkMPASReader.vtkMPASReader_SetLayerThickness_42(base.GetCppThis(), val);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_SetPointArrayStatus_43(HandleRef pThis, string name, int status);

		public void SetPointArrayStatus(string name, int status)
		{
			vtkMPASReader.vtkMPASReader_SetPointArrayStatus_43(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_SetProjectLatLon_44(HandleRef pThis, byte val);

		public void SetProjectLatLon(bool val)
		{
			vtkMPASReader.vtkMPASReader_SetProjectLatLon_44(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_SetShowMultilayerView_45(HandleRef pThis, byte val);

		public void SetShowMultilayerView(bool val)
		{
			vtkMPASReader.vtkMPASReader_SetShowMultilayerView_45(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMPASReader_SetVerticalLevel_46(HandleRef pThis, int level);

		public void SetVerticalLevel(int level)
		{
			vtkMPASReader.vtkMPASReader_SetVerticalLevel_46(base.GetCppThis(), level);
		}
	}
}

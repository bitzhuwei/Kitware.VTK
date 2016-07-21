using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataObjectToDataSetFilter : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectToDataSetFilter";

		public new static readonly string MRClassNameKey;

		static vtkDataObjectToDataSetFilter()
		{
			vtkDataObjectToDataSetFilter.MRClassNameKey = "class vtkDataObjectToDataSetFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectToDataSetFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectToDataSetFilter"));
		}

		public vtkDataObjectToDataSetFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataObjectToDataSetFilter New()
		{
			vtkDataObjectToDataSetFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectToDataSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataObjectToDataSetFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_DefaultNormalizeOff_01(HandleRef pThis);

		public virtual void DefaultNormalizeOff()
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_DefaultNormalizeOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_DefaultNormalizeOn_02(HandleRef pThis);

		public virtual void DefaultNormalizeOn()
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_DefaultNormalizeOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetCellConnectivityComponentArrayComponent_03(HandleRef pThis);

		public int GetCellConnectivityComponentArrayComponent()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellConnectivityComponentArrayComponent_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetCellConnectivityComponentArrayName_04(HandleRef pThis);

		public string GetCellConnectivityComponentArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellConnectivityComponentArrayName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetCellConnectivityComponentMaxRange_05(HandleRef pThis);

		public int GetCellConnectivityComponentMaxRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellConnectivityComponentMaxRange_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetCellConnectivityComponentMinRange_06(HandleRef pThis);

		public int GetCellConnectivityComponentMinRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellConnectivityComponentMinRange_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetCellTypeComponentArrayComponent_07(HandleRef pThis);

		public int GetCellTypeComponentArrayComponent()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellTypeComponentArrayComponent_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetCellTypeComponentArrayName_08(HandleRef pThis);

		public string GetCellTypeComponentArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellTypeComponentArrayName_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetCellTypeComponentMaxRange_09(HandleRef pThis);

		public int GetCellTypeComponentMaxRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellTypeComponentMaxRange_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetCellTypeComponentMinRange_10(HandleRef pThis);

		public int GetCellTypeComponentMinRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellTypeComponentMinRange_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetDataSetType_11(HandleRef pThis);

		public virtual int GetDataSetType()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetDataSetType_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetDefaultNormalize_12(HandleRef pThis);

		public virtual int GetDefaultNormalize()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetDefaultNormalize_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetDimensions_13(HandleRef pThis);

		public virtual int[] GetDimensions()
		{
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetDimensions_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_GetDimensions_14(HandleRef pThis, IntPtr data);

		public virtual void GetDimensions(IntPtr data)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetDimensions_14(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetInput_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetInput_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetLinesComponentArrayComponent_16(HandleRef pThis);

		public int GetLinesComponentArrayComponent()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetLinesComponentArrayComponent_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetLinesComponentArrayName_17(HandleRef pThis);

		public string GetLinesComponentArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetLinesComponentArrayName_17(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetLinesComponentMaxRange_18(HandleRef pThis);

		public int GetLinesComponentMaxRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetLinesComponentMaxRange_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetLinesComponentMinRange_19(HandleRef pThis);

		public int GetLinesComponentMinRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetLinesComponentMinRange_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetOrigin_20(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetOrigin_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_GetOrigin_21(HandleRef pThis, IntPtr data);

		public virtual void GetOrigin(IntPtr data)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetOrigin_21(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetOutput_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSet GetOutput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetOutput_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetOutput_23(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSet GetOutput(int idx)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetOutput_23(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetPointComponentArrayComponent_24(HandleRef pThis, int comp);

		public int GetPointComponentArrayComponent(int comp)
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPointComponentArrayComponent_24(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetPointComponentArrayName_25(HandleRef pThis, int comp);

		public string GetPointComponentArrayName(int comp)
		{
			return Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPointComponentArrayName_25(base.GetCppThis(), comp));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetPointComponentMaxRange_26(HandleRef pThis, int comp);

		public int GetPointComponentMaxRange(int comp)
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPointComponentMaxRange_26(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetPointComponentMinRange_27(HandleRef pThis, int comp);

		public int GetPointComponentMinRange(int comp)
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPointComponentMinRange_27(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetPointComponentNormailzeFlag_28(HandleRef pThis, int comp);

		public int GetPointComponentNormailzeFlag(int comp)
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPointComponentNormailzeFlag_28(base.GetCppThis(), comp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetPolyDataOutput_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyData GetPolyDataOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPolyDataOutput_29(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetPolysComponentArrayComponent_30(HandleRef pThis);

		public int GetPolysComponentArrayComponent()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPolysComponentArrayComponent_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetPolysComponentArrayName_31(HandleRef pThis);

		public string GetPolysComponentArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPolysComponentArrayName_31(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetPolysComponentMaxRange_32(HandleRef pThis);

		public int GetPolysComponentMaxRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPolysComponentMaxRange_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetPolysComponentMinRange_33(HandleRef pThis);

		public int GetPolysComponentMinRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPolysComponentMinRange_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetRectilinearGridOutput_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRectilinearGrid GetRectilinearGridOutput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetRectilinearGridOutput_34(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetSpacing_35(HandleRef pThis);

		public virtual double[] GetSpacing()
		{
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetSpacing_35(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_GetSpacing_36(HandleRef pThis, IntPtr data);

		public virtual void GetSpacing(IntPtr data)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetSpacing_36(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetStripsComponentArrayComponent_37(HandleRef pThis);

		public int GetStripsComponentArrayComponent()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetStripsComponentArrayComponent_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetStripsComponentArrayName_38(HandleRef pThis);

		public string GetStripsComponentArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetStripsComponentArrayName_38(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetStripsComponentMaxRange_39(HandleRef pThis);

		public int GetStripsComponentMaxRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetStripsComponentMaxRange_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetStripsComponentMinRange_40(HandleRef pThis);

		public int GetStripsComponentMinRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetStripsComponentMinRange_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetStructuredGridOutput_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredGrid GetStructuredGridOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetStructuredGridOutput_41(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetStructuredPointsOutput_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredPoints GetStructuredPointsOutput()
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetStructuredPointsOutput_42(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetUnstructuredGridOutput_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGrid GetUnstructuredGridOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetUnstructuredGridOutput_43(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetVertsComponentArrayComponent_44(HandleRef pThis);

		public int GetVertsComponentArrayComponent()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetVertsComponentArrayComponent_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetVertsComponentArrayName_45(HandleRef pThis);

		public string GetVertsComponentArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetVertsComponentArrayName_45(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetVertsComponentMaxRange_46(HandleRef pThis);

		public int GetVertsComponentMaxRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetVertsComponentMaxRange_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_GetVertsComponentMinRange_47(HandleRef pThis);

		public int GetVertsComponentMinRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetVertsComponentMinRange_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_IsA_48(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_IsA_48(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataObjectToDataSetFilter_IsTypeOf_49(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_IsTypeOf_49(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_NewInstance_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataObjectToDataSetFilter NewInstance()
		{
			vtkDataObjectToDataSetFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_NewInstance_51(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectToDataSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_SafeDownCast_52(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataObjectToDataSetFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDataObjectToDataSetFilter vtkDataObjectToDataSetFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SafeDownCast_52((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectToDataSetFilter = (vtkDataObjectToDataSetFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectToDataSetFilter.Register(null);
				}
			}
			return vtkDataObjectToDataSetFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetCellConnectivityComponent_53(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

		public void SetCellConnectivityComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetCellConnectivityComponent_53(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetCellConnectivityComponent_54(HandleRef pThis, string arrayName, int arrayComp);

		public void SetCellConnectivityComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetCellConnectivityComponent_54(base.GetCppThis(), arrayName, arrayComp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetCellTypeComponent_55(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

		public void SetCellTypeComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetCellTypeComponent_55(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetCellTypeComponent_56(HandleRef pThis, string arrayName, int arrayComp);

		public void SetCellTypeComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetCellTypeComponent_56(base.GetCppThis(), arrayName, arrayComp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetDataSetType_57(HandleRef pThis, int arg0);

		public void SetDataSetType(int arg0)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDataSetType_57(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetDataSetTypeToPolyData_58(HandleRef pThis);

		public void SetDataSetTypeToPolyData()
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDataSetTypeToPolyData_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetDataSetTypeToRectilinearGrid_59(HandleRef pThis);

		public void SetDataSetTypeToRectilinearGrid()
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDataSetTypeToRectilinearGrid_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetDataSetTypeToStructuredGrid_60(HandleRef pThis);

		public void SetDataSetTypeToStructuredGrid()
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDataSetTypeToStructuredGrid_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetDataSetTypeToStructuredPoints_61(HandleRef pThis);

		public void SetDataSetTypeToStructuredPoints()
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDataSetTypeToStructuredPoints_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetDataSetTypeToUnstructuredGrid_62(HandleRef pThis);

		public void SetDataSetTypeToUnstructuredGrid()
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDataSetTypeToUnstructuredGrid_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetDefaultNormalize_63(HandleRef pThis, int _arg);

		public virtual void SetDefaultNormalize(int _arg)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDefaultNormalize_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetDimensions_64(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetDimensions(int _arg1, int _arg2, int _arg3)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDimensions_64(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetDimensions_65(HandleRef pThis, IntPtr _arg);

		public virtual void SetDimensions(IntPtr _arg)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDimensions_65(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetDimensionsComponent_66(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

		public void SetDimensionsComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDimensionsComponent_66(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetDimensionsComponent_67(HandleRef pThis, string arrayName, int arrayComp);

		public void SetDimensionsComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDimensionsComponent_67(base.GetCppThis(), arrayName, arrayComp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetLinesComponent_68(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

		public void SetLinesComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetLinesComponent_68(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetLinesComponent_69(HandleRef pThis, string arrayName, int arrayComp);

		public void SetLinesComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetLinesComponent_69(base.GetCppThis(), arrayName, arrayComp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetOrigin_70(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetOrigin_70(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetOrigin_71(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetOrigin_71(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetOriginComponent_72(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

		public void SetOriginComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetOriginComponent_72(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetOriginComponent_73(HandleRef pThis, string arrayName, int arrayComp);

		public void SetOriginComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetOriginComponent_73(base.GetCppThis(), arrayName, arrayComp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetPointComponent_74(HandleRef pThis, int comp, string arrayName, int arrayComp, int min, int max, int normalize);

		public void SetPointComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetPointComponent_74(base.GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetPointComponent_75(HandleRef pThis, int comp, string arrayName, int arrayComp);

		public void SetPointComponent(int comp, string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetPointComponent_75(base.GetCppThis(), comp, arrayName, arrayComp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetPolysComponent_76(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

		public void SetPolysComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetPolysComponent_76(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetPolysComponent_77(HandleRef pThis, string arrayName, int arrayComp);

		public void SetPolysComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetPolysComponent_77(base.GetCppThis(), arrayName, arrayComp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetSpacing_78(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetSpacing_78(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetSpacing_79(HandleRef pThis, IntPtr _arg);

		public virtual void SetSpacing(IntPtr _arg)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetSpacing_79(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetSpacingComponent_80(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

		public void SetSpacingComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetSpacingComponent_80(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetSpacingComponent_81(HandleRef pThis, string arrayName, int arrayComp);

		public void SetSpacingComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetSpacingComponent_81(base.GetCppThis(), arrayName, arrayComp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetStripsComponent_82(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

		public void SetStripsComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetStripsComponent_82(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetStripsComponent_83(HandleRef pThis, string arrayName, int arrayComp);

		public void SetStripsComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetStripsComponent_83(base.GetCppThis(), arrayName, arrayComp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetVertsComponent_84(HandleRef pThis, string arrayName, int arrayComp, int min, int max);

		public void SetVertsComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetVertsComponent_84(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataObjectToDataSetFilter_SetVertsComponent_85(HandleRef pThis, string arrayName, int arrayComp);

		public void SetVertsComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetVertsComponent_85(base.GetCppThis(), arrayName, arrayComp);
		}
	}
}

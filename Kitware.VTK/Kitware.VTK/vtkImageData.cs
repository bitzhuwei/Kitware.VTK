using Kitware.mummy.Runtime;
using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageData : vtkDataSet
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageData";

		public new static readonly string MRClassNameKey;

		static vtkImageData()
		{
			vtkImageData.MRClassNameKey = "class vtkImageData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageData"));
		}

		public vtkImageData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageData New()
		{
			vtkImageData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageData.vtkImageData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageData.vtkImageData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_AllocateScalars_01(HandleRef pThis);

		public virtual void AllocateScalars()
		{
			vtkImageData.vtkImageData_AllocateScalars_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_ComputeBounds_02(HandleRef pThis);

		public override void ComputeBounds()
		{
			vtkImageData.vtkImageData_ComputeBounds_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkImageData_ComputeCellId_03(HandleRef pThis, IntPtr ijk);

		public virtual long ComputeCellId(IntPtr ijk)
		{
			return vtkImageData.vtkImageData_ComputeCellId_03(base.GetCppThis(), ijk);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_ComputeInternalExtent_04(HandleRef pThis, IntPtr intExt, IntPtr tgtExt, IntPtr bnds);

		public void ComputeInternalExtent(IntPtr intExt, IntPtr tgtExt, IntPtr bnds)
		{
			vtkImageData.vtkImageData_ComputeInternalExtent_04(base.GetCppThis(), intExt, tgtExt, bnds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkImageData_ComputePointId_05(HandleRef pThis, IntPtr ijk);

		public virtual long ComputePointId(IntPtr ijk)
		{
			return vtkImageData.vtkImageData_ComputePointId_05(base.GetCppThis(), ijk);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageData_ComputeStructuredCoordinates_06(HandleRef pThis, IntPtr x, IntPtr ijk, IntPtr pcoords);

		public virtual int ComputeStructuredCoordinates(IntPtr x, IntPtr ijk, IntPtr pcoords)
		{
			return vtkImageData.vtkImageData_ComputeStructuredCoordinates_06(base.GetCppThis(), x, ijk, pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_CopyAndCastFrom_07(HandleRef pThis, HandleRef inData, IntPtr extent);

		public virtual void CopyAndCastFrom(vtkImageData inData, IntPtr extent)
		{
			vtkImageData.vtkImageData_CopyAndCastFrom_07(base.GetCppThis(), (inData == null) ? default(HandleRef) : inData.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_CopyAndCastFrom_08(HandleRef pThis, HandleRef inData, int x0, int x1, int y0, int y1, int z0, int z1);

		public virtual void CopyAndCastFrom(vtkImageData inData, int x0, int x1, int y0, int y1, int z0, int z1)
		{
			vtkImageData.vtkImageData_CopyAndCastFrom_08(base.GetCppThis(), (inData == null) ? default(HandleRef) : inData.GetCppThis(), x0, x1, y0, y1, z0, z1);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_CopyInformationFromPipeline_09(HandleRef pThis, HandleRef request);

		public override void CopyInformationFromPipeline(vtkInformation request)
		{
			vtkImageData.vtkImageData_CopyInformationFromPipeline_09(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_CopyInformationToPipeline_10(HandleRef pThis, HandleRef request, HandleRef input, HandleRef output, int forceCopy);

		public override void CopyInformationToPipeline(vtkInformation request, vtkInformation input, vtkInformation output, int forceCopy)
		{
			vtkImageData.vtkImageData_CopyInformationToPipeline_10(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), forceCopy);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_CopyStructure_11(HandleRef pThis, HandleRef ds);

		public override void CopyStructure(vtkDataSet ds)
		{
			vtkImageData.vtkImageData_CopyStructure_11(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_CopyTypeSpecificInformation_12(HandleRef pThis, HandleRef image);

		public override void CopyTypeSpecificInformation(vtkDataObject image)
		{
			vtkImageData.vtkImageData_CopyTypeSpecificInformation_12(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_Crop_13(HandleRef pThis);

		public override void Crop()
		{
			vtkImageData.vtkImageData_Crop_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_DeepCopy_14(HandleRef pThis, HandleRef src);

		public override void DeepCopy(vtkDataObject src)
		{
			vtkImageData.vtkImageData_DeepCopy_14(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_FindAndGetCell_15(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell FindAndGetCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageData.vtkImageData_FindAndGetCell_15(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkImageData_FindCell_16(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		public override long FindCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkImageData.vtkImageData_FindCell_16(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkImageData_FindCell_17(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkImageData.vtkImageData_FindCell_17(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (gencell == null) ? default(HandleRef) : gencell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkImageData_FindPoint_18(HandleRef pThis, double x, double y, double z);

		public new virtual long FindPoint(double x, double y, double z)
		{
			return vtkImageData.vtkImageData_FindPoint_18(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkImageData_FindPoint_19(HandleRef pThis, IntPtr x);

		public override long FindPoint(IntPtr x)
		{
			return vtkImageData.vtkImageData_FindPoint_19(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkImageData_GetActualMemorySize_20(HandleRef pThis);

		public override uint GetActualMemorySize()
		{
			return vtkImageData.vtkImageData_GetActualMemorySize_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetArrayIncrements_21(HandleRef pThis, HandleRef array, IntPtr increments);

		public void GetArrayIncrements(vtkDataArray array, IntPtr increments)
		{
			vtkImageData.vtkImageData_GetArrayIncrements_21(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis(), increments);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetArrayPointer_22(HandleRef pThis, HandleRef array, IntPtr coordinates);

		public IntPtr GetArrayPointer(vtkDataArray array, IntPtr coordinates)
		{
			return vtkImageData.vtkImageData_GetArrayPointer_22(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis(), coordinates);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetArrayPointerForExtent_23(HandleRef pThis, HandleRef array, IntPtr extent);

		public IntPtr GetArrayPointerForExtent(vtkDataArray array, IntPtr extent)
		{
			return vtkImageData.vtkImageData_GetArrayPointerForExtent_23(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetAxisUpdateExtent_24(HandleRef pThis, int axis, ref int min, ref int max);

		public virtual void GetAxisUpdateExtent(int axis, ref int min, ref int max)
		{
			vtkImageData.vtkImageData_GetAxisUpdateExtent_24(base.GetCppThis(), axis, ref min, ref max);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetCell_25(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageData.vtkImageData_GetCell_25(base.GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetCell_26(HandleRef pThis, long cellId, HandleRef cell);

		public override void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkImageData.vtkImageData_GetCell_26(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetCellBounds_27(HandleRef pThis, long cellId, IntPtr bounds);

		public override void GetCellBounds(long cellId, IntPtr bounds)
		{
			vtkImageData.vtkImageData_GetCellBounds_27(base.GetCppThis(), cellId, bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetCellPoints_28(HandleRef pThis, long cellId, HandleRef ptIds);

		public override void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkImageData.vtkImageData_GetCellPoints_28(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageData_GetCellType_29(HandleRef pThis, long cellId);

		public override int GetCellType(long cellId)
		{
			return vtkImageData.vtkImageData_GetCellType_29(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetContinuousIncrements_30(HandleRef pThis, IntPtr extent, ref long incX, ref long incY, ref long incZ);

		public virtual void GetContinuousIncrements(IntPtr extent, ref long incX, ref long incY, ref long incZ)
		{
			vtkImageData.vtkImageData_GetContinuousIncrements_30(base.GetCppThis(), extent, ref incX, ref incY, ref incZ);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetData_31(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageData GetData(vtkInformation info)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageData.vtkImageData_GetData_31((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetData_32(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageData GetData(vtkInformationVector v, int i)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageData.vtkImageData_GetData_32((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageData_GetDataDimension_33(HandleRef pThis);

		public virtual int GetDataDimension()
		{
			return vtkImageData.vtkImageData_GetDataDimension_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageData_GetDataObjectType_34(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkImageData.vtkImageData_GetDataObjectType_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetDimensions_35(HandleRef pThis);

		public virtual int[] GetDimensions()
		{
			IntPtr intPtr = vtkImageData.vtkImageData_GetDimensions_35(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetDimensions_36(HandleRef pThis, IntPtr dims);

		public virtual void GetDimensions(IntPtr dims)
		{
			vtkImageData.vtkImageData_GetDimensions_36(base.GetCppThis(), dims);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkImageData_GetEstimatedMemorySize_37(HandleRef pThis);

		public override uint GetEstimatedMemorySize()
		{
			return vtkImageData.vtkImageData_GetEstimatedMemorySize_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetExtent_38(HandleRef pThis);

		public virtual int[] GetExtent()
		{
			IntPtr intPtr = vtkImageData.vtkImageData_GetExtent_38(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetExtent_39(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageData.vtkImageData_GetExtent_39(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetExtent_40(HandleRef pThis, IntPtr _arg);

		public virtual void GetExtent(IntPtr _arg)
		{
			vtkImageData.vtkImageData_GetExtent_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageData_GetExtentType_41(HandleRef pThis);

		public override int GetExtentType()
		{
			return vtkImageData.vtkImageData_GetExtentType_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetIncrements_42(HandleRef pThis);

		public virtual IntPtr GetIncrements()
		{
			return vtkImageData.vtkImageData_GetIncrements_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetIncrements_43(HandleRef pThis, ref long incX, ref long incY, ref long incZ);

		public virtual void GetIncrements(ref long incX, ref long incY, ref long incZ)
		{
			vtkImageData.vtkImageData_GetIncrements_43(base.GetCppThis(), ref incX, ref incY, ref incZ);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetIncrements_44(HandleRef pThis, IntPtr inc);

		public virtual void GetIncrements(IntPtr inc)
		{
			vtkImageData.vtkImageData_GetIncrements_44(base.GetCppThis(), inc);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageData_GetMaxCellSize_45(HandleRef pThis);

		public override int GetMaxCellSize()
		{
			return vtkImageData.vtkImageData_GetMaxCellSize_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkImageData_GetNumberOfCells_46(HandleRef pThis);

		public override long GetNumberOfCells()
		{
			return vtkImageData.vtkImageData_GetNumberOfCells_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkImageData_GetNumberOfPoints_47(HandleRef pThis);

		public override long GetNumberOfPoints()
		{
			return vtkImageData.vtkImageData_GetNumberOfPoints_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageData_GetNumberOfScalarComponents_48(HandleRef pThis);

		public int GetNumberOfScalarComponents()
		{
			return vtkImageData.vtkImageData_GetNumberOfScalarComponents_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetOrigin_49(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkImageData.vtkImageData_GetOrigin_49(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetOrigin_50(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageData.vtkImageData_GetOrigin_50(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetOrigin_51(HandleRef pThis, IntPtr _arg);

		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkImageData.vtkImageData_GetOrigin_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetPoint_52(HandleRef pThis, long ptId);

		public override double[] GetPoint(long ptId)
		{
			IntPtr intPtr = vtkImageData.vtkImageData_GetPoint_52(base.GetCppThis(), ptId);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetPoint_53(HandleRef pThis, long id, IntPtr x);

		public override void GetPoint(long id, IntPtr x)
		{
			vtkImageData.vtkImageData_GetPoint_53(base.GetCppThis(), id, x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetPointCells_54(HandleRef pThis, long ptId, HandleRef cellIds);

		public override void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkImageData.vtkImageData_GetPointCells_54(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetPointGradient_55(HandleRef pThis, int i, int j, int k, HandleRef s, IntPtr g);

		public virtual void GetPointGradient(int i, int j, int k, vtkDataArray s, IntPtr g)
		{
			vtkImageData.vtkImageData_GetPointGradient_55(base.GetCppThis(), i, j, k, (s == null) ? default(HandleRef) : s.GetCppThis(), g);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImageData_GetScalarComponentAsDouble_56(HandleRef pThis, int x, int y, int z, int component);

		public virtual double GetScalarComponentAsDouble(int x, int y, int z, int component)
		{
			return vtkImageData.vtkImageData_GetScalarComponentAsDouble_56(base.GetCppThis(), x, y, z, component);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern float vtkImageData_GetScalarComponentAsFloat_57(HandleRef pThis, int x, int y, int z, int component);

		public virtual float GetScalarComponentAsFloat(int x, int y, int z, int component)
		{
			return vtkImageData.vtkImageData_GetScalarComponentAsFloat_57(base.GetCppThis(), x, y, z, component);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetScalarPointer_58(HandleRef pThis, IntPtr coordinates);

		public virtual IntPtr GetScalarPointer(IntPtr coordinates)
		{
			return vtkImageData.vtkImageData_GetScalarPointer_58(base.GetCppThis(), coordinates);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetScalarPointer_59(HandleRef pThis, int x, int y, int z);

		public virtual IntPtr GetScalarPointer(int x, int y, int z)
		{
			return vtkImageData.vtkImageData_GetScalarPointer_59(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetScalarPointer_60(HandleRef pThis);

		public virtual IntPtr GetScalarPointer()
		{
			return vtkImageData.vtkImageData_GetScalarPointer_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetScalarPointerForExtent_61(HandleRef pThis, IntPtr extent);

		public virtual IntPtr GetScalarPointerForExtent(IntPtr extent)
		{
			return vtkImageData.vtkImageData_GetScalarPointerForExtent_61(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageData_GetScalarSize_62(HandleRef pThis);

		public virtual int GetScalarSize()
		{
			return vtkImageData.vtkImageData_GetScalarSize_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageData_GetScalarType_63(HandleRef pThis);

		public int GetScalarType()
		{
			return vtkImageData.vtkImageData_GetScalarType_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetScalarTypeAsString_64(HandleRef pThis);

		public string GetScalarTypeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkImageData.vtkImageData_GetScalarTypeAsString_64(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImageData_GetScalarTypeMax_65(HandleRef pThis);

		public virtual double GetScalarTypeMax()
		{
			return vtkImageData.vtkImageData_GetScalarTypeMax_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImageData_GetScalarTypeMin_66(HandleRef pThis);

		public virtual double GetScalarTypeMin()
		{
			return vtkImageData.vtkImageData_GetScalarTypeMin_66(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_GetSpacing_67(HandleRef pThis);

		public virtual double[] GetSpacing()
		{
			IntPtr intPtr = vtkImageData.vtkImageData_GetSpacing_67(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetSpacing_68(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageData.vtkImageData_GetSpacing_68(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetSpacing_69(HandleRef pThis, IntPtr _arg);

		public virtual void GetSpacing(IntPtr _arg)
		{
			vtkImageData.vtkImageData_GetSpacing_69(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_GetVoxelGradient_70(HandleRef pThis, int i, int j, int k, HandleRef s, HandleRef g);

		public virtual void GetVoxelGradient(int i, int j, int k, vtkDataArray s, vtkDataArray g)
		{
			vtkImageData.vtkImageData_GetVoxelGradient_70(base.GetCppThis(), i, j, k, (s == null) ? default(HandleRef) : s.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_Initialize_71(HandleRef pThis);

		public override void Initialize()
		{
			vtkImageData.vtkImageData_Initialize_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageData_IsA_72(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageData.vtkImageData_IsA_72(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageData_IsTypeOf_73(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageData.vtkImageData_IsTypeOf_73(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_NewInstance_75(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageData NewInstance()
		{
			vtkImageData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageData.vtkImageData_NewInstance_75(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_PrepareForNewData_76(HandleRef pThis);

		public override void PrepareForNewData()
		{
			vtkImageData.vtkImageData_PrepareForNewData_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageData_SafeDownCast_77(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageData SafeDownCast(vtkObjectBase o)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageData.vtkImageData_SafeDownCast_77((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetAxisUpdateExtent_78(HandleRef pThis, int axis, int min, int max);

		public virtual void SetAxisUpdateExtent(int axis, int min, int max)
		{
			vtkImageData.vtkImageData_SetAxisUpdateExtent_78(base.GetCppThis(), axis, min, max);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetDimensions_79(HandleRef pThis, int i, int j, int k);

		public virtual void SetDimensions(int i, int j, int k)
		{
			vtkImageData.vtkImageData_SetDimensions_79(base.GetCppThis(), i, j, k);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetDimensions_80(HandleRef pThis, IntPtr dims);

		public virtual void SetDimensions(IntPtr dims)
		{
			vtkImageData.vtkImageData_SetDimensions_80(base.GetCppThis(), dims);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetExtent_81(HandleRef pThis, IntPtr extent);

		public virtual void SetExtent(IntPtr extent)
		{
			vtkImageData.vtkImageData_SetExtent_81(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetExtent_82(HandleRef pThis, int x1, int x2, int y1, int y2, int z1, int z2);

		public virtual void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
		{
			vtkImageData.vtkImageData_SetExtent_82(base.GetCppThis(), x1, x2, y1, y2, z1, z2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetNumberOfScalarComponents_83(HandleRef pThis, int n);

		public void SetNumberOfScalarComponents(int n)
		{
			vtkImageData.vtkImageData_SetNumberOfScalarComponents_83(base.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetOrigin_84(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkImageData.vtkImageData_SetOrigin_84(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetOrigin_85(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkImageData.vtkImageData_SetOrigin_85(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetScalarComponentFromDouble_86(HandleRef pThis, int x, int y, int z, int component, double v);

		public virtual void SetScalarComponentFromDouble(int x, int y, int z, int component, double v)
		{
			vtkImageData.vtkImageData_SetScalarComponentFromDouble_86(base.GetCppThis(), x, y, z, component, v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetScalarComponentFromFloat_87(HandleRef pThis, int x, int y, int z, int component, float v);

		public virtual void SetScalarComponentFromFloat(int x, int y, int z, int component, float v)
		{
			vtkImageData.vtkImageData_SetScalarComponentFromFloat_87(base.GetCppThis(), x, y, z, component, v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetScalarType_88(HandleRef pThis, int arg0);

		public void SetScalarType(int arg0)
		{
			vtkImageData.vtkImageData_SetScalarType_88(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetScalarTypeToChar_89(HandleRef pThis);

		public void SetScalarTypeToChar()
		{
			vtkImageData.vtkImageData_SetScalarTypeToChar_89(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetScalarTypeToDouble_90(HandleRef pThis);

		public void SetScalarTypeToDouble()
		{
			vtkImageData.vtkImageData_SetScalarTypeToDouble_90(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetScalarTypeToFloat_91(HandleRef pThis);

		public void SetScalarTypeToFloat()
		{
			vtkImageData.vtkImageData_SetScalarTypeToFloat_91(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetScalarTypeToInt_92(HandleRef pThis);

		public void SetScalarTypeToInt()
		{
			vtkImageData.vtkImageData_SetScalarTypeToInt_92(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetScalarTypeToLong_93(HandleRef pThis);

		public void SetScalarTypeToLong()
		{
			vtkImageData.vtkImageData_SetScalarTypeToLong_93(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetScalarTypeToShort_94(HandleRef pThis);

		public void SetScalarTypeToShort()
		{
			vtkImageData.vtkImageData_SetScalarTypeToShort_94(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetScalarTypeToSignedChar_95(HandleRef pThis);

		public void SetScalarTypeToSignedChar()
		{
			vtkImageData.vtkImageData_SetScalarTypeToSignedChar_95(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetScalarTypeToUnsignedChar_96(HandleRef pThis);

		public void SetScalarTypeToUnsignedChar()
		{
			vtkImageData.vtkImageData_SetScalarTypeToUnsignedChar_96(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetScalarTypeToUnsignedInt_97(HandleRef pThis);

		public void SetScalarTypeToUnsignedInt()
		{
			vtkImageData.vtkImageData_SetScalarTypeToUnsignedInt_97(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetScalarTypeToUnsignedLong_98(HandleRef pThis);

		public void SetScalarTypeToUnsignedLong()
		{
			vtkImageData.vtkImageData_SetScalarTypeToUnsignedLong_98(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetScalarTypeToUnsignedShort_99(HandleRef pThis);

		public void SetScalarTypeToUnsignedShort()
		{
			vtkImageData.vtkImageData_SetScalarTypeToUnsignedShort_99(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetSpacing_100(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageData.vtkImageData_SetSpacing_100(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_SetSpacing_101(HandleRef pThis, IntPtr _arg);

		public virtual void SetSpacing(IntPtr _arg)
		{
			vtkImageData.vtkImageData_SetSpacing_101(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_ShallowCopy_102(HandleRef pThis, HandleRef src);

		public override void ShallowCopy(vtkDataObject src)
		{
			vtkImageData.vtkImageData_ShallowCopy_102(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImageData_UpdateInformation_103(HandleRef pThis);

		public override void UpdateInformation()
		{
			vtkImageData.vtkImageData_UpdateInformation_103(base.GetCppThis());
		}

		public static vtkImageData FromImage(Image img)
		{
			return vtkImageData.FromImage(img, 4);
		}

		public static vtkImageData FromImage(Image img, int numberOfScalarComponents)
		{
			Bitmap bitmap = new Bitmap(img);
			vtkImageData vtkImageData = vtkImageData.New();
			vtkImageData.SetScalarTypeToUnsignedChar();
			vtkImageData.SetNumberOfScalarComponents(numberOfScalarComponents);
			vtkImageData.SetDimensions(img.Width, img.Height, 1);
			vtkImageData.AllocateScalars();
			byte[] array = new byte[img.Width * img.Height * vtkImageData.GetNumberOfScalarComponents()];
			int num = 0;
			for (int i = img.Height - 1; i >= 0; i--)
			{
				for (int j = 0; j < img.Width; j++)
				{
					array[num++] = bitmap.GetPixel(j, i).R;
					array[num++] = bitmap.GetPixel(j, i).G;
					array[num++] = bitmap.GetPixel(j, i).B;
					if (numberOfScalarComponents > 3)
					{
						array[num++] = bitmap.GetPixel(j, i).A;
					}
				}
			}
			Marshal.Copy(array, 0, vtkImageData.GetScalarPointer(), array.Length);
			return vtkImageData;
		}

		public Bitmap ToBitmap()
		{
			int num = (int)(this.GetBounds()[1] - this.GetBounds()[0]) + 1;
			int num2 = (int)(this.GetBounds()[3] - this.GetBounds()[2]) + 1;
			Bitmap bitmap = new Bitmap(num, num2);
			byte[] array = new byte[num * num2 * this.GetNumberOfScalarComponents()];
			Marshal.Copy(this.GetScalarPointer(), array, 0, num * num2 * this.GetNumberOfScalarComponents());
			int num3 = 0;
			for (int i = num2 - 1; i >= 0; i--)
			{
				for (int j = 0; j < num; j++)
				{
					if (this.GetNumberOfScalarComponents() == 3)
					{
						bitmap.SetPixel(j, i, Color.FromArgb((int)array[num3++], (int)array[num3++], (int)array[num3++]));
					}
					else
					{
						if (this.GetNumberOfScalarComponents() != 4)
						{
							throw new Exception("Invalid Number of Scalar Components");
						}
						bitmap.SetPixel(j, i, Color.FromArgb((int)array[num3++], (int)array[num3++], (int)array[num3++], (int)array[num3++]));
					}
				}
			}
			return bitmap;
		}
	}
}
